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
    public class TasksController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public TasksController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Tasks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskDto>>> GetTask()
        {
            return await _context.Task.Include(t => t.Project)
                .Include(t => t.Milestone)
                .Include(t => t.Project)
                .Include(t => t.User)
                .Select(x => x.AsDto()).ToListAsync();
        }

        // GET: api/Tasks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskDto>> GetTask(Guid id)
        {
            var task = await _context.Task.Where(t => t.Id == id)
                .Include(t => t.Milestone)
                .Include(t => t.Project)
                .Include(t => t.User)
                .FirstOrDefaultAsync();

            if (task == null)
            {
                return NotFound();
            }

            return task.AsDto();
        }

        // PUT: api/Tasks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTask(Guid id, UpdateTaskDto taskDto)
        {
            var task = await _context.Task.FindAsync(id);

            var user = await _context.User.FindAsync(taskDto.UserId);
            var milestone = await _context.Milestone.FindAsync(taskDto.Milestone);

            var requirements = new List<Requirement>();

            foreach (var requirementId in taskDto.Requirements)
            {
                var requirement = await _context.Requirement.FindAsync(requirementId);
                requirements.Add(requirement);
            }

            if (task == null)
            {
                return NotFound("task not found");
            }

            _context.Entry(task).State = EntityState.Modified;

            try
            {
                task.Label = taskDto.Label;
                task.Description = taskDto.Description;
                task.User = user;
                task.Requirements = requirements;
                task.TheoricDateStart = taskDto.TheoricDateStart;
                task.NbDay = taskDto.NbDay;
                task.Milestone = milestone;

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskExists(id))
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

        // POST: api/Tasks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TaskDto>> PostTask(CreateTaskDto taskDto)
        {
            var user = await _context.User.FindAsync(taskDto.UserId);
            var project = await _context.Project.FindAsync(taskDto.Project);

            if (user == null)
            {
                return NotFound("User not found");
            }

            if (project == null)
            {
                return NotFound("Project not found");
            }

            var milestone = await _context.Milestone.FindAsync(taskDto.Milestone);
            var requirements = new List<Requirement>();

            if (taskDto.Requirements.Count > 0)
            {
                foreach (var requirementId in taskDto.Requirements)
                {
                    var requirement = await _context.Requirement.FindAsync(requirementId);
                    requirements.Add(requirement);
                }
            }
            

            Models.Task task = new()
            {
                Label = taskDto.Label,
                Description = taskDto.Description,
                User = user,
                Requirements = requirements,
                TheoricDateStart = taskDto.TheoricDateStart,
                NbDay = taskDto.NbDay,
                Project = project,
                Milestone = milestone
            };
            _context.Task.Add(task);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTask", new { id = task.Id }, task.AsDto());
        }

        // DELETE: api/Tasks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(Guid id)
        {
            var task = await _context.Task.FindAsync(id);
            if (task == null)
            {
                return NotFound();
            }

            _context.Task.Remove(task);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TaskExists(Guid id)
        {
            return _context.Task.Any(e => e.Id == id);
        }
    }
}
