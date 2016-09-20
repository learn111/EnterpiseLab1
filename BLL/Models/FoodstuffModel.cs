using System.ComponentModel;

namespace BLL.Models
{
    public class FoodstuffModel : BindableModelBase
    {
        [Browsable(false)]
        public int? Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Цена")]
        public decimal Price { get; set; }

        [DisplayName("Единица измерения")]
        public int MeasurementUnitId { get; set; }

        [DisplayName("Удалить")]
        public bool Removed { get; set; }
    }
}