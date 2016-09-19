using System.Runtime.Serialization;
using DalContracts;
using DalContracts.Foodstuff;

namespace CommonContracts
{
    public class Foodstuff : BaseContract
    {
        [DataMember]
        public int? FoodstuffId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int MeasurementUnitId { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        public override IProcedureMapper GetMapper() => new FoodstuffProcedureMapper();
    }
}