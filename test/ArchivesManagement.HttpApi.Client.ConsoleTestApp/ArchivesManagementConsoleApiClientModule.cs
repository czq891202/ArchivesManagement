using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace ArchivesManagement
{
    [DependsOn(
        typeof(ArchivesManagementHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ArchivesManagementConsoleApiClientModule : AbpModule
    {
        
    }
}
