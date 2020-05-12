using ArchivesManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ArchivesManagement.Pages
{
    public abstract class ArchivesManagementPageModel : AbpPageModel
    {
        protected ArchivesManagementPageModel()
        {
            LocalizationResourceType = typeof(ArchivesManagementResource);
        }
    }
}