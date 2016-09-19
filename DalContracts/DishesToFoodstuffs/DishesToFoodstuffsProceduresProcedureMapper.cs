using System.Collections.Generic;

namespace DalContracts.DishesToFoodstuffs
{
    public class DishesToFoodstuffsProceduresProcedureMapper : ProcedureMapperBase
    {
        public DishesToFoodstuffsProceduresProcedureMapper()
        {
            FIllMap();
        }

        private void FIllMap()
        {
            Map.Add(DishesToFoodstuffsProcedures.Add, new KeyValuePair<string, List<string>>("DishesToFoodstuffsInsert", new List<string> { "DishId", "FoodstuffId", "Consumption" }));
            Map.Add(DishesToFoodstuffsProcedures.Delete, new KeyValuePair<string, List<string>>("DishesToFoodstuffsDelete", new List<string> { "DishesToFoodstuffsId" }));
            Map.Add(DishesToFoodstuffsProcedures.Update, new KeyValuePair<string, List<string>>("DishesToFoodstuffsUpdate", new List<string> { "DishesToFoodstuffsId", "DishId", "FoodstuffId", "Consumption" }));
            Map.Add(DishesToFoodstuffsProcedures.Get, new KeyValuePair<string, List<string>>("DishesToFoodstuffsSelect", new List<string> { "DishesToFoodstuffsId"}));

        }
    }
}