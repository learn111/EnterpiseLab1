using System.Collections.Generic;

namespace DalContracts.Dish
{
    public class DishProcedureMapper : ProcedureMapperBase
    {
        public DishProcedureMapper()
        {
            FillMap();
        }

        private void FillMap()
        {
            Map.Add(DishProcedures.Add, new KeyValuePair<string, List<string>>("DishesInsert", new List<string> {"Name", "Description", "DishTypeId" }));
            Map.Add(DishProcedures.Delete, new KeyValuePair<string, List<string>>("DishesDelete", new List<string> {"DishId"}));
            Map.Add(DishProcedures.Update, new KeyValuePair<string, List<string>>("DishesUpdate", new List<string> {"DishId", "Name", "Description", "DishTypeId" }));
            Map.Add(DishProcedures.Get, new KeyValuePair<string, List<string>>("DishesSelect", new List<string> {"DishId" }));
        }
    }
}