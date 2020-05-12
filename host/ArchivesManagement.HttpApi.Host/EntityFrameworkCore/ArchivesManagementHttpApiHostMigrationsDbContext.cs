using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace ArchivesManagement.EntityFrameworkCore
{
    public class ArchivesManagementHttpApiHostMigrationsDbContext : AbpDbContext<ArchivesManagementHttpApiHostMigrationsDbContext>
    {
        public ArchivesManagementHttpApiHostMigrationsDbContext(DbContextOptions<ArchivesManagementHttpApiHostMigrationsDbContext> options)
            : base(options)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureArchivesManagement();
        }
    }
}
