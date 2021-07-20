using TableFootball.Models;
using Microsoft.EntityFrameworkCore;

namespace TableFootball.Data
{
    public class TableFootballContext : DbContext
    {
        public TableFootballContext(DbContextOptions<TableFootballContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamEnrollment> TeamEnrollments { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
