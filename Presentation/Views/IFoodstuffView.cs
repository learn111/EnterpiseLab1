using System;
using System.Collections.Generic;
using BLL.Models;
using Common;

namespace Presentation.Views
{
    public interface IFoodstuffView : IView
    {
        IEnumerable<FoodstuffModel> Foodstuffs { get; set; }
        IEnumerable<KeyValueStringInt> MeasurementUnits { set; }
        event Action SaveClicked;
    }
}