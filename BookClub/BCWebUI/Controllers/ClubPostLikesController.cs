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
    public class ClubPostLikesController : ControllerBase
    {
        private readonly IClubPostLikesBL _clubPostLikesBL;
        public ClubPostLikesController(IClubPostLikesBL clubPostLikesBL)
        {
            _clubPostLikesBL = clubPostLikesBL;
        }

        // GET: api/ClubPostLikes
        [HttpGet]
        public async Task<IActionResult> GetAllClubPostLikes()
        {
            return Ok(await _clubPostLikesBL.GetAllClubPostLikesAsync());
        }

        // GET: api/ClubPostLikes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClubPostLikesById(int id)
        {
            return Ok(await _clubPostLikesBL.GetClubPostLikesByIdAsync(id));
        }

        //Get
        [HttpGet("GetClubPostLikesByClubPost/{clubPostId}")]
        public async Task<IActionResult> GetClubPostLikesByClubPost(int clubPostId)
        {
            return Ok(await _clubPostLikesBL.GetClubPostLikesByClubPostAsync(clubPostId));
        }

        // POST: api/ClubPostLikes
        [HttpPost]
        public async Task<IActionResult> AddNewClubPostLike([FromBody] ClubPostLikes like)
        {
            return Created("api/ClubPostLikes", await _clubPostLikesBL.AddClubPostLikeAsync(like));
        }
    }
}
