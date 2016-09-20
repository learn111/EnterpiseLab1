using System;
using System.Collections.Generic;
using BLL.Models;

namespace Presentation.Views
{
    public interface IDishTypesView : IView
    {
        IEnumerable<DishTypeModel> DishTypes { get; set; }
        event Action SaveClicked;
    }
}