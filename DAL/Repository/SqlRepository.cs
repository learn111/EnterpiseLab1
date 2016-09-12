using System.Data.SqlClient;
using DAL.Helpers;
using DAL.Miscellaneous;

namespace DAL.Repository
{
    internal class SqlRepository : IRepository
    {
        private readonly string _connectionString;

        public SqlRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public StoredProcedure InternalInvokeDS(InternalProcedure procedure)
        {
            StoredProcedure sp = null;

            try
            {
                var xml = SqlProcedureExecutor.ExecuteToXElement(procedure, _connectionString);
                sp = new StoredProcedure(xml, new SqlFaultData());
            }
            catch (SqlException ex)
            {
                sp = new StoredProcedure(null, new SqlFaultData(ex.HResult, ex.Errors[0].Message));
            }

            return sp;
        }
    }
}