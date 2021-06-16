using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BCBL;
using BCModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BCWebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentBL _commentBL;
        public CommentController(ICommentBL commentBL)
        {
            _commentBL = commentBL;
        }

        // GET: api/Comment
        [HttpGet]
        public IActionResult GetAllComments()
        {
            return Ok(_commentBL.GetAllCommentsAsync());
        }

        // GET: api/Comment/5
        [HttpGet("{id}")]
        public IActionResult GetCommentById(int id)
        {
            return Ok(_commentBL.GetCommentByIdAsync(id));
        }

        //Get
        [HttpGet("GetUserPostComments/{postId}")]
        public IActionResult GetUserPostComments(int postId)
        {
            return Ok(_commentBL.GetUserPostCommentsAsync(postId));
        }

        //Get
        [HttpGet("{clubPostId}")]
        public IActionResult GetClubPostComments(int clubPostId)
        {
            return Ok(_commentBL.GetClubPostCommentsAsync(clubPostId));
        }

        // POST: api/Comment
        [HttpPost]
        public IActionResult AddNewComment([FromBody] Comment newcomment)
        {
            return Created("api/Comment", _commentBL.AddCommentAsync(newcomment));
        }

        // PUT: api/Comment/5
        [HttpPut("{id}")]
        public IActionResult UpdateComment(int id, [FromBody] Comment updatedComment)
        {
            _commentBL.UpdateCommentAsync(updatedComment);
            return NoContent();
        }

        // DELETE: api/Comment/5
        [HttpDelete("{id}")]
        public IActionResult DeleteComment(int id)
        {
            _commentBL.DeleteComment(_commentBL.GetCommentByIdAsync(id));
            return NoContent();
        }
    }
}
