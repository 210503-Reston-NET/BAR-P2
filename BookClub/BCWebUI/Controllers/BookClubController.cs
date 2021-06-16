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
        public IActionResult GetAllBookClubs()
        {
            return Ok(_bookClubBL.GetAllBookClubsAsync());
        }

        // GET: api/BookClub/5
        [HttpGet("{id}")]
        public IActionResult GetBookClubById(int id)
        {
            return Ok(_bookClubBL.GetBookClubByIdAsync(id));
        }

        //Get
        [HttpGet("GetBookClubByBook/{bookId}")]
        public IActionResult GetBookClubByBook(string bookId)
        {
            return Ok(_bookClubBL.GetBookClubByBookAsync(bookId));
        }

        // POST: api/BookClub
        [HttpPost]
        public IActionResult AddNewBookClub([FromBody] Model.BookClub newBookClub)
        {
            return Created("api/BookClub", _bookClubBL.AddBookClubAsync(newBookClub));
        }

        // PUT: api/BookClub/5
        [HttpPut("{id}")]
        public IActionResult UpdateBookClub(int id, [FromBody] Model.BookClub updatedBookClub)
        {
            _bookClubBL.UpdateBookClubAsync(updatedBookClub);
            return NoContent();
        }

        // DELETE: api/BookClub/5
        [HttpDelete("{id}")]
        public IActionResult DeleteBookClub(int id)
        {
            _bookClubBL.DeleteBookClubAsync(_bookClubBL.GetBookClubByIdAsync(id));
            return NoContent();
        }
    }
}
