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
    public class BooksReadController : ControllerBase
    {
        private readonly IBooksReadBL _IbookBL;

        public BooksReadController(IBooksReadBL IbookBL)
        {
            _IbookBL = IbookBL;
        }


        // GET: api/<BooksReadController>
        [HttpGet]
        public async Task<IActionResult> GetAllBooksRead()
        {
            return Ok(await _IbookBL.GetAllBooksReadAsync());
        }

        // GET api/<BooksReadController>/5
        [HttpGet("{email}")]
        public async Task<IActionResult> GetBooksReadByUser(string email)
        {
            return Ok(await _IbookBL.GetBooksReadByUserAsync(email));
        }

        // POST api/<BooksReadController>
        [HttpPost]
        public async Task<IActionResult> AddBooksRead([FromBody] BooksRead value)
        {
            return Created("api/BooksRead", await _IbookBL.AddBooksReadAsync(value));
        }
    }
}
