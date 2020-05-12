using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ArchivesManagement.EntityFrameworkCore
{
    public class ArchivesManagementModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public ArchivesManagementModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}