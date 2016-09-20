using System.Linq;
using System.Windows.Forms;
using BLL.Contracts;
using BLL.Models;
using Presentation.Common;
using Presentation.Views;

namespace Presentation.Presenters
{
    public class MainPresenter : PresenterBase<IMainView>
    {
        private readonly IDishesService _dishesService;
        private readonly IDishTypesService _dishTypesService;
        private readonly IReportGenerationService _reportGenerationService;

        public MainPresenter(IMainView view, IApplicationController applicationController, IDishesService dishesService,
            IDishTypesService dishTypesService, IReportGenerationService reportGenerationService)
            : base(view, applicationController)
        {
            _dishesService = dishesService;
            _dishTypesService = dishTypesService;
            _reportGenerationService = reportGenerationService;
            FillForm();
            Subscribe();
        }

        private void FillForm()
        {
            var types = _dishTypesService.GetAll().ToList();
            View.Dishes = _dishesService.GetAll().Select(x => new DishCookModel
            {
                DishId = x.DishId.Value,
                DishName = x.Name,
                DishType = types.FirstOrDefault(y => y.DishTypeId == x.DishTypeId)?.Name
            });
        }

        private void Subscribe()
        {
            View.MeasurementUnitsClicked += () => ApplicationController.Run<MeasurementUnitsPresenter>();
            View.DishTypesClicked += () => ApplicationController.Run<DishTypesPresenter>();
            View.FoodstuffsClicked += () => ApplicationController.Run<FoodstuffsPresenter>();
            View.DishesClicked += () =>
            {
                ApplicationController.Run<DishesPresenter>();
                FillForm();
            };
            View.DishesConfigClicked += () => ApplicationController.Run<DishesToFoodstuffsPresenter>();
            View.GenerateReportClicked += View_GenerateReportClicked;
        }

        private async void View_GenerateReportClicked()
        {
            var dishes = View.Dishes.Where(x => x.Count > 0);
            using (var sfd = new SaveFileDialog()
            {
                RestoreDirectory = true,
                FileName = "report.xlsx"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    await _reportGenerationService.Generate(dishes, sfd.FileName);
                }
            }
        }

        public override void Run()
        {
            View.ShowDialog();
        }
    }
}