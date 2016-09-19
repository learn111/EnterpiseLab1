using System;
using System.Collections.Generic;

namespace DalContracts
{
    public abstract class ProcedureMapperBase : IProcedureMapper
    {
        protected readonly Dictionary<Enum, KeyValuePair<string, List<string>>> Map;

        protected ProcedureMapperBase()
        {
            Map = new Dictionary<Enum, KeyValuePair<string, List<string>>>();
        }

        public KeyValuePair<string, List<string>> GetMapByKey(Enum key)
        {
            return Map[key];
        }

    }
}