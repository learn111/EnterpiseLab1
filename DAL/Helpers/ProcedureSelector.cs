using System;
using System.Collections.Generic;
using CommonContracts;
using DAL.Miscellaneous;

namespace DAL.Helpers
{
    internal class ProcedureSelector
    {
        public static InternalProcedure GetProcedure(Enum opType, BaseContract type)
        {
            var mapper = type.GetMapper().GetMapByKey(opType);
            return CreateProcedure(mapper.Key, mapper.Value, type);
        }

        private static InternalProcedure CreateProcedure(string key, List<string> values, BaseContract type)
        {
            var param = new List<KeyValuePair<string, object>>();
            foreach (var value in values)
            {
                var propertyInfo = type.GetType().GetProperty(value);
                var val = propertyInfo.GetValue(type);
                if (propertyInfo.PropertyType.IsValueType)
                    val = (ValueType) val;
                param.Add(new KeyValuePair<string, object>(value, val));
            }
            return new InternalProcedure(key, param);
        }
    }
}