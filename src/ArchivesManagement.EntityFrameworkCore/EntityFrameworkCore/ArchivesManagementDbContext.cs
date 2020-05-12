using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ArchivesManagement.EntityFrameworkCore
{
    [ConnectionStringName(ArchivesManagementDbProperties.ConnectionStringName)]
    public class ArchivesManagementDbContext : AbpDbContext<ArchivesManagementDbContext>, IArchivesManagementDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public ArchivesManagementDbContext(DbContextOptions<ArchivesManagementDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureArchivesManagement();
        }
    }
}