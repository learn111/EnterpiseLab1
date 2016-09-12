using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using DAL.Miscellaneous;

namespace DAL.Helpers
{
    internal static class SqlProcedureExecutor
    {
        public static XElement ExecuteToXElement(InternalProcedure procedure, string connectionString)
        {
            var dataSet = new DataSet(procedure.Name);
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var sqlCommand = new SqlCommand(procedure.Name, conn) {CommandType = CommandType.StoredProcedure};
                foreach (var param in procedure.Params)
                {
                    sqlCommand.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                }

                using (var adapter = new SqlDataAdapter(sqlCommand))
                {
                    adapter.Fill(dataSet, procedure.Name);
                }
                conn.Close();
            }
            return XDocument.Parse(dataSet.GetXml()).Root;
        }
    }
}