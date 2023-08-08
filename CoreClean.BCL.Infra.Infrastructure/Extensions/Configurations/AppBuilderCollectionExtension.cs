using CoreClean.BCL.Application.Configurations;

using Microsoft.Extensions.Configuration;
namespace CoreClean.BCL.Infra.Infrastructure.Extensions.Configurations
{
    public static class AppBuilderCollectionExtension
    {
        public static IConfigurationBuilder AddMultipleJsonFiles(this IConfigurationBuilder configurationBuilder, AppConfiguration appConfiguration, string prefix = "")
        {
            string[] files = Directory.GetFiles(appConfiguration.ConfigFilesRepository, prefix + "*.json");

            foreach (var item in files)
            {
                configurationBuilder.AddJsonFile(item);
            }
            return configurationBuilder;
        }
    }
}
