using Microsoft.EntityFrameworkCore;

namespace Mission10_Pattison.Data
{
    public class BowlerDbContext : DbContext
    {
        public BowlerDbContext(DbContextOptions<BowlerDbContext> options) : base(options)
        {
        }

        public DbSet<Bowler> Bowlers { get; set; }
        public DbSet<Team> Teams { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Bowler>()
                .HasOne(b => b.Team)
                .WithMany(t => t.Bowlers)
                .HasForeignKey(b => b.TeamID);
        }
    }
}
