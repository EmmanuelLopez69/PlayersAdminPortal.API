using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlayersAdminPortal.DomainModels;
using PlayersAdminPortal.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlayersAdminPortal.Controllers
{
    [ApiController]

    public class PlayersController : Controller
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IMapper _mapper;

        public PlayersController(IPlayerRepository playerRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _mapper = mapper;
        }
        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllPlayersAsync()
        {
            var players = await _playerRepository.GetPlayersAsync();
            //_mapper.Map<List<Player>>(players);

            return Ok(_mapper.Map<List<Player>>(players));

        }
    }
}
