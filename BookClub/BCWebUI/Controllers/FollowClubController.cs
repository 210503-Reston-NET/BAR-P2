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
    public class FollowClubController : ControllerBase
    {
        private readonly IFollowClubBL _IFollowClubBL;

        public FollowClubController(IFollowClubBL IFollowClubBL)
        {
            _IFollowClubBL = IFollowClubBL;
        }

        // GET: api/<FollowClubController>
        [HttpGet]
        public async Task<IActionResult> GetAllFollowClub()
        {
            return Ok(await _IFollowClubBL.GetAllFollowClubAsync());
        }

        // GET api/<FollowClubController>/5
        [HttpGet]
        [Route("GetFollowingByUser/{email}")]
        public async Task<IActionResult> GetFollowingByUser(string email)
        {
            return Ok(await _IFollowClubBL.GetFollowingByUserAsync(email));
        }

        [HttpGet]
        [Route("GetFollowersByClub/{id}")]
        public async Task<IActionResult> GetFollowersByClub(int id)
        {
            return Ok(await _IFollowClubBL.GetFollowersByClubAsync(id));
        }

        // POST api/<FollowClubController>
        [HttpPost]
        public async Task<IActionResult> AddFollowClub([FromBody] FollowClub value)
        {
            return Created("api/FollowClub",await _IFollowClubBL.AddFollowClubAsync(value));
        }

        [HttpGet]
        [Route("GetFollowersByUser/{followerEmail}/{clubId}")]
        public async Task<IActionResult> IsFollowed(string followerEmail, int clubId)
        {
            return Ok(await _IFollowClubBL.IsFollowingAsync(followerEmail, clubId));
        }

        // DELETE api/<FollowClubController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _IFollowClubBL.DeleteFollowClubAsync(id);
            return NoContent();
        }

        [HttpDelete]
        [Route("DeleteFollowersByUser/{followerEmail}/{BookClubId}")]
        public async Task<IActionResult> DeleteByEmail(string followerEmail, int BookClubId)
        {
            await _IFollowClubBL.DeleteFollowerByEmailsAsync(followerEmail, BookClubId);
            return NoContent();
        }
    }
}
