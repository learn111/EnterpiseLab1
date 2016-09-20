using System;
using System.Collections.Generic;
using BLL.Models;
using Common;

namespace Presentation.Views
{
    public interface IDishesToFoodstuffsView : IView
    {
        IEnumerable<KeyValueStringInt> Dishes { set; }
        IEnumerable<DishToFoodstuffsModel> DishesToFoodstuffs { get; set; }
        int DishId { get; }
        event Action<int> DishChanged;
        event Action SaveClicked;
    }
}