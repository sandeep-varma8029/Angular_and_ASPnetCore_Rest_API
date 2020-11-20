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
    public class BusSkillController : ControllerBase
    {
        ExpressoDbContext _expressoDbContext;

        public BusSkillController(ExpressoDbContext expressoDbContext)
        {
            _expressoDbContext = expressoDbContext;
        }
        // GET: api/<BusSkillController>
        [HttpGet]
        public IEnumerable<BusSkill> Get()
        {
            return _expressoDbContext.BusSkill;
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var quote = _expressoDbContext.BusSkill.Find(id);
            if (quote == null)
            {
                return NotFound("No Record Found");
            }

            return Ok(quote);
        }

        // POST api/<BusSkillController>
        [HttpPost]
        public IActionResult Post([FromBody] BusSkill busskill)
        {
            _expressoDbContext.BusSkill.Add(busskill);
            _expressoDbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<BusSkillController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] BusSkill busskill)
        {
            var entity = _expressoDbContext.BusSkill.Find(id);
            if (entity == null)
            {
                return NotFound("No Record Found");
            }
            else
            {
                entity.Name = busskill.Name;
                entity.Proficiency = busskill.Proficiency;
                _expressoDbContext.SaveChanges();
                return Ok("Record Updated Successfully......");
            }
        }

        // DELETE api/<BusSkillController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var quote = _expressoDbContext.BusSkill.Find(id);
            if (quote == null)
            {
                return NotFound("No Record Found");
            }
            else
            {
                _expressoDbContext.BusSkill.Remove(quote);
                _expressoDbContext.SaveChanges();
                return Ok("Quote deleted");

            }

        }
    }
}
