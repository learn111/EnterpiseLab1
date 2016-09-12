using System;
using System.Collections.Generic;
using CommonContracts;

namespace DAL
{
    internal interface IDalService
    {
        IEnumerable<T> FormatOp<T>(Enum op, T type) where T : BaseContract, new();
    }
}