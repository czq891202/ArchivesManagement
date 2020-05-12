using Volo.Abp.Modularity;

namespace ArchivesManagement
{
    [DependsOn(
        typeof(ArchivesManagementApplicationModule),
        typeof(ArchivesManagementDomainTestModule)
        )]
    public class ArchivesManagementApplicationTestModule : AbpModule
    {

    }
}
