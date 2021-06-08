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
            return Ok(_userBL.GetAllUsers().ToList());
        }

        // GET api/<UserController>/5
        [HttpGet("{email}")]
        public User GetUserByEmail(string email)
        {
            return _userBL.GetUserByEmail(email);
        }

        // POST api/<UserController>
        [HttpPost]
        public void AddUser([FromBody] User user)
        {
            _userBL.AddUser(user);
        }

        // PUT api/<UserController>/5
        [HttpPut("{email}")]
        public void UpdateUser(string email, [FromBody] User user)
        {
            _userBL.UpdateUser(user);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
