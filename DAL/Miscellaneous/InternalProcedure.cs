using System.Collections.Generic;
using System.Linq;

namespace DAL.Miscellaneous
{
    internal class InternalProcedure
    {
        public InternalProcedure(string name, IEnumerable<KeyValuePair<string, object>> @params)
        {
            Name = name;
            Params = @params.ToList();
        }

        internal string Name { get; private set; }
        internal IEnumerable<KeyValuePair<string, object>> Params { get; private set; }
    }
}