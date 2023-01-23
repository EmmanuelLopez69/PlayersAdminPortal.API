using Microsoft.EntityFrameworkCore;
using PlayersAdminPortal.DataModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayersAdminPortal.Repositories
{
    public class SqlPlayerRepository : IPlayerRepository
    {
        private readonly PlayerAdminContext _context;

        public SqlPlayerRepository(PlayerAdminContext context)
        {
            _context = context;
        }
        public async Task<List<Player>> GetPlayersAsync()
        {
            return await _context.Player.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }
    }
}
