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
        public async Task<IActionResult> GetAllUserPostLikes()
        {
            return Ok(await _userPostLikesBL.GetAllUserPostLikesAsync());
        }

        // GET: api/UserPostLikes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserPostLikesById(int id)
        {
            return Ok(await _userPostLikesBL.GetUserPostLikesByIdAsync(id));
        }

        //Get
        [HttpGet("GetUserPostLikesByUserPost/{userPostId}")]
        public async Task<IActionResult> GetUserPostLikesByUserPost(int userPostId)
        {
            return Ok(await _userPostLikesBL.GetUserPostLikesByUserPostAsync(userPostId));
        }

        // POST: api/UserPostLikes
        [HttpPost]
        public async Task<IActionResult> AddNewUserPostLike([FromBody] UserPostLikes like)
        {
            return Created("api/UserPostLikes", await _userPostLikesBL.AddUserPostLikeAsync(like));
        }
    }
}
