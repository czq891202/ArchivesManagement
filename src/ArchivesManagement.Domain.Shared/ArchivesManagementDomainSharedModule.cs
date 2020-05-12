using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using ArchivesManagement.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace ArchivesManagement
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class ArchivesManagementDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<ArchivesManagementDomainSharedModule>("ArchivesManagement");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<ArchivesManagementResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/ArchivesManagement");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("ArchivesManagement", typeof(ArchivesManagementResource));
            });
        }
    }
}
