namespace TorTee.Core.Helpers
{
    public static class PropertyReflectionHelper
    {
        public static string GetStringValueByName(Type type, string propertyName, object obj)
        {
            var property = type.GetProperties().FirstOrDefault(p => string.Equals(p.Name, propertyName, StringComparison.OrdinalIgnoreCase));
            var propertyValue = property?.GetValue(obj);
            return propertyValue?.ToString() ?? string.Empty;
        }
    }
}
