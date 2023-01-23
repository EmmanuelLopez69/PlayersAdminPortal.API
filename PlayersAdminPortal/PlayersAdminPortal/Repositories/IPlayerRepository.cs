using PlayersAdminPortal.DataModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlayersAdminPortal.Repositories
{
    public interface IPlayerRepository
    {
        Task<List<Player>> GetPlayersAsync();

    }
}
