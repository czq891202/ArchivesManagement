using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace ArchivesManagement.MongoDB
{
    [ConnectionStringName(ArchivesManagementDbProperties.ConnectionStringName)]
    public class ArchivesManagementMongoDbContext : AbpMongoDbContext, IArchivesManagementMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureArchivesManagement();
        }
    }
}