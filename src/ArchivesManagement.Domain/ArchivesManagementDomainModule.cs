using Volo.Abp.Modularity;

namespace ArchivesManagement
{
    [DependsOn(
        typeof(ArchivesManagementDomainSharedModule)
        )]
    public class ArchivesManagementDomainModule : AbpModule
    {

    }
}
