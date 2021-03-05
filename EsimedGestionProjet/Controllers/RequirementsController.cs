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
    public class RequirementsController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public RequirementsController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Requirements
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RequirementDto>>> GetRequirement()
        {
            return await _context.Requirement.Include(r => r.Project).Select(r => r.AsDto()).ToListAsync();
        }

        // GET: api/Requirements/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RequirementDto>> GetRequirement(Guid id)
        {
            var requirement = await _context.Requirement.Where(r=> r.Id == id).Include(r => r.Project).FirstOrDefaultAsync();

            if (requirement == null)
            {
                return NotFound();
            }

            return requirement.AsDto();
        }

        // PUT: api/Requirements/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRequirement(Guid id, UpdateRequirementDto requirementDto)
        {
            var requirement = await _context.Requirement.FindAsync(id);

            if (requirement == null)
            {
                return BadRequest();
            }

            _context.Entry(requirement).State = EntityState.Modified;

            try
            {
                requirement.Description = requirementDto.Description;
                requirement.RequirementNoneFunctional = requirementDto.RequirementNoneFunctional;
                requirement.IsFunctional = requirementDto.IsFunctional;

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RequirementExists(id))
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

        // POST: api/Requirements
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RequirementDto>> PostRequirement(CreateRequirementDto requirementDto)
        {
            var project = await _context.Project.FindAsync(requirementDto.Project);

            if (project == null)
            {
                return NotFound("Project not found");
            }

            Requirement requirement = new()
            {
                Project = project,
                Description = requirementDto.Description,
                IsFunctional = requirementDto.IsFunctional,
                RequirementNoneFunctional = requirementDto.RequirementNoneFunctional
            };

            _context.Requirement.Add(requirement);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRequirement", new { id = requirement.Id }, requirement.AsDto());
        }

        // DELETE: api/Requirements/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRequirement(Guid id)
        {
            var requirement = await _context.Requirement.FindAsync(id);
            if (requirement == null)
            {
                return NotFound();
            }

            _context.Requirement.Remove(requirement);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RequirementExists(Guid id)
        {
            return _context.Requirement.Any(e => e.Id == id);
        }
    }
}
