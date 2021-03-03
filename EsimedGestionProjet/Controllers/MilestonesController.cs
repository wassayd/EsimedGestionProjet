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
    public class MilestonesController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public MilestonesController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Milestones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MilestoneDto>>> GetMilestone()
        {       
            return await _context.Milestone
                .Select(m => m.AsDto())
                .ToListAsync();
        }

        [HttpGet("project/{id}")]
        public async Task<ActionResult<IEnumerable<MilestoneDto>>> GetMilestoneByProject(Guid projectId)
        {
            return await _context.Milestone
                .Where(m => m.Project.Id == projectId)
                .Select(m => m.AsDto())
                .ToListAsync();
        }

        // GET: api/Milestones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MilestoneDto>> GetMilestone(Guid id)
        {
            var milestone = await _context.Milestone.FindAsync(id);

            if (milestone == null)
            {
                return NotFound();
            }

            return milestone.AsDto();
        }

        // PUT: api/Milestones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMilestone(Guid id, UpdateMilestoneDto milestoneDto)
        {
            var milestone = await _context.Milestone.FindAsync(id);
            var user = await _context.User.FindAsync(milestoneDto.UserId);
            var project = await _context.Project.FindAsync(milestoneDto.ProjectId);

            if (milestone == null)
            {
                return NotFound("Milestone not found");
            }

            if (user == null)
            {
                return NotFound("User not found");
            }

            if (project == null)
            {
                return NotFound("Project not found");
            }

            if (id != milestone.Id)
            {
                return BadRequest();
            }

            _context.Entry(milestone).State = EntityState.Modified;

            try
            {
                milestone.Label = milestoneDto.Label;
                milestone.User = user;
                milestone.Project = project;
                milestone.DeleveryDateEstimated = milestoneDto.DeleveryDateEstimated;
               
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MilestoneExists(id))
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

        // POST: api/Milestones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MilestoneDto>> PostMilestone(CreateMilestoneDto milestoneDto)
        {
            var user = await _context.User.FindAsync(milestoneDto.UserId);
            var project = await _context.Project.FindAsync(milestoneDto.ProjectId);

            if (user == null)
            {
                NotFound("User not found");
            }

            if (project == null)
            {
                NotFound("project not found");
            }

            Milestone milestone = new()
            {
                Label = milestoneDto.Label,
                DeleveryDateEstimated = milestoneDto.DeleveryDateEstimated,
                Project = project,
                User = user
            };

            _context.Milestone.Add(milestone);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMilestone", new { id = milestone.Id }, milestone.AsDto());
        }

        // DELETE: api/Milestones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMilestone(Guid id)
        {
            var milestone = await _context.Milestone.FindAsync(id);
            if (milestone == null)
            {
                return NotFound();
            }

            _context.Milestone.Remove(milestone);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MilestoneExists(Guid id)
        {
            return _context.Milestone.Any(e => e.Id == id);
        }
    }
}
