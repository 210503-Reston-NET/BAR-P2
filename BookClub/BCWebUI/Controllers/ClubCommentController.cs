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
        public IActionResult GetAllComments()
        {
            return Ok(_clubCommentBL.GetAllComments());
        }

        // GET api/<ClubCommentController>/5
        [HttpGet("{id}")]
        public IActionResult GetCommentById(int id)
        {
            return Ok(_clubCommentBL.GetCommentById(id));
        }

        [HttpGet("GetUserPostComments/{postId}")]
        public IActionResult GetUserPostComments(int postId)
        {
            return Ok(_clubCommentBL.GetCommentByClubId(postId));
        }

        // POST api/<ClubCommentController>
        [HttpPost]
        public IActionResult AddNewComment([FromBody] ClubComment newcomment)
        {
            return Created("api/Comment", _clubCommentBL.AddComment(newcomment));
        }

        // PUT api/<ClubCommentController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateComment(int id, [FromBody] ClubComment updatedComment)
        {
            _clubCommentBL.UpdateComment(updatedComment);
            return NoContent();
        }

        // DELETE api/<ClubCommentController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteComment(int id)
        {
            _clubCommentBL.DeleteComment(id);
            return NoContent();
        }
    }
}
