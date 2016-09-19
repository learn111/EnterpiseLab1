namespace Presentation.Views
{
    public interface IView
    {
        void Show();
        void Close();
        void ShowDialog();
    }

    internal interface IView<TModel> : IView
    {
        TModel Model { get; set; }
    }
}