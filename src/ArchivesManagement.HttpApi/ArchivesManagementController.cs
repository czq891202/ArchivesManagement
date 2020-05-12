using ArchivesManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ArchivesManagement
{
    public abstract class ArchivesManagementController : AbpController
    {
        protected ArchivesManagementController()
        {
            LocalizationResource = typeof(ArchivesManagementResource);
        }
    }
}
