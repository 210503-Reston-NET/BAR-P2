using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BCBL;
using BCModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BCWebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubCommentController : ControllerBase
    {
        private IClubCommentBL _clubCommentBL;
        public ClubCommentController(IClubCommentBL ClubCommentBL)
        {
            _clubCommentBL = ClubCommentBL;
        }

        // GET: api/<ClubCommentController>
        [HttpGet]
        public async Task<IActionResult> GetAllComments()
        {
            return Ok(await _clubCommentBL.GetAllCommentsAsync());
        }

        // GET api/<ClubCommentController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCommentById(int id)
        {
            return Ok(await _clubCommentBL.GetCommentByIdAsync(id));
        }

        [HttpGet("GetClubPostComments/{postId}")]
        public async Task<IActionResult> GetClubPostComments(int postId)
        {
            return Ok(await _clubCommentBL.GetCommentByClubIdAsync(postId));
        }

        // POST api/<ClubCommentController>
        [HttpPost]
        public async Task<IActionResult> AddNewComment([FromBody] ClubComment newcomment)
        {
            return Created("api/Comment", await _clubCommentBL.AddCommentAsync(newcomment));
        }

        // PUT api/<ClubCommentController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateComment(int id, [FromBody] ClubComment updatedComment)
        {
            await _clubCommentBL.UpdateCommentAsync(updatedComment);
            return NoContent();
        }

        // DELETE api/<ClubCommentController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            await _clubCommentBL.DeleteCommentAsync(id);
            return NoContent();
        }
    }
}
