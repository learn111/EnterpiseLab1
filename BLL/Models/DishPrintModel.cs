using System.ComponentModel;
using Common.Attributes;

namespace BLL.Models
{
    internal class DishPrintModel : BindableModelBase
    {
        [Print]
        [DisplayName("Название")]
        public string Name { get; set; }

        [Print]
        [DisplayName("Количество")]
        public int Count { get; set; }

        [Print]
        [DisplayName("Цена ед.")]
        public decimal PriceSingle { get; set; }

        [Print]
        [DisplayName("Стоимость")]
        public decimal PriceTotal => Count*PriceSingle;
    }
}