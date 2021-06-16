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
        public IActionResult GetRecommendations()
        {
            return Ok(_bl.GetRecommendationsAsync().ToList());
        }

        // GET api/<RecommendationController>/email
        [HttpGet("{email}")]
        public Recommendation Get(string email)
        {
            return _bl.GetRecommendationByEmailAsync(email);
        }

        // POST api/<RecommendationController>
        [HttpPost]
        public void Post([FromBody] Recommendation recommendation)
        {
            _bl.AddRecommendationAsync(recommendation);
        }

        // PUT api/<RecommendationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Recommendation recommendation)
        {
            _bl.UpdateRecommendationAsync(recommendation);
        }

        // DELETE api/<RecommendationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
