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
        public async Task<IActionResult> GetAllClubPosts()
        {
            return Ok(await _clubPostBL.GetAllClubPostsAsync());
        }

        // GET: api/ClubPost/5
        [HttpGet("GetClubPostByBookClub/{bookClubId}")]
        public async Task<IActionResult> GetClubPostByBookClub(int bookClubId)
        {
            return Ok(await _clubPostBL.GetClubPostByBookClubAsync(bookClubId));
        }

        //Get
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClubPostById(int id)
        {
            return Ok(await _clubPostBL.GetClubPostByIdAsync(id));
        }

        // POST: api/ClubPost
        [HttpPost]
        public async Task<IActionResult> AddNewClubPost([FromBody] ClubPost newClubPost)
        {
            return Created("api/ClubPost", await _clubPostBL.AddClubPostAsync(newClubPost));
        }
   
        // PUT: api/ClubPost/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClubPost(int id, [FromBody] ClubPost updatedClubPost)
        {
            await _clubPostBL.UpdateClubPostAsync(updatedClubPost);
            return NoContent();
        }

        // PUT: api/ClubPost/5
        [HttpPut("DislikeClubPost/{id}")]
        public async Task<IActionResult> DislikeClubPost(int id, [FromBody] ClubPost updatedClubPost)
        {
            await _clubPostBL.DislikeClubPostAsync(updatedClubPost);
            return NoContent();
        }

        // PUT: api/ClubPost/5
        [HttpPut("LikeClubPost/{id}")]
        public async Task<IActionResult> LikeClubPost(int id, [FromBody] ClubPost updatedClubPost)
        {
            await _clubPostBL.LikeClubPostAsync(updatedClubPost);
            return NoContent();
        }

        // DELETE: api/ClubPost/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClubPost(int id)
        {
            await _clubPostBL.DeleteClubPostAsync(await _clubPostBL.GetClubPostByIdAsync(id));
            return NoContent();
        }
    }
}
