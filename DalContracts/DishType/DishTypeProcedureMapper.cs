using System.Collections.Generic;

namespace DalContracts.DishType
{
    public class DishTypeProcedureMapper : ProcedureMapperBase
    {
        public DishTypeProcedureMapper()
        {
            FillMap();
        }

        private void FillMap()
        {
            Map.Add(DishTypeProcedures.Add,
                new KeyValuePair<string, List<string>>("DishTypesInsert", new List<string> {"Name"}));
            Map.Add(DishTypeProcedures.Delete,
                new KeyValuePair<string, List<string>>("DishTypesDelete", new List<string> {"DishTypeId"}));
            Map.Add(DishTypeProcedures.Update,
                new KeyValuePair<string, List<string>>("DishTypesUpdate", new List<string> {"DishTypeId", "Name"}));
            Map.Add(DishTypeProcedures.Get,
                new KeyValuePair<string, List<string>>("DishTypesSelect", new List<string> {"DishTypeId"}));
        }
    }
}