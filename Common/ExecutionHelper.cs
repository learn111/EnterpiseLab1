using System;

namespace Common
{
    public class ExecutionHelper
    {
        public static void ExecuteWithTry(Action target, Action<string> onError = null)
        {
            try
            {
                target.Invoke();
            }
            catch (Exception ex)
            {
                onError?.Invoke(ex.Message);
            }
        }
    }
}