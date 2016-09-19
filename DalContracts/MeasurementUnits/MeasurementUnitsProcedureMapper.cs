using System.Collections.Generic;

namespace DalContracts.MeasurementUnits
{
    public class MeasurementUnitsProcedureMapper : ProcedureMapperBase
    {
        public MeasurementUnitsProcedureMapper()
        {
            FillMap();
        }

        private void FillMap()
        {
            Map.Add(MeasurementUnitsProcedures.Add,
                new KeyValuePair<string, List<string>>("MeasurementUnitsInsert",
                    new List<string> {"Name"}));
            Map.Add(MeasurementUnitsProcedures.Delete,
                new KeyValuePair<string, List<string>>("MeasurementUnitsDelete",
                    new List<string> {"MeasurementUnitId"}));
            Map.Add(MeasurementUnitsProcedures.Update,
                new KeyValuePair<string, List<string>>("MeasurementUnitsUpdate",
                    new List<string> {"MeasurementUnitId", "Name"}));
            Map.Add(MeasurementUnitsProcedures.Get,
                new KeyValuePair<string, List<string>>("MeasurementUnitsSelect",
                    new List<string> {"MeasurementUnitId"}));
        }
    }
}