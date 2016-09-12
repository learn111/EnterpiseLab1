using DalContracts;

namespace CommonContracts
{
    public abstract class BaseCommonContract
    {
        public abstract string ErrorMessage { get; set; }

        public abstract string ErrorDetail { get; set; }

        public abstract IProcedureMapper GetMapper();
    }
}