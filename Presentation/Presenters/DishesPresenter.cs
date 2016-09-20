using System;
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
    internal class DishesPresenter : PresenterBase<IDishesView>
    {
        private readonly IDishesService _dishesService;
        private readonly IDishTypesService _dishTypesService;

        public DishesPresenter(IDishesView view, IApplicationController applicationController, IDishesService dishesService, IDishTypesService dishTypesService)
            : base(view, applicationController)
        {
            _dishesService = dishesService;
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
                View.Dishes.Where(x => !x.Removed && x.Id.HasValue).Select(x => new Dish()
                {
                    DishId = x.Id,
                    Name = x.Name,
                    DishTypeId = x.DishTypeId,
                    Description = x.Description
                });
            foreach (var item in toUpdate)
            {
                _dishesService.Update(item);
            }
            var toDelete =
                View.Dishes.Where(x => x.Removed && x.Id.HasValue).Select(x => new Dish()
                {
                    DishId = x.Id
                });
            foreach (var item in toDelete)
            {
                _dishesService.Delete(item);
            }
            var toAdd =
                View.Dishes.Where(x => !x.Removed && !x.Id.HasValue).Select(x => new Dish()
                {
                    DishId = x.Id,
                    Name = x.Name,
                    DishTypeId = x.DishTypeId,
                    Description = x.Description
                });
            foreach (var measurementUnit in toAdd)
            {
                _dishesService.Add(measurementUnit);
            }
            FillForm();
        }

        private void FillForm()
        {
            View.DishTypes =
                _dishTypesService.GetAll().Select(x => new KeyValueStringInt(x.Name, x.DishTypeId.Value));
            View.Dishes = _dishesService.GetAll().Select(x => new DishModel()
            {
                Id = x.DishId,
                Name = x.Name,
                DishTypeId = x.DishTypeId,
                Description = x.Description
            });
        }
        public override void Run()
        {
            View.ShowDialog();
        }
    }
}