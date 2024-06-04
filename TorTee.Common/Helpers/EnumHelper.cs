namespace TorTee.Core.Helpers
{
    public class EnumHelper
    {
        public static int CompareStatus<T>(string feStatusStr) where T : struct, Enum
        {
            if (Enum.TryParse<T>(feStatusStr, true, out T status))
            {
                return Convert.ToInt32(status);
            }
            return -1; 
        }
    }
}
