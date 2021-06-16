using BCDL;
using BCModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BCWebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecommendationController : ControllerBase
    {

        private readonly IRecommendationRepo _bl;
        public RecommendationController(IRecommendationRepo e) { this._bl = e; }
        // GET: api/<RecommendationController>
        [HttpGet]
        public async Task<IActionResult> GetRecommendations()
        {
            return Ok(await _bl.GetRecommendationsAsync());
        }

        // GET api/<RecommendationController>/email
        [HttpGet("{email}")]
        public async Task<IActionResult> Get(string email)
        {
            return Ok(await _bl.GetRecommendationByEmailAsync(email));
        }

        // POST api/<RecommendationController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Recommendation recommendation)
        {
            return Ok(await _bl.AddRecommendationAsync(recommendation));
        }

        // PUT api/<RecommendationController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Recommendation recommendation)
        {
            return Ok(await _bl.UpdateRecommendationAsync(recommendation));
        }
    }
}
