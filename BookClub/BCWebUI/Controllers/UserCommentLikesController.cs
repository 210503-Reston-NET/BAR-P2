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
        public async Task<IActionResult> GetAllCommentLikes()
        {
            return Ok(await _commentLikeBL.GetAllCommentLikesAsync());
        }

        // GET: api/CommentLikes/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> GetCommentLikesById(int id)
        {
            return Ok(await _commentLikeBL.GetCommentLikesByIdAsync(id));
        }

        //Get
        [HttpGet("GetCommentLikesByUserPost/{userPostId}")]
        public async Task<IActionResult> GetCommentLikesByUserPost(int userPostId)
        {
            return Ok(await _commentLikeBL.GetCommentLikesByUserPostAsync(userPostId));
        }

        // POST: api/CommentLikes
        [HttpPost]
        public async Task<IActionResult> AddNewCommentLike([FromBody] UserCommentLikes like)
        {
            return Created("api/CommentLikes", await _commentLikeBL.AddCommentLikesAsync(like));
        }
    }
}
