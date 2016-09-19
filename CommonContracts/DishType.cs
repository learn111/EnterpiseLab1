using System.Runtime.Serialization;
using DalContracts;
using DalContracts.DishType;

namespace CommonContracts
{
    internal class DishType : BaseContract
    {
        [DataMember]
        public int? DishTypeId { get; set; }

        [DataMember]
        public string Name { get; set; }

        public override IProcedureMapper GetMapper() => new DishTypeProcedureMapper();
    }
}