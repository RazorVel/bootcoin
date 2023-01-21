using bootcoin.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace bootcoin.Data
{
    public class BootcoinDbContext : DbContext
    {
        public BootcoinDbContext(DbContextOptions options) : base(options)
        {
        }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                  .HasKey(m => new { m.UserId });

            modelBuilder.Entity<Profile>()
                .HasKey(m => new { m.ProfileId, m.UserId });

            modelBuilder.Entity<TransactionHeader>()
                .HasKey(m => new { m.TransactionId });
            modelBuilder.Entity<TransactionHeader>()
                .HasOne(x => x.Source)
                .WithMany(x => x.sourceTransaction)
                .HasForeignKey(x => x.SourceId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<TransactionHeader>()
                .HasOne(x => x.Target)
                .WithMany(x => x.targetTransaction)
                .HasForeignKey(x => x.TargetId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<TransactionDetail>()
                .HasKey(m => new { m.TransactionId });
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<TransactionHeader> TransactionHeaders { get; set; }
        public DbSet<TransactionDetail> TransactionDetails { get; set; }
    }
}
