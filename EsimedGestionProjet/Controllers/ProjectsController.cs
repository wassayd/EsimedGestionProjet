using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EsimedGestionProjet.Entities.DataAccess;
using EsimedGestionProjet.Models;
using EsimedGestionProjet.Dtos;

namespace EsimedGestionProjet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public ProjectsController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Projects
        [HttpGet]
        public async Task<IEnumerable<ProjectDto>> GetProject()
        {
            return await _context.Project
                .Include(p => p.User)
                .Select(project => project.AsDto())        
                .ToListAsync();
        }

        // GET: api/Projects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProjectDto>> GetProject(Guid id)
        {
            Project project = await _context.Project.Where(p => p.Id == id).Include(p => p.User).FirstOrDefaultAsync();
            
            if (project == null)
            {
                return NotFound();
            }

            return project.AsDto();
        }

        // PUT: api/Projects/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProject(Guid id, UpdateProjectDto projectDto)
        {
            var project = await _context.Project.FindAsync(id);
            var user = await _context.User.FindAsync(projectDto.UserId);

            if (project == null)
            {
                return NotFound();
            }

            _context.Entry(project).State = EntityState.Modified;

            try
            {
                project.Name = projectDto.Name;
                project.User = user;

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Projects
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProjectDto>> PostProject(CreateProjectDto projectDto)
        {
            var user = await _context.User.FindAsync(projectDto.UserId);

            if (user == null)
            {
                return NotFound("User not found");
            }

            Project project = new()
            {
                Name = projectDto.Name,
                User = user,
            };
             
            _context.Project.Add(project);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProject", new { id = project.Id }, project);
        }

        // DELETE: api/Projects/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProject(Guid id)
        {
            var project = await _context.Project.FindAsync(id);
            if (project == null)
            {
                return NotFound();
            }

            _context.Project.Remove(project);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProjectExists(Guid id)
        {
            return _context.Project.Any(e => e.Id == id);
        }
    }
}
