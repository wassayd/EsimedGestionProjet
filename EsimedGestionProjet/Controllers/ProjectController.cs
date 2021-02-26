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
        public IEnumerable<Project> Get()
        {
            return inMemProjectRepository.GetAll();
        }

        // GET api/<ProjectController>/5
        [HttpGet("{id}")]
        public ActionResult<Project> Get(int id)
        {
            var project = inMemProjectRepository.GetById(id);

            if (project is null)
            {
                return NotFound();
            }

            return project;
        }

        // POST api/<ProjectController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProjectController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProjectController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
