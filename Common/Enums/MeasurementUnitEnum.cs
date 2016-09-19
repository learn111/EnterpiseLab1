using System.ComponentModel.DataAnnotations;

namespace Common.Enums
{
    public enum MeasurementUnitEnum
    {
        [Display(Name = "Килограмм")] Kg = 1,
        [Display(Name = "Грамм")] G,
        [Display(Name = "Ложка")] Spoon,
        [Display(Name = "Литр")] Litre,
        [Display(Name = "Стакан")] Glass
    }
}