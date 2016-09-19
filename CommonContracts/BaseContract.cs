using System.Runtime.Serialization;
using DalContracts;

namespace CommonContracts
{
    public abstract class BaseContract
    {
        [DataMember]
        public string ErrorMessage { get; set; }

        [DataMember]
        public string ErrorDetail { get; set; }

        public abstract IProcedureMapper GetMapper();
    }
}