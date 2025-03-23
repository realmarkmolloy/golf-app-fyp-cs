using Microsoft.EntityFrameworkCore;
using GolfShotApp.Models;

namespace GolfShotApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<GolfRound> GolfRounds { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Stat> Stats { get; set; }
    }
}
