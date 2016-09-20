using System.ComponentModel;

namespace BLL.Models
{
    public class DishTypeModel : BindableModelBase
    {
        [Browsable(false)]
        public int? Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Удалить")]
        public bool Removed { get; set; }
    }
}