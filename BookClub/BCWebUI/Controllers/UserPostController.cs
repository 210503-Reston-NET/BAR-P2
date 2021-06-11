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
    public class UserPostController : ControllerBase
    {
        private readonly IUserPostBL _userPostBL;
        public UserPostController(IUserPostBL userPostBL)
        {
            _userPostBL = userPostBL;
        }

        // GET: api/UserPost
        [HttpGet]
        public IActionResult GetAllUserPosts()
        {
            return Ok(_userPostBL.GetAllUserPosts());
        }

        // GET: api/UserPost/5
        [HttpGet("{id}")]
        public IActionResult GetUserPostById(int id)
        {
            return Ok(_userPostBL.GetUserPostById(id));
        }

        [HttpGet("GetUserPostByUser/{userEmail}")]
        public IActionResult GetUserPostByUser(string userEmail)
        {
            return Ok(_userPostBL.GetUserPostByUser(userEmail));
        }

        // POST: api/UserPost
        [HttpPost]
        public IActionResult AddNewUserPost([FromBody] UserPost newUserPost)
        {
            return Created("api/UserPost", _userPostBL.AddUserPost(newUserPost));
        }

        // PUT: api/UserPost/5
        [HttpPut("{id}")]
        public IActionResult UpdateUserPost(int id, [FromBody] UserPost updatedUserPost)
        {
            _userPostBL.UpdateUserPost(updatedUserPost);
            return NoContent();
        }

        // DELETE: api/UserPost/5
        [HttpDelete("{id}")]
        public IActionResult DeleteUserPost(int id)
        {
            _userPostBL.DeleteUserPost(_userPostBL.GetUserPostById(id));
            return NoContent();
        }
    }
}
