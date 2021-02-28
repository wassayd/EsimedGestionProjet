using EsimedGestionProjet.Dtos;
using EsimedGestionProjet.Models;
using EsimedGestionProjet.Repositories;
using EsimedGestionProjet.Repositories.InMemory;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EsimedGestionProjet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectRepository inMemProjectRepository;

        public ProjectController(IProjectRepository inMemProjectRepository)
        {
            this.inMemProjectRepository = inMemProjectRepository;
        }


        // GET: api/<ProjectController>
        [HttpGet]
        public IEnumerable<ProjectDto> Get()
        {
            //t
            var projects = inMemProjectRepository.GetAll().Select(project => project.AsDto());

            return projects;
        }

        // GET api/<ProjectController>/5
        [HttpGet("{id}")]
        public ActionResult<ProjectDto> Get(Guid id)
        {
            var project = inMemProjectRepository.GetById(id);

            if (project is null)
            {
                return NotFound();
            }

            return project.AsDto();
        }

        // POST api/<ProjectController>
        [HttpPost]
        public ActionResult<ProjectDto> Post(CreateProjectDto projectDto)
        {
            Project project = new()
            {
                Id = Guid.NewGuid(),
                EndDateReal = null,
                EndDateTheorical = (DateTime)projectDto.EndDateTheorical,
                Milestones = null,
                Name = projectDto.Name,
                Requirements = null,
                StartDate = DateTime.Now,
                Tasks = null,
                User = null
            };

            inMemProjectRepository.Insert(project);

            return CreatedAtAction(nameof(Get), new { id = project.Id }, project.AsDto());
        }

        // PUT api/<ProjectController>/5
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, UpdateProjectDto projectDto) 
        {
            var project = inMemProjectRepository.GetById(id);

            if(project is null)
            {
                return NotFound();
            }

            //create copy with modification of name and date
            Project updatedProject = project with
            {
                Name = projectDto.Name,
                EndDateTheorical = (DateTime)projectDto.EndDateTheorical
            };

            inMemProjectRepository.Update(updatedProject);

            return NoContent();
        }

        // DELETE api/<ProjectController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            var project = inMemProjectRepository.GetById(id);

            if (project is null)
            {
                return NotFound();
            }

            inMemProjectRepository.Delete(id);

            return NoContent();
        }
    }
}
