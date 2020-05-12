using ArchivesManagement.Localization;
using Volo.Abp.Application.Services;

namespace ArchivesManagement
{
    public abstract class ArchivesManagementAppService : ApplicationService
    {
        protected ArchivesManagementAppService()
        {
            LocalizationResource = typeof(ArchivesManagementResource);
            ObjectMapperContext = typeof(ArchivesManagementApplicationModule);
        }
    }
}
