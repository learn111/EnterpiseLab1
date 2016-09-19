using System;
using System.Runtime.Serialization;
using DalContracts;
using DalContracts.Dish;

namespace CommonContracts
{
    internal class Dish : BaseContract
    {
        [DataMember]
        public int? DishId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public int DishTypeId { get; set; }

        public override IProcedureMapper GetMapper() => new DishProcedureMapper();
    }
}