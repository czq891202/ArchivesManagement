using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace ArchivesManagement.MongoDB
{
    public static class ArchivesManagementMongoDbContextExtensions
    {
        public static void ConfigureArchivesManagement(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new ArchivesManagementMongoModelBuilderConfigurationOptions(
                ArchivesManagementDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}