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
        private IBookBL _IbookBL;

        public BookController(IBookBL IbookBL)
        {
            _IbookBL = IbookBL;
        }

        // GET: api/<BookController>
        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok(_IbookBL.GetAllBooks());
        }

        // GET api/<BookController>/5
        [HttpGet("{isbn}")]
        public IActionResult GetBookByISBN(string isbn)
        {
            return Ok(_IbookBL.GetBookByISBN(isbn));
        }

        [HttpGet]
        [Route("api/[controller]/bookByAuthor/{author}")]
        public IActionResult GetBookByAuthor(string author)
        {
            return Ok(_IbookBL.GetBookByAuthor(author));
        }

        [HttpGet]
        [Route("api/[controller]/bookByTitle/{title}")]
        public IActionResult GetBookByTitle(string title)
        {
            return Ok(_IbookBL.GetBookByTitle(title));
        }

        // POST api/<BookController>
        [HttpPost]
        public IActionResult AddBook([FromBody]Book book)
        {
            return Created("api/Book", _IbookBL.AddBook(book));
        }

        // PUT api/<BookController>/5
        [HttpPut("{isbn}")]
        public IActionResult UpdateBook(string isbn, [FromBody]Book book)
        {
            _IbookBL.UpdateBook(book);
            return NoContent();
        }


        // DELETE api/<BookController>/5
        [HttpDelete("{isbn}")]
        public IActionResult Delete(string isbn)
        {
            _IbookBL.DeleteBook(isbn);
            return NoContent();
        }
    }
}
