using Presentation.Common;
using Presentation.Views;

namespace Presentation.Presenters
{
    public abstract class PresenterBase<TView> : IPresenter where TView : IView
    {
        protected PresenterBase(TView view, IApplicationController applicationController)
        {
            View = view;
            ApplicationController = applicationController;
        }

        protected TView View { get; }
        protected IApplicationController ApplicationController { get; }

        public abstract void Run();
    }

    internal abstract class PresenterBase<TView, TArg> : IPresenter<TArg> where TView : IView
    {
        protected PresenterBase(TView view, IApplicationController applicationController)
        {
            View = view;
            ApplicationController = applicationController;
        }

        protected TView View { get; }
        protected IApplicationController ApplicationController { get; }

        public abstract void Run(TArg arg);
    }
}