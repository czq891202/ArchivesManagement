using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace ArchivesManagement
{
    [DependsOn(
        typeof(ArchivesManagementApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class ArchivesManagementHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "ArchivesManagement";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(ArchivesManagementApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
