using Microsoft.Extensions.Configuration;

namespace Tools
{
    public class ConfigTool
    {
        public static string GetProviderFromConfiguration()
        {
            IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();
            return config["ConnectionString"];
        }
    }
}