using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BCBL;
using BCModel;

namespace BCWebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPostLikesController : ControllerBase
    {
        private readonly IUserPostLikesBL _userPostLikesBL;
        public UserPostLikesController(IUserPostLikesBL userPostLikesBL)
        {
            _userPostLikesBL = userPostLikesBL;
        }


        // GET: api/UserPostLikes
        [HttpGet]
        public IActionResult GetAllUserPostLikes()
        {
            return Ok(_userPostLikesBL.GetAllUserPostLikes());
        }

        // GET: api/UserPostLikes/5
        [HttpGet("{id}")]
        public IActionResult GetUserPostLikesById(int id)
        {
            return Ok(_userPostLikesBL.GetUserPostLikesById(id));
        }

        //Get
        [HttpGet("GetUserPostLikesByUserPost/{userPostId}")]
        public IActionResult GetUserPostLikesByUserPost(int userPostId)
        {
            return Ok(_userPostLikesBL.GetUserPostLikesByUserPost(userPostId));
        }

        // POST: api/UserPostLikes
        [HttpPost]
        public IActionResult AddNewUserPostLike([FromBody] UserPostLikes like)
        {
            return Created("api/UserPostLikes", _userPostLikesBL.AddUserPostLike(like));
        }
    }
}
