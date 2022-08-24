using Microsoft.EntityFrameworkCore;
using MyTeam.Model;

namespace MyTeam.Db
{
    public class TeamDb : DbContext
    {
        public TeamDb(DbContextOptions<TeamDb> options)
            : base(options)
        {
        }
        public DbSet<Team> Team { get; set; } = null!;
        public DbSet<Login> Login { get; set; } = null!;

    }

}
