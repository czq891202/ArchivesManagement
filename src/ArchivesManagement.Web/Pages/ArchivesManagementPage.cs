using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using ArchivesManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ArchivesManagement.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits ArchivesManagement.Web.Pages.ArchivesManagementPage
     */
    public abstract class ArchivesManagementPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<ArchivesManagementResource> L { get; set; }
    }
}
