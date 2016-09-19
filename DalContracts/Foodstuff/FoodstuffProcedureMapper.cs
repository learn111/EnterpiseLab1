using System.Collections.Generic;

namespace DalContracts.Foodstuff
{
    public class FoodstuffProcedureMapper : ProcedureMapperBase
    {
        public FoodstuffProcedureMapper()
        {
            FillMap();
        }

        private void FillMap()
        {
            Map.Add(FoodstuffProcedures.Add,
                new KeyValuePair<string, List<string>>("FoodstuffsInsert",
                    new List<string> {"Name", "Price", "MeasurementUnitId"}));
            Map.Add(FoodstuffProcedures.Delete,
                new KeyValuePair<string, List<string>>("FoodstuffsDelete", new List<string> {"FoodstuffId"}));
            Map.Add(FoodstuffProcedures.Get,
                new KeyValuePair<string, List<string>>("FoodstuffsSelect", new List<string> {"FoodstuffId"}));
            Map.Add(FoodstuffProcedures.Update,
                new KeyValuePair<string, List<string>>("FoodstuffsUpdate",
                    new List<string> {"FoodstuffId", "Name", "Price", "MeasurementUnitId"}));
        }
    }
}