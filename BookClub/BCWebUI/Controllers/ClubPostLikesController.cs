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
        public IActionResult GetAllClubPostLikes()
        {
            return Ok(_clubPostLikesBL.GetAllClubPostLikesAsync());
        }

        // GET: api/ClubPostLikes/5
        [HttpGet("{id}")]
        public IActionResult GetClubPostLikesById(int id)
        {
            return Ok(_clubPostLikesBL.GetClubPostLikesByIdAsync(id));
        }

        //Get
        [HttpGet("GetClubPostLikesByClubPost/{clubPostId}")]
        public IActionResult GetClubPostLikesByClubPost(int clubPostId)
        {
            return Ok(_clubPostLikesBL.GetClubPostLikesByClubPostAsync(clubPostId));
        }

        // POST: api/ClubPostLikes
        [HttpPost]
        public IActionResult AddNewClubPostLike([FromBody] ClubPostLikes like)
        {
            return Created("api/ClubPostLikes", _clubPostLikesBL.AddClubPostLikeAsync(like));
        }
    }
}
