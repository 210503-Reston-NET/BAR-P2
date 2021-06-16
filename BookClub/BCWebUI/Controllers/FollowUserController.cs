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
    public class FollowUserController : ControllerBase
    {
        private readonly IFollowUserBL _FollowUserBL;

        public FollowUserController(IFollowUserBL FollowUserBL)
        {
            _FollowUserBL = FollowUserBL;
        }

        // GET: api/<FollowUserController>
        [HttpGet]
        public async Task<IActionResult> GetAllFollowUser()
        {
            return Ok(await _FollowUserBL.GetAllFollowUserAsync());
        }

        // GET api/<FollowUserController>/5
        [HttpGet]
        [Route("GetFollowingByUser/{email}")]
        public async Task<IActionResult> GetFollowingByUser(string email)
        {
            return Ok(await _FollowUserBL.GetFollowingByUserAsync(email));
        }

        [HttpGet]
        [Route("GetFollowersByUser/{email}")]
        public async Task<IActionResult> GetFollowersByUser(string email)
        {
            return Ok(await _FollowUserBL.GetFollowersByUserAsync(email));
        }

        [HttpGet]
        [Route("GetFollowersByUser/{followerEmail}/{followedEmail}")]
        public async Task<IActionResult> IsFollowed(string followerEmail, string followedEmail)
        {
            return Ok(await _FollowUserBL.IsFollowingAsync(followerEmail, followedEmail));
        }

        // POST api/<FollowUserController>
        [HttpPost]
        public async Task<IActionResult> AddFollowUser([FromBody] FollowUser value)
        {
            return Created("api/FollowUser", await _FollowUserBL.AddFollowUserAsync(value));
        }

        // DELETE api/<FollowUserController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _FollowUserBL.DeleteFollowUserAsync(id);
            return NoContent();
        }
    }
}
