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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryBL _IcategoryBL;

        public CategoryController(ICategoryBL IcategoryBL)
        {
            _IcategoryBL = IcategoryBL;
        }
        // GET: api/<CategoryController>
        [HttpGet]
        public IActionResult GetAllCategories()
        {
            return Ok(_IcategoryBL.GetAllCategoriesAsync());
        }

        // GET api/<CategoryController>/5
        [HttpGet("{name}")]
        public IActionResult GetCategory(string name)
        {
            return Ok(_IcategoryBL.GetCategoryAsync(name));
        }

        // POST api/<CategoryController>
        [HttpPost]
        public IActionResult AddCategory([FromBody] Category value)
        {
            return Created("api/Category", _IcategoryBL.AddCategoryAsync(value));
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{name}")]
        public IActionResult DeleteCategory(string name)
        {
            _IcategoryBL.DeleteCategoryAsync(name);
            return NoContent();
        }
    }
}
