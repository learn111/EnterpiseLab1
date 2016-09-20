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
    public class DishesToFoodstuffsPresenter : PresenterBase<IDishesToFoodstuffsView>
    {
        private readonly IDishesService _dishesService;
        private readonly IDishesToFoodstuffsService _dishesToFoodstuffsService;
        private readonly IFoodstuffService _foodstuffService;
        private readonly IMeasurementUnitsService _measurementUnitsService;

        public DishesToFoodstuffsPresenter(IDishesToFoodstuffsView view, IApplicationController applicationController,
            IDishesService dishesService, IDishesToFoodstuffsService dishesToFoodstuffsService,
            IFoodstuffService foodstuffService, IMeasurementUnitsService measurementUnitsService)
            : base(view, applicationController)
        {
            _dishesService = dishesService;
            _dishesToFoodstuffsService = dishesToFoodstuffsService;
            _foodstuffService = foodstuffService;
            _measurementUnitsService = measurementUnitsService;
            FillForm();
            Subscribe();
        }

        private void Subscribe()
        {
            View.DishChanged += id =>
            {
                var dishesToFoodstuffs = _dishesToFoodstuffsService.GetAll().ToList();
                var measurementUnits = _measurementUnitsService.GetAll().ToList();
                View.DishesToFoodstuffs = _foodstuffService.GetAll().Select(x =>
                {
                    var item = dishesToFoodstuffs.FirstOrDefault(y => y.DishId == id && x.FoodstuffId == y.FoodstuffId);
                    return new DishToFoodstuffsModel
                    {
                        IsActive = item != null,
                        Consumption = item?.Consumption ?? 0,
                        FoodstuffId = x.FoodstuffId,
                        FoodstuffName = x.Name,
                        MeasurementUnit =
                            measurementUnits.FirstOrDefault(y => y.MeasurementUnitId == x.MeasurementUnitId)?.Name
                    };
                });
            };

            View.SaveClicked += () =>
                ExecutionHelper.ExecuteWithTry(View_SaveClicked,
                    x => MessageBox.Show(x, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error));
        }

        private void View_SaveClicked()
        {
            var dishesToFoodstuffs = _dishesToFoodstuffsService.GetAll().ToList();
            var dishId = View.DishId;

            foreach (var model in View.DishesToFoodstuffs)
            {
                var item =
                    dishesToFoodstuffs.FirstOrDefault(x => x.FoodstuffId == model.FoodstuffId && x.DishId == dishId);
                if (!model.IsActive && item != null)
                {
                    _dishesToFoodstuffsService.Delete(new DishesToFoodstuffs
                    {
                        DishesToFoodstuffsId = item.DishesToFoodstuffsId
                    });
                }
                if (model.IsActive && item != null)
                {
                    _dishesToFoodstuffsService.Update(new DishesToFoodstuffs
                    {
                        DishesToFoodstuffsId = item.DishesToFoodstuffsId,
                        Consumption = model.Consumption,
                        DishId = item.DishId,
                        FoodstuffId = item.FoodstuffId
                    });
                }
                if (model.IsActive && item == null)
                {
                    _dishesToFoodstuffsService.Add(new DishesToFoodstuffs
                    {
                        Consumption = model.Consumption,
                        DishId = dishId,
                        FoodstuffId = model.FoodstuffId.Value
                    });
                }
            }
        }

        private void FillForm()
        {
            View.Dishes = _dishesService.GetAll().Select(x => new KeyValueStringInt(x.Name, x.DishId.Value));
        }

        public override void Run()
        {
            View.ShowDialog();
        }
    }
}