using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stroom.Shared;
using Stroom.Shared.Models;
using Stroom.Server.Repositories;

namespace Stroom.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/Users")]
    public class UsersControler : ControllerBase
    {

        private readonly ILogger<UsersControler> _logger;
        private readonly IUsersRepository UsersRepository;

        public UsersControler(ILogger<UsersControler> logger, IUsersRepository usersRepository)
        {
            _logger = logger;
            UsersRepository = usersRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return Ok(UsersRepository.Get());
        }

        [HttpGet("{userId}")]
        public ActionResult<User> Get(int userId)
        {
            return Ok(UsersRepository.Get(userId));
        }
    }
}
