using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace ArchivesManagement.MongoDB
{
    [DependsOn(
        typeof(ArchivesManagementTestBaseModule),
        typeof(ArchivesManagementMongoDbModule)
        )]
    public class ArchivesManagementMongoDbTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var connectionString = MongoDbFixture.ConnectionString.EnsureEndsWith('/') +
                                   "Db_" +
                                    Guid.NewGuid().ToString("N");

            Configure<AbpDbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = connectionString;
            });
        }
    }
}