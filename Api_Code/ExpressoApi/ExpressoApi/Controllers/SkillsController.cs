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
    public class SkillsController : ControllerBase
    {
        ExpressoDbContext _expressoDbContext;

        public SkillsController(ExpressoDbContext expressoDbContext)
        {
            _expressoDbContext = expressoDbContext;
        }

        [HttpGet]
        public IActionResult GetSkills()
        {
            var skills = _expressoDbContext.Skills.Include("SkillGroup");
            return Ok(skills);
        }

        [HttpGet("{id}")]
        public IActionResult GetSkill(int id)
        {
            var skill = _expressoDbContext.Skills.Include("SkillGroup").FirstOrDefault(m => m.Id == id);
            if (skill == null)
            {
                return NotFound();
            }

            return Ok(skill);
        }
    }
}
