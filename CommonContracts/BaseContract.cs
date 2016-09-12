using DalContracts;

namespace CommonContracts
{
    public abstract class BaseContract
    {
        public string ErrorMessage { get; set; }

        public string ErrorDetail { get; set; }

        public abstract IProcedureMapper GetMapper();
    }
}