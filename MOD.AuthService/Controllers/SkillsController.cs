using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD.AuthLibrary.Models;
using MOD.AuthService.Data;

namespace MOD.AuthService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        IRepository repository;

        public SkillsController(IRepository repository)
        {
            this.repository = repository;
        }
        // GET: api/Skills
        [HttpGet]
        public IActionResult GetSkills()
        {
            var skills = repository.GetSkills();
            if (!skills.Any())
            {
                return NoContent();
            }
            return Ok(skills);
        }


        // GET: api/Skills/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var skill = repository.GetSkill(id);
            if (skill == null)
            {
                return NotFound();
            }
            return Ok(skill);
        }


        // POST: api/Skills
        [HttpPost]
        public IActionResult Post([FromBody] Skill skill)
        {
            if (ModelState.IsValid)
            {
                bool result = repository.AddSkill(skill);
                if (result)
                {
                    return Created("AddSkill", skill.Id);
                }
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return BadRequest(ModelState);
        }

        // PUT: api/Skills/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Skill skill)
        {

            if (ModelState.IsValid && id == skill.Id)
            {
                bool result = repository.UpdateSkill(skill);
                if (result)
                {
                    return Ok();
                }
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return BadRequest(ModelState);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var skill = repository.GetSkill(id);
            if (skill == null)
            {
                return NotFound();
            }
            bool result = repository.DeleteSkill(skill);
            if (result)
            {
                return Ok();
            }
            return StatusCode(StatusCodes.Status500InternalServerError);
        }


    }
}
