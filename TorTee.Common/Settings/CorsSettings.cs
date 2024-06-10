namespace TorTee.Core.Settings
{
    public class CorsSettings
    {
        public string PolicyName { get; set; } = "AllowCors";
        public string[] WithOrigins { get; set; } = Array.Empty<string>();
        public string[] WithHeaders { get; set; } = Array.Empty<string>();
        public string[] WithMethods { get; set; } = Array.Empty<string>();
        public bool AllowCredentials { get; set; }
    }
}
