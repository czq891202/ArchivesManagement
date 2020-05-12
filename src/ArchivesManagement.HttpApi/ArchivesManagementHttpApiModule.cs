using Localization.Resources.AbpUi;
using ArchivesManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace ArchivesManagement
{
    [DependsOn(
        typeof(ArchivesManagementApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class ArchivesManagementHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(ArchivesManagementHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<ArchivesManagementResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
