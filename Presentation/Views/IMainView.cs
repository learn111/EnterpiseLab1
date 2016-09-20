using System;
using System.Collections.Generic;
using BLL.Models;

namespace Presentation.Views
{
    public interface IMainView : IView
    {
        event Action FoodstuffsClicked;
        event Action MeasurementUnitsClicked;
        event Action DishTypesClicked;
        event Action DishesClicked;
        event Action DishesConfigClicked;
        event Action GenerateReportClicked;
        IEnumerable<DishCookModel> Dishes { get; set; }
    }
}