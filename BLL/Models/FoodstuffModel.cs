using System.ComponentModel;

namespace BLL.Models
{
    public class FoodstuffModel : BindableModelBase
    {
        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Цена")]
        public decimal Price { get; set; }
    }
}