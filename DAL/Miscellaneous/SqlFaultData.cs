namespace DAL.Miscellaneous
{
    internal class SqlFaultData
    {
        public SqlFaultData()
        {
        }

        public SqlFaultData(int hResult, string message)
        {
            HResult = hResult;
            Message = message;
        }

        public int HResult { get; private set; }
        public string Message { get; private set; }
    }
}