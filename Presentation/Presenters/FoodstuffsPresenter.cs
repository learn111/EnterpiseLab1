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
    internal class FoodstuffsPresenter : PresenterBase<IFoodstuffView>
    {
        private readonly IFoodstuffService _foodstuffService;
        private readonly IMeasurementUnitsService _measurementUnitsService;

        public FoodstuffsPresenter(IFoodstuffView view, IApplicationController applicationController,
            IFoodstuffService foodstuffService, IMeasurementUnitsService measurementUnitsService)
            : base(view, applicationController)
        {
            _foodstuffService = foodstuffService;
            _measurementUnitsService = measurementUnitsService;
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
                View.Foodstuffs.Where(x => !x.Removed && x.Id.HasValue).Select(x => new Foodstuff
                {
                    FoodstuffId = x.Id,
                    Name = x.Name,
                    MeasurementUnitId = x.MeasurementUnitId,
                    Price = x.Price
                });
            foreach (var item in toUpdate)
            {
                _foodstuffService.Update(item);
            }
            var toDelete =
                View.Foodstuffs.Where(x => x.Removed && x.Id.HasValue).Select(x => new Foodstuff
                {
                    FoodstuffId = x.Id
                });
            foreach (var item in toDelete)
            {
                _foodstuffService.Delete(item);
            }
            var toAdd =
                View.Foodstuffs.Where(x => !x.Removed && !x.Id.HasValue).Select(x => new Foodstuff
                {
                    Name = x.Name,
                    MeasurementUnitId = x.MeasurementUnitId,
                    Price = x.Price
                });
            foreach (var measurementUnit in toAdd)
            {
                _foodstuffService.Add(measurementUnit);
            }
            FillForm();
        }

        private void FillForm()
        {
            View.MeasurementUnits =
                _measurementUnitsService.GetAll().Select(x => new KeyValueStringInt(x.Name, x.MeasurementUnitId.Value));
            View.Foodstuffs = _foodstuffService.GetAll().Select(x => new FoodstuffModel
            {
                Id = x.FoodstuffId,
                Name = x.Name,
                Price = x.Price,
                MeasurementUnitId = x.MeasurementUnitId
            });
        }

        public override void Run()
        {
            View.ShowDialog();
        }
    }
}