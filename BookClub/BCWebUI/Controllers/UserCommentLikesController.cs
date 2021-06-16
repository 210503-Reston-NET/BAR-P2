using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BCBL;
using BCModel;

namespace BCWebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCommentLikesController : ControllerBase
    {
        private readonly IUserCommentLikeBL _commentLikeBL;
        public UserCommentLikesController(IUserCommentLikeBL commentLikeBL)
        {
            _commentLikeBL = commentLikeBL;
        }

        // GET: api/CommentLikes
        [HttpGet]
        public IActionResult GetAllCommentLikes()
        {
            return Ok(_commentLikeBL.GetAllCommentLikes());
        }

        // GET: api/CommentLikes/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult GetCommentLikesById(int id)
        {
            return Ok(_commentLikeBL.GetCommentLikesById(id));
        }

        //Get
        [HttpGet("GetCommentLikesByUserPost/{userPostId}")]
        public IActionResult GetCommentLikesByUserPost(int userPostId)
        {
            return Ok(_commentLikeBL.GetCommentLikesByUserPost(userPostId));
        }

        // POST: api/CommentLikes
        [HttpPost]
        public IActionResult AddNewCommentLike([FromBody] UserCommentLikes like)
        {
            return Created("api/CommentLikes", _commentLikeBL.AddCommentLikes(like));
        }
    }
}
