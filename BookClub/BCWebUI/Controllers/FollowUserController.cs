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
        public IActionResult GetAllFollowUser()
        {
            return Ok(_FollowUserBL.GetAllFollowUser());
        }

        // GET api/<FollowUserController>/5
        [HttpGet]
        [Route("GetFollowingByUser/{email}")]
        public IActionResult GetFollowingByUser(string email)
        {
            return Ok(_FollowUserBL.GetFollowingByUser(email));
        }

        [HttpGet]
        [Route("GetFollowersByUser/{email}")]
        public IActionResult GetFollowersByUser(string email)
        {
            return Ok(_FollowUserBL.GetFollowersByUser(email));
        }

        // POST api/<FollowUserController>
        [HttpPost]
        public IActionResult AddFollowUser([FromBody] FollowUser value)
        {
            return Created("api/FollowUser", _FollowUserBL.AddFollowUser(value));
        }

        // PUT api/<FollowUserController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return NoContent();
        }

        // DELETE api/<FollowUserController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _FollowUserBL.DeleteFollowUser(id);
            return NoContent();
        }
    }
}
