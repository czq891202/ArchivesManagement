using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace ArchivesManagement.MongoDB
{
    public class ArchivesManagementMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public ArchivesManagementMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}