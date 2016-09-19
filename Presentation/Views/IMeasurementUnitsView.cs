using System;
using System.Collections.Generic;
using BLL.Models;

namespace Presentation.Views
{
    public interface IMeasurementUnitsView : IView
    {
        event Action SaveClicked;
        IEnumerable<MeasurementUnitModel> MeasurementUnitModels { get; set; }
    
    }
}