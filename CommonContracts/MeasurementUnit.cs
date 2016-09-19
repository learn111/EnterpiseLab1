using System.Runtime.Serialization;
using DalContracts;
using DalContracts.MeasurementUnits;

namespace CommonContracts
{
    internal class MeasurementUnit : BaseContract
    {
        [DataMember]
        public int? MeasurementUnitId { get; set; }

        [DataMember]
        public string Name { get; set; }

        public override IProcedureMapper GetMapper() => new MeasurementUnitsProcedureMapper();
    }
}