using System.ComponentModel;

namespace BLL.Models
{
    public class DishCookModel : BindableModelBase
    {
        [Browsable(false)]
        public int DishId { get; set; }

        [ReadOnly(true)]
        [DisplayName("Блюдо")]
        public string DishName { get; set; }

        [ReadOnly(true)]
        [DisplayName("Тип блюда")]
        public string DishType { get; set; }

        [DisplayName("Количество порций")]
        public int Count { get; set; }
    }
}