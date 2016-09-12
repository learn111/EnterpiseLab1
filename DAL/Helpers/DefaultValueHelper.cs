using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Helpers
{
    class DefaultValueHelper
    {
        public static object GetDefault(Type type)
            =>
                typeof (DefaultValueHelper).GetMethod(nameof(GetDefaultGeneric), BindingFlags.Static)
                    .MakeGenericMethod(type)
                    .Invoke(null, null);
       
        public static object GetDefaultGeneric<T>() => default(T);
    }
}
