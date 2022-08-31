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
        
        [HttpGet("{projectId}/add-user/{token}")]
        public ActionResult<ProjectDto> AddUserToProject(int projectId, string token)
        {
            byte[] data = Convert.FromBase64String(token);
            DateTime when = DateTime.FromBinary(BitConverter.ToInt64(data, 0));
            if (when < DateTime.UtcNow.AddHours(-24))
            {
                // too old
            }
            return Ok(ProjectsRepository.Get(projectId));
        }
        
        [HttpGet("/generate-invitation-token/{projectId}")]
        public ActionResult<string> GenerateInvitationToken(int projectId)
        {
            //select invite_link from project where pro_id = id
            
            //update project set invite_link = token where pro_id = projectId
            //savechanges()
            return Ok(ProjectsRepository.GenerateInvitationToken(projectId));
        }  
    }
}
