using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BCBL;
using BCModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BCWebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubPostController : ControllerBase
    {
        private readonly IClubPostBL _clubPostBL;

        public ClubPostController(IClubPostBL clubPostBL)
        {
            _clubPostBL = clubPostBL;
        } 


        // GET: api/ClubPost
        [HttpGet]
        public IActionResult GetAllClubPosts()
        {
            return Ok(_clubPostBL.GetAllClubPostsAsync());
        }

        // GET: api/ClubPost/5
        [HttpGet("GetClubPostByBookClub/{bookClubId}")]
        public IActionResult GetClubPostByBookClub(int bookClubId)
        {
            return Ok(_clubPostBL.GetClubPostByBookClubAsync(bookClubId));
        }

        //Get
        [HttpGet("{id}")]
        public IActionResult GetClubPostById(int id)
        {
            return Ok(_clubPostBL.GetClubPostByIdAsync(id));
        }

        // POST: api/ClubPost
        [HttpPost]
        public IActionResult AddNewClubPost([FromBody] ClubPost newClubPost)
        {
            return Created("api/ClubPost", _clubPostBL.AddClubPost(newClubPost));
        }
    
   

        // PUT: api/ClubPost/5
        [HttpPut("{id}")]
        public IActionResult UpdateClubPost(int id, [FromBody] ClubPost updatedClubPost)
        {
            _clubPostBL.UpdateClubPostAsync(updatedClubPost);
            return NoContent();
        }

        // PUT: api/ClubPost/5
        [HttpPut("DislikeClubPost/{id}")]
        public IActionResult DislikeClubPost(int id, [FromBody] ClubPost updatedClubPost)
        {
            _clubPostBL.DislikeClubPostAsync(updatedClubPost);
            return NoContent();
        }

        // PUT: api/ClubPost/5
        [HttpPut("LikeClubPost/{id}")]
        public IActionResult LikeClubPost(int id, [FromBody] ClubPost updatedClubPost)
        {
            _clubPostBL.LikeClubPostAsync(updatedClubPost);
            return NoContent();
        }

        // DELETE: api/ClubPost/5
        [HttpDelete("{id}")]
        public IActionResult DeleteClubPost(int id)
        {
            _clubPostBL.DeleteClubPost(_clubPostBL.GetClubPostByIdAsync(id));
            return NoContent();
        }
    }
}
