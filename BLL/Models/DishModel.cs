using System.ComponentModel;

namespace BLL.Models
{
    public class DishModel : BindableModelBase
    {
        [Browsable(false)]
        public int? Id { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Рецепт")]
        public string Description { get; set; }

        [DisplayName("Тип блюда")]
        public int DishTypeId { get; set; }

        [DisplayName("Удалить")]
        public bool Removed { get; set; }
    }
}