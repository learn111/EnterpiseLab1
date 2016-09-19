using Presentation.Common;
using Presentation.Views;

namespace Presentation.Presenters
{
    public class MainPresenter : PresenterBase<IMainView>
    {
        public MainPresenter(IMainView view, IApplicationController applicationController)
            : base(view, applicationController)
        {
            Subscribe();
        }

        private void Subscribe()
        {
            View.MeasurementUnitsClicked += () => ApplicationController.Run<MeasurementUnitsPresenter>();
        }

        public override void Run()
        {
            View.ShowDialog();
        }
    }
}