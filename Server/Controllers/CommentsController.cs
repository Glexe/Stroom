using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stroom.Shared;
using Stroom.Shared.Models;
using Stroom.Server.Repositories;

namespace Stroom.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/Comments")]
    public class CommentsController : ControllerBase
    {

        private readonly ILogger<CommentsController> _logger;
        private readonly ICommentsRepository CommentsRepository;

        public CommentsController(ILogger<CommentsController> logger, ICommentsRepository commentsRepository)
        {
            _logger = logger;
            CommentsRepository = commentsRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CommentDto>> Get()
        {
            return Ok(CommentsRepository.Get());
        }

        [HttpPost]
        public ActionResult Add(CommentDto comment)
        {
            CommentsRepository.Add(comment);
            var res = CommentsRepository.SaveChanges();
            return Ok(res);
        }

        [HttpGet("{taskId}")]
        public ActionResult<IEnumerable<CommentDto>> Get(int taskId)
        {
            return Ok(CommentsRepository.Get(taskId));
        }
    }
}
