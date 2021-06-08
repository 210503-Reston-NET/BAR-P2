using BCBL;
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
    public class AchievementController : ControllerBase
    {
        private readonly IAchievementBL _bl;
        public AchievementController(IAchievementBL e) { this._bl = e; }
        // GET: api/<AchievementController>
        [HttpGet]
        public IActionResult GetAchievements()
        {
            return Ok(_bl.GetAchievements().ToList());
        }

        // GET api/<AchievementController>/email
        [HttpGet("{id}")]
        public Achievement GetAchievementByEmail(string email)
        {
            return _bl.GetAchievementByEmail(email);
        }

        // POST api/<AchievementController>
        [HttpPost]
        public void Post([FromBody] Achievement achievement)
        {
            _bl.AddAchievement(achievement);
        }

        // PUT api/<AchievementController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Achievement achievement)
            
        {
            _bl.UpdateAchievement(achievement);
        }

        // DELETE api/<AchievementController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
