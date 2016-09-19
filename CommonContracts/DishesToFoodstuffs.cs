using System.Runtime.Serialization;
using DalContracts;
using DalContracts.DishesToFoodstuffs;

namespace CommonContracts
{
    public class DishesToFoodstuffs : BaseContract
    {
        [DataMember]
        public int? DishesToFoodstuffsId { get; set; }

        [DataMember]
        public int DishId { get; set; }

        [DataMember]
        public int FoodstuffId { get; set; }

        [DataMember]
        public decimal Consumption { get; set; }

        public override IProcedureMapper GetMapper() => new DishesToFoodstuffsProceduresProcedureMapper();
    }
}