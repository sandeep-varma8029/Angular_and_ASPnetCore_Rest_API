using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpressoApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExpressoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProficiencyController : ControllerBase
    {
        ExpressoDbContext _expressoDbContext;

        public ProficiencyController(ExpressoDbContext expressoDbContext)
        {
            _expressoDbContext = expressoDbContext;
        }

        [HttpGet]
        public IActionResult GetProficiency()
        {
            var proficiency = _expressoDbContext.Proficiency.Include("ProficiencyGroup");
            return Ok(proficiency);
        }

        [HttpGet("{id}")]
        public IActionResult GetSkill(int id)
        {
            var proficiency = _expressoDbContext.Proficiency.Include("ProficiencyGroup").FirstOrDefault(m => m.Id == id);
            if (proficiency == null)
            {
                return NotFound();
            }

            return Ok(proficiency);
        }
    }
}
