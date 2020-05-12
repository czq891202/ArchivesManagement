using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using ArchivesManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ArchivesManagement.Pages
{
    public abstract class ArchivesManagementPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<ArchivesManagementResource> L { get; set; }
    }
}
