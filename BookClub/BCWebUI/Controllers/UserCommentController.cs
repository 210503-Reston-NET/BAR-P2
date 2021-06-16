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
    public class UserCommentController : ControllerBase
    {
        private readonly IUserCommentBL _commentBL;
        public UserCommentController(IUserCommentBL commentBL)
        {
            _commentBL = commentBL;
        }

        // GET: api/Comment
        [HttpGet]
        public async Task<IActionResult> GetAllComments()
        {
            return Ok(await _commentBL.GetAllCommentsAsync());
        }

        // GET: api/Comment/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCommentById(int id)
        {
            return Ok(await _commentBL.GetCommentByIdAsync(id));
        }

        //Get
        [HttpGet("GetUserPostComments/{postId}")]
        public async Task<IActionResult> GetUserPostComments(int postId)
        {
            return Ok(await _commentBL.GetUserPostCommentsAsync(postId));
        }

        // POST: api/Comment
        [HttpPost]
        public async Task<IActionResult> AddNewComment([FromBody] UserComment newcomment)
        {
            return Created("api/Comment", await _commentBL.AddCommentAsync(newcomment));
        }

        // PUT: api/Comment/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateComment(int id, [FromBody] UserComment updatedComment)
        {
            await _commentBL.UpdateCommentAsync(updatedComment);
            return NoContent();
        }

        // DELETE: api/Comment/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            await _commentBL.DeleteCommentAsync(await _commentBL.GetCommentByIdAsync(id));
            return NoContent();
        }
    }
}
