using System;
using System.Collections.Generic;

namespace DalContracts
{
    public interface IProcedureMapper
    {
        KeyValuePair<string, List<string>> GetMapByKey(Enum key);
    }
}