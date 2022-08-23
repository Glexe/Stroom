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
    public class ProjectsController : ControllerBase
    {

        private readonly ILogger<ProjectsController> _logger;
        private readonly IProjectsRepository ProjectsRepository;

        public ProjectsController(ILogger<ProjectsController> logger, IProjectsRepository projectsRepository)
        {
            _logger = logger;
            ProjectsRepository = projectsRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProjectDto>> Get()
        {
            return Ok(ProjectsRepository.Get());
        }

        [HttpGet("{projectId}")]
        public ActionResult<ProjectDto> Get(int projectId)
        {
            return Ok(ProjectsRepository.Get(projectId));
        }
    }
}
