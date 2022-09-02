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
    public class TimeEntriesController : ControllerBase
    {

        private readonly ILogger<TimeEntriesController> _logger;
        private readonly ITimeEntriesRepository TimeEntryRepository;

        public TimeEntriesController(ILogger<TimeEntriesController> logger, ITimeEntriesRepository timeEntryRepository)
        {
            _logger = logger;
            TimeEntryRepository = timeEntryRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TimeEntry>> Get()
        {
            return Ok(TimeEntryRepository.Get());
        }   
        
        [HttpPost]
        public ActionResult Add(TimeEntry timeEntry)
        {
            TimeEntryRepository.Add(timeEntry);
            var res = TimeEntryRepository.SaveChanges();
            return Ok(res);
        }
    }
}
