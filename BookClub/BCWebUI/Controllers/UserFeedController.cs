using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BCBL;
using BCModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BCWebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserFeedController : ControllerBase
    {
        private IUserFeedBL _userFeedBL;
        public UserFeedController(IUserFeedBL userFeedBL)
        {
            _userFeedBL = userFeedBL;
        }

        // GET api/<UserFeedController>/5
        [HttpGet("{userEmail}")]
        public async Task<IActionResult> Get(string userEmail)
        {
            return Ok( await _userFeedBL.GetuserFeedAsync(userEmail));
        }
    }
}
