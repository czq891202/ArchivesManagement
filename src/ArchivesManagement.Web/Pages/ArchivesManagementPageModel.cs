using ArchivesManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ArchivesManagement.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class ArchivesManagementPageModel : AbpPageModel
    {
        protected ArchivesManagementPageModel()
        {
            LocalizationResourceType = typeof(ArchivesManagementResource);
            ObjectMapperContext = typeof(ArchivesManagementWebModule);
        }
    }
}