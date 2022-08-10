using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stroom.Shared;
using Stroom.Shared.Models;
using Stroom.Server.Repositories;

namespace Stroom.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class BugsController : ControllerBase
    {

        private readonly ILogger<BugsController> _logger;
        private readonly IBugsRepository BugsRepository;

        public BugsController(ILogger<BugsController> logger, IBugsRepository bugsRepository)
        {
            _logger = logger;
            BugsRepository = bugsRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Bug>> Get()
        {
            return Ok(BugsRepository.GetBugs());
        }
    }
}
