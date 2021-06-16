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
        public async Task<IActionResult> GetAchievements()
        {
            return Ok(await _bl.GetAchievementsAsync());
        }

        // GET api/<AchievementController>/email
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAchievementByEmail(string email)
        {
            return Ok(await _bl.GetAchievementByEmailAsync(email));
        }

        // POST api/<AchievementController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Achievement achievement)
        {
            return Ok(await _bl.AddAchievementAsync(achievement));
        }

        // PUT api/<AchievementController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Achievement achievement)
            
        {
           return  Ok(await _bl.UpdateAchievementAsync(achievement));
        }
    }
}
