using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpressoApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExpressoApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExpressoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechSkillController : ControllerBase
    {
        ExpressoDbContext _expressoDbContext;

        public TechSkillController(ExpressoDbContext expressoDbContext)
        {
            _expressoDbContext = expressoDbContext;
        }
        // GET: api/<TechSkillController>
        [HttpGet]
        public IEnumerable<TechSkill> Get()
        {
            return _expressoDbContext.TechSkill;
        }
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var quote = _expressoDbContext.TechSkill.Find(id);
            if (quote == null)
            {
                return NotFound("No Record Found");
            }

            return Ok(quote);
        }
        // POST api/<UserSkillGroupController>
        [HttpPost]
        public IActionResult Post([FromBody] TechSkill techskill)
        {
            _expressoDbContext.TechSkill.Add(techskill);
            _expressoDbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }


        // PUT api/<TechSkillController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TechSkill techskill)
        {
            var entity = _expressoDbContext.TechSkill.Find(id);
            if (entity == null)
            {
                return NotFound("No Record Found");
            }
            else
            {
                entity.Name = techskill.Name;
                entity.Proficiency = techskill.Proficiency;
                _expressoDbContext.SaveChanges();
                return Ok("Record Updated Successfully......");
            }
        }

        // DELETE api/<TechSkillController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var quote = _expressoDbContext.TechSkill.Find(id);
            if (quote == null)
            {
                return NotFound("No Record Found");
            }
            else
            {
                _expressoDbContext.TechSkill.Remove(quote);
                _expressoDbContext.SaveChanges();
                return Ok("Quote deleted");

            }

        }
    }
}
