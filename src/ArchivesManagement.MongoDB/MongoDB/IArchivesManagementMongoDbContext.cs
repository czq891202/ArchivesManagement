using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace ArchivesManagement.MongoDB
{
    [ConnectionStringName(ArchivesManagementDbProperties.ConnectionStringName)]
    public interface IArchivesManagementMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
