using System.Configuration;

namespace DAL.Helpers
{
    internal class SqlConnectionHelper
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["CookBookConnectionString"].ConnectionString;
    }
}