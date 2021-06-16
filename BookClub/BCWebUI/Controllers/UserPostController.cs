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
        public async Task<IActionResult> GetAllUserPosts()
        {
            return Ok(await _userPostBL.GetAllUserPostsAsync());
        }

        // GET: api/UserPost/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserPostById(int id)
        {
            return Ok(await _userPostBL.GetUserPostByIdAsync(id));
        }

        //Get
        [HttpGet("GetUserPostByUser/{userEmail}")]
        public async Task<IActionResult> GetUserPostByUser(string userEmail)
        {
            return Ok(await _userPostBL.GetUserPostByUserAsync(userEmail));
        }

        // POST: api/UserPost
        [HttpPost]
        public async Task<IActionResult> AddNewUserPost([FromBody] UserPost newUserPost)
        {
            return Created("api/UserPost", await _userPostBL.AddUserPostAsync(newUserPost));
        }

        // PUT: api/UserPost/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUserPost(int id, [FromBody] UserPost updatedUserPost)
        {
            await _userPostBL.UpdateUserPostAsync(updatedUserPost);
            return NoContent();
        }

        // DELETE: api/UserPost/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserPost(int id)
        {
            await _userPostBL.DeleteUserPostAsync(await _userPostBL.GetUserPostByIdAsync(id));
            return NoContent();
        }
    }
}
