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
    [Route("api/Comment")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private ICommentBL _commentBL;
        public CommentController(ICommentBL commentBL)
        {
            _commentBL = commentBL;
        }

        // GET: api/Comment
        [HttpGet]
        public IActionResult GetAllComments()
        {
            return Ok(_commentBL.GetAllComments());
        }

        // GET: api/Comment/5
        [HttpGet("{id}")]
        public IActionResult GetCommentById(int id)
        {
            return Ok(_commentBL.GetCommentById(id));
        }

        //Get
        [HttpGet("{postId}")]
        public IActionResult GetUserPostComments(int postId)
        {
            return Ok(_commentBL.GetUserPostComments(postId));
        }

        //Get
        [HttpGet("{postId}")]
        public IActionResult GetClubPostComments(int postId)
        {
            return Ok(_commentBL.GetClubPostComments(postId));
        }

        // POST: api/Comment
        [HttpPost]
        public IActionResult AddNewComment([FromBody] Comment newcomment)
        {
            return Created("api/Comment", _commentBL.AddComment(newcomment));
        }

        // PUT: api/Comment/5
        [HttpPut("{id}")]
        public IActionResult UpdateComment(int id, [FromBody] Comment updatedComment)
        {
            _commentBL.UpdateComment(updatedComment);
            return NoContent();
        }

        // DELETE: api/Comment/5
        [HttpDelete("{id}")]
        public IActionResult DeleteComment(int id)
        {
            _commentBL.DeleteComment(_commentBL.GetCommentById(id));
            return NoContent();
        }
    }
}
