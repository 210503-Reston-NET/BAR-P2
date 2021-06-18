using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BCBL;
using Model = BCModel;


namespace BCWebUI.Controllers
{
    [Route("api/BookClub")]
    [ApiController]
    public class BookClubController : ControllerBase
    {
        private readonly IBookClubBL _bookClubBL;

        public BookClubController(IBookClubBL bookClubBL)
        {
            _bookClubBL = bookClubBL;
        }

        // GET: api/BookClub
        [HttpGet]
        public async Task<IActionResult> GetAllBookClubs()
        {
            return Ok(await _bookClubBL.GetAllBookClubsAsync());
        }

        // GET: api/BookClub/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookClubById(int id)
        {
            return Ok(await _bookClubBL.GetBookClubByIdAsync(id));
        }

        //Get
        [HttpGet("GetBookClubByBook/{bookId}")]
        public async Task<IActionResult> GetBookClubByBook(string bookId)
        {
            return Ok(await _bookClubBL.GetBookClubByBookAsync(bookId));
        }

        [HttpGet]
        [Route("BookClubByUser/{email}")]
        public async Task<IActionResult> GetBookClubsByUser(string email)
        {
            return Ok(await _bookClubBL.GetBookClubsByUserAsync(email));
        }

        // POST: api/BookClub
        [HttpPost]
        public async Task<IActionResult> AddNewBookClub([FromBody] Model.BookClub newBookClub)
        {
            return Created("api/BookClub", await _bookClubBL.AddBookClubAsync(newBookClub));
        }

        // PUT: api/BookClub/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBookClub(int id, [FromBody] Model.BookClub updatedBookClub)
        {
            await _bookClubBL.UpdateBookClubAsync(updatedBookClub);
            return NoContent();
        }

        // DELETE: api/BookClub/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookClub(int id)
        {
            await _bookClubBL.DeleteBookClubAsync(await _bookClubBL.GetBookClubByIdAsync(id));
            return NoContent();
        }
    }
}
