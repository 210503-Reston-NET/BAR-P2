using BCBL;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using BCModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BCWebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBL _userBL;
        public UserController(IUserBL e) { this._userBL = e; }
        // GET: api/<UserController>
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(_userBL.GetAllUsersAsync().ToList());
        }

        // GET api/<UserController>/5
        [HttpGet("{email}")]
        public IActionResult GetUserByEmail(string email)
        {
            return Ok(_userBL.GetUserByEmailAsync(email));
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult AddUser([FromBody] User newUser)
        {
            return Created("api/User", _userBL.AddUserAsync(newUser));
        }

        // PUT api/<UserController>/5
        [HttpPut("{email}")]
        public IActionResult UpdateUser(string email, [FromBody] User newUser)
        {
            _userBL.UpdateUserAsync(newUser);
            return NoContent();
        }
    }
}
