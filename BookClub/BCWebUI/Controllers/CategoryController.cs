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
        public async Task<IActionResult> GetAllCategories()
        {
            return Ok(await _IcategoryBL.GetAllCategoriesAsync());
        }

        // GET api/<CategoryController>/5
        [HttpGet("{name}")]
        public async Task<IActionResult> GetCategory(string name)
        {
            return Ok(await _IcategoryBL.GetCategoryAsync(name));
        }
    }
}
