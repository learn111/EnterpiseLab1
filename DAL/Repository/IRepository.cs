using DAL.Miscellaneous;

namespace DAL.Repository
{
    internal interface IRepository
    {
        StoredProcedure InternalInvokeDS(InternalProcedure procedure);
    }
}