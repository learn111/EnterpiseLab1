using System;

namespace Presentation.Views
{
    public interface IMainView : IView
    {
        event Action FoodstuffsClicked;
        event Action MeasurementUnitsClicked;
        event Action DishTypesClicked;
        event Action DishesClicked;
    }
}