using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BCBL;
using BCModel;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BCWebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteBookController : ControllerBase
    {
        private readonly IFavoriteBookBL _IbookBL;

        public FavoriteBookController(IFavoriteBookBL IbookBL)
        {
            _IbookBL = IbookBL;
        }


        // GET: api/<BooksReadController>
        [HttpGet]
        public IActionResult GetAllBooksRead()
        {
            return Ok(_IbookBL.GetAllBooksReadAsync());
        }

        // GET api/<BooksReadController>/5
        [HttpGet("{email}")]
        public IActionResult GetBooksReadByUser(string email)
        {
            return Ok(_IbookBL.GetBooksReadByUserAsync(email));
        }

        // POST api/<BooksReadController>
        [HttpPost]
        public IActionResult AddBooksRead([FromBody] FavoriteBook value)
        {
            return Created("api/BooksRead", _IbookBL.AddBooksReadAsync(value));
        }

        // PUT api/<BooksReadController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateBooksRead(int id, [FromBody] FavoriteBook value)
        {
            _IbookBL.UpdateBooksReadAsync(value);
            return NoContent();
        }

        // DELETE api/<BooksReadController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteBooksRead(int id)
        {
            _IbookBL.DeleteBooksReadAsync(id);
            return NoContent();
        }
    }
}
