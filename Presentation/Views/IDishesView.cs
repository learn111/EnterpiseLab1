using System;
using System.Collections.Generic;
using BLL.Models;
using Common;

namespace Presentation.Views
{
    public interface IDishesView : IView
    {
        IEnumerable<KeyValueStringInt> DishTypes { set; }
        IEnumerable<DishModel> Dishes { get; set; }
        event Action SaveClicked;
    }
}