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
    public class TasksController : ControllerBase
    {

        private readonly ILogger<TasksController> _logger;
        private readonly ITasksRepository TasksRepository;

        public TasksController(ILogger<TasksController> logger, ITasksRepository tasksRepository)
        {
            _logger = logger;
            TasksRepository = tasksRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TaskDto>> Get()
        {
            return Ok(TasksRepository.Get());
        }

        [HttpPost]
        public ActionResult Add([FromBody] TaskDto task)
        {
            TasksRepository.Add(task);
            var test = TasksRepository.SaveChanges();
            return Ok(test);
        } 

        [HttpGet("{taskId}")]
        public ActionResult<TaskDto> Get(int taskId)
        {
            return Ok(TasksRepository.Get(taskId));
        }
    }
}
