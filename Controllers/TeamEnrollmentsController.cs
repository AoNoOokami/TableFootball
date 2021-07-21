using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TableFootball.Data;
using TableFootball.Models;

namespace TableFootball.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamEnrollmentsController : ControllerBase
    {
        private readonly TableFootballContext _context;

        public TeamEnrollmentsController(TableFootballContext context)
        {
            _context = context;
        }

        // GET: api/TeamEnrollments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamEnrollment>>> GetTeamEnrollments()
        {
            return await _context.TeamEnrollments.ToListAsync();
        }

        // GET: api/TeamEnrollments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamEnrollment>> GetTeamEnrollment(int id)
        {
            var teamEnrollment = await _context.TeamEnrollments.FindAsync(id);

            if (teamEnrollment == null)
            {
                return NotFound();
            }

            return teamEnrollment;
        }

        // PUT: api/TeamEnrollments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeamEnrollment(int id, TeamEnrollment teamEnrollment)
        {
            if (id != teamEnrollment.TeamEnrollmentID)
            {
                return BadRequest();
            }

            _context.Entry(teamEnrollment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamEnrollmentExists(id))
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

        // POST: api/TeamEnrollments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TeamEnrollment>> PostTeamEnrollment(TeamEnrollment teamEnrollment)
        {
            _context.TeamEnrollments.Add(teamEnrollment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTeamEnrollment", new { id = teamEnrollment.TeamEnrollmentID }, teamEnrollment);
        }

        // DELETE: api/TeamEnrollments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeamEnrollment(int id)
        {
            var teamEnrollment = await _context.TeamEnrollments.FindAsync(id);
            if (teamEnrollment == null)
            {
                return NotFound();
            }

            _context.TeamEnrollments.Remove(teamEnrollment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TeamEnrollmentExists(int id)
        {
            return _context.TeamEnrollments.Any(e => e.TeamEnrollmentID == id);
        }
    }
}
