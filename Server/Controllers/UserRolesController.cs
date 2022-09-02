using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stroom.Shared;
using Stroom.Shared.Models;
using Stroom.Server.Repositories;

namespace Stroom.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/UserRoles")]
    public class UserRolesController : ControllerBase
    {

        private readonly ILogger<UserRolesController> _logger;
        private readonly IUserRolesRepository UserRolesRepository;

        public UserRolesController(ILogger<UserRolesController> logger, IUserRolesRepository userRolesRepository)
        {
            _logger = logger;
            UserRolesRepository = userRolesRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserRoleDto>> Get()
        {
            return Ok(UserRolesRepository.Get());
        }

        [HttpPost("modify")]
        public ActionResult Modify(UserRoleDto userRoleDto)
        {
            UserRolesRepository.Modify(userRoleDto);
            var res = UserRolesRepository.SaveChanges();
            return Ok(res);
        } 
        
        [HttpPost]
        public ActionResult Add(UserRoleDto userRoleDto)
        {
            UserRolesRepository.Add(userRoleDto);
            var res = UserRolesRepository.SaveChanges();
            return Ok(res);
        }
    }
}
