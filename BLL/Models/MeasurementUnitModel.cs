using System.ComponentModel;

namespace BLL.Models
{
    public class MeasurementUnitModel : BindableModelBase
    {
        [DisplayName("Название")]
        public string Name { get; set; }


        [DisplayName("Удалить")]
        public bool Removed { get; set; }

        [Browsable(false)]
        public int? Id { get; set; }
    }
}