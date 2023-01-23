using Microsoft.EntityFrameworkCore;

namespace PlayersAdminPortal.DataModels
{
    public class PlayerAdminContext : DbContext

    {
        public PlayerAdminContext(DbContextOptions<PlayerAdminContext> options): base(options)
        {

        }

        public DbSet<Player> Player { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
