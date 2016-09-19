using System;
using System.Collections.Generic;
using CommonContracts;
using DAL.Helpers;
using DAL.Miscellaneous;
using DAL.Repository;

namespace DAL
{
    public class DalService : IDalService
    {
        private readonly IRepository _repository = new SqlRepository(SqlConnectionHelper.ConnectionString);

        public IEnumerable<T> FormatOp<T>(Enum op, T type) where T : BaseContract, new()
        {
            var proc = ProcedureSelector.GetProcedure(op, type);
            return GetDataSet(proc).GetDataFromXElement<T>();
        }

        private StoredProcedure GetDataSet(InternalProcedure procedure)
        {
            return _repository.InternalInvokeDS(procedure);
        }
    }
}