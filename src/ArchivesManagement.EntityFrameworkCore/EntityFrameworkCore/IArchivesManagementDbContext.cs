using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ArchivesManagement.EntityFrameworkCore
{
    [ConnectionStringName(ArchivesManagementDbProperties.ConnectionStringName)]
    public interface IArchivesManagementDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}