using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BCBL;
using BCModel;
using Microsoft.AspNetCore.Cors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BCWebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[EnableCors(origins: "http://127.0.0.1:4200", headers: "*", methods: "*")]
    public class BookController : ControllerBase
    {
        private readonly IBookBL _IbookBL;

        public BookController(IBookBL IbookBL)
        {
            _IbookBL = IbookBL;
        }

        // GET: api/<BookController>
        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            return Ok(await _IbookBL.GetAllBooksAsync());
        }

        // GET api/<BookController>/5
        [HttpGet("{isbn}")]
        public async Task<IActionResult> GetBookByISBN(string isbn)
        {
            return Ok(await _IbookBL.GetBookByISBNAsync(isbn));
        }

        // Get
        [HttpGet]
        [Route("bookByAuthor/{author}")]
        public async Task<IActionResult> GetBookByAuthor(string author)
        {
            return Ok(await _IbookBL.GetBookByAuthorAsync(author));
        }

        // Get
        [HttpGet]
        [Route("bookByTitle/{title}")]
        public async Task<IActionResult> GetBookByTitle(string title)
        {
            return Ok(await _IbookBL.GetBookByTitleAsync(title));
        }

        // POST api/<BookController>
        [HttpPost]
        public async Task<IActionResult> AddBook([FromBody]Book book)
        {
            return Created("api/Book", await _IbookBL.AddBookAsync(book));
        }

        // PUT api/<BookController>/5
        [HttpPut("{isbn}")]
        public async Task<IActionResult> UpdateBook(string isbn, [FromBody]Book book)
        {
            await _IbookBL.UpdateBookAsync(book);
            return NoContent();
        }


        // DELETE api/<BookController>/5
        [HttpDelete("{isbn}")]
        public async Task<IActionResult> Delete(string isbn)
        {
            await _IbookBL.DeleteBookAsync(isbn);
            return NoContent();
        }
    }
}
