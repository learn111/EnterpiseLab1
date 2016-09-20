using System.ComponentModel;

namespace BLL.Models
{
    public class DishToFoodstuffsModel : BindableModelBase
    {
        [Browsable(false)]
        public int? FoodstuffId { get; set; }

        [ReadOnly(true)]
        [DisplayName("Продукт")]
        public string FoodstuffName { get; set; }

        [DisplayName("Используется")]
        public bool IsActive { get; set; }

        [DisplayName("Потребление")]
        public decimal Consumption { get; set; }

        [ReadOnly(true)]
        [DisplayName("Единица измерения")]
        public string MeasurementUnit { get; set; }
    }
}