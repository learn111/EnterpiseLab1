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
    public class MeasurementUnitsPresenter : PresenterBase<IMeasurementUnitsView>
    {
        private readonly IMeasurementUnitsService _measurementUnitsService;

        public MeasurementUnitsPresenter(IMeasurementUnitsView view, IApplicationController applicationController,
            IMeasurementUnitsService measurementUnitsService) : base(view, applicationController)
        {
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
                View.MeasurementUnitModels.Where(x => !x.Removed && x.Id.HasValue).Select(x => new MeasurementUnit
                {
                    MeasurementUnitId = x.Id,
                    Name = x.Name
                });
            foreach (var measurementUnit in toUpdate)
            {
                _measurementUnitsService.Update(measurementUnit);
            }
            var toDelete =
                View.MeasurementUnitModels.Where(x => x.Removed && x.Id.HasValue).Select(x => new MeasurementUnit
                {
                    MeasurementUnitId = x.Id
                });
            foreach (var measurementUnit in toDelete)
            {
                _measurementUnitsService.Delete(measurementUnit);
            }
            var toAdd =
                View.MeasurementUnitModels.Where(x => !x.Removed && !x.Id.HasValue).Select(x => new MeasurementUnit
                {
                    Name = x.Name
                });
            foreach (var measurementUnit in toAdd)
            {
                _measurementUnitsService.Add(measurementUnit);
            }
            FillForm();
        }

        private void FillForm()
        {
            View.MeasurementUnitModels = _measurementUnitsService.GetAll().Select(x => new MeasurementUnitModel
            {
                Name = x.Name,
                Id = x.MeasurementUnitId
            });
        }

        public override void Run()
        {
            View.ShowDialog();
        }
    }
}