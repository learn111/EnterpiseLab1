using System.Linq;
using System.Windows.Forms;
using BLL.Contracts;
using BLL.Models;
using Common;
using CommonContracts;
using Presentation.Common;
using Presentation.Views;

namespace Presentation.Presenters
{
    internal class DishTypesPresenter : PresenterBase<IDishTypesView>
    {
        private readonly IDishTypesService _dishTypesService;

        public DishTypesPresenter(IDishTypesView view, IApplicationController applicationController,
            IDishTypesService dishTypesService)
            : base(view, applicationController)
        {
            _dishTypesService = dishTypesService;
            FillForm();
            Subscribe();
        }

        private void Subscribe()
        {
            View.SaveClicked +=
                () =>
                    ExecutionHelper.ExecuteWithTry(View_SaveClicked,
                        x => MessageBox.Show(x, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error));
        }

        private void View_SaveClicked()
        {
            var toUpdate =
                View.DishTypes.Where(x => !x.Removed && x.Id.HasValue).Select(x => new DishType
                {
                    DishTypeId = x.Id,
                    Name = x.Name
                });
            foreach (var item in toUpdate)
            {
                _dishTypesService.Update(item);
            }
            var toDelete =
                View.DishTypes.Where(x => x.Removed && x.Id.HasValue).Select(x => new DishType
                {
                    DishTypeId = x.Id
                });
            foreach (var item in toDelete)
            {
                _dishTypesService.Delete(item);
            }
            var toAdd =
                View.DishTypes.Where(x => !x.Removed && !x.Id.HasValue).Select(x => new DishType
                {
                    Name = x.Name
                });
            foreach (var measurementUnit in toAdd)
            {
                _dishTypesService.Add(measurementUnit);
            }
            FillForm();
        }

        private void FillForm()
        {
            View.DishTypes = _dishTypesService.GetAll().Select(x => new DishTypeModel
            {
                Id = x.DishTypeId,
                Name = x.Name
            });
        }

        public override void Run()
        {
            View.ShowDialog();
        }
    }
}