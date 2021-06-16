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
        public IActionResult GetAllFollowClub()
        {
            return Ok(_IFollowClubBL.GetAllFollowClubAsync());
        }

        // GET api/<FollowClubController>/5
        [HttpGet]
        [Route("GetFollowingByUser/{email}")]
        public IActionResult GetFollowingByUser(string email)
        {
            return Ok(_IFollowClubBL.GetFollowingByUserAsync(email));
        }

        [HttpGet]
        [Route("GetFollowersByClub/{id}")]
        public IActionResult GetFollowersByClub(int id)
        {
            return Ok(_IFollowClubBL.GetFollowersByClubAsync(id));
        }

        // POST api/<FollowClubController>
        [HttpPost]
        public IActionResult AddFollowClub([FromBody] FollowClub value)
        {
            return Created("api/FollowClub",_IFollowClubBL.AddFollowClubAsync(value));
        }

        // PUT api/<FollowClubController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return NoContent();
        }

        // DELETE api/<FollowClubController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _IFollowClubBL.DeleteFollowClubAsync(id);
            return NoContent();
        }
    }
}
