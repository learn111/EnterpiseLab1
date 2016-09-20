using System.ComponentModel;
using Common.Attributes;

namespace BLL.Models
{
    internal class FoodstuffPrintModel
    {
        [Print]
        [DisplayName("Название")]
        public string Name { get; set; }

        [Print]
        [DisplayName("Единица измерения")]
        public string MeasurementUnit { get; set; }

        [Print]
        [DisplayName("Количество")]
        public decimal Quantity { get; set; }
    }
}