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
    public class LanguageController : ControllerBase
    {
        ExpressoDbContext _expressoDbContext;

        public LanguageController(ExpressoDbContext expressoDbContext)
        {
            _expressoDbContext = expressoDbContext;
        }
        // GET: api/<BusSkillController>
        [HttpGet]
        public IEnumerable<Languages> Get()
        {
            return _expressoDbContext.Languages;
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var quote = _expressoDbContext.Languages.Find(id);
            if (quote == null)
            {
                return NotFound("No Record Found");
            }

            return Ok(quote);
        }

        // POST api/<BusSkillController>
        [HttpPost]
        public IActionResult Post([FromBody] Languages languages)
        {
            _expressoDbContext.Languages.Add(languages);
            _expressoDbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<BusSkillController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Languages languages)
        {
            var entity = _expressoDbContext.Languages.Find(id);
            if (entity == null)
            {
                return NotFound("No Record Found");
            }
            else
            {
                entity.Name = languages.Name;
                entity.Proficiency = languages.Proficiency;
                _expressoDbContext.SaveChanges();
                return Ok("Record Updated Successfully......");
            }
        }

        // DELETE api/<BusSkillController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var quote = _expressoDbContext.Languages.Find(id);
            if (quote == null)
            {
                return NotFound("No Record Found");
            }
            else
            {
                _expressoDbContext.Languages.Remove(quote);
                _expressoDbContext.SaveChanges();
                return Ok("Quote deleted");

            }

        }
    }
}
