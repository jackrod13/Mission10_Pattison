using Microsoft.EntityFrameworkCore;

namespace Mission10_Pattison.Data
{
    public class BowlerDbContext : DbContext
    {
        // Constructor to inject database options
        public BowlerDbContext(DbContextOptions<BowlerDbContext> options) : base(options)
        {
        }

        // DbSet properties representing database tables
        public DbSet<Bowler> Bowlers { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define relationship: Each Bowler belongs to one Team, and a Team can have many Bowlers
            modelBuilder.Entity<Bowler>()
                .HasOne(b => b.Team)
                .WithMany(t => t.Bowlers)
                .HasForeignKey(b => b.TeamID);
        }
    }
}
