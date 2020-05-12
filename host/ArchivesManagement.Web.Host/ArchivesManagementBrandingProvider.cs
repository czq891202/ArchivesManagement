using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace ArchivesManagement
{
    [Dependency(ReplaceServices = true)]
    public class ArchivesManagementBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ArchivesManagement";
    }
}
