using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IssuesTrackingSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IssuesTrackingSystem.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class IssuesController : ControllerBase
    {
        private readonly IssueContext _context;

        public IssuesController(IssueContext context)
        {
            _context = context;       
        }


        /// <summary>
        /// Get all issues
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Issue>>> GetIssues()
        {
            return await _context.Issues.ToListAsync();
        }

        /// <summary>
        /// Get specific issue with id(Guid) parameter
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Issue>> GetIssueItem(long id)
        {
            var issueItem = await _context.Issues.FindAsync(id);

            if (issueItem == null)
            {
                return NotFound();
            }

            return issueItem;
        }

        /// <summary>
        /// Post a new issue
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /issues
        ///     {
        ///        "userPC": "Isabelle-PC",
        ///        "title": "Broken mouse",
        ///        "description": "The mouse is broken",
        ///        "priority": 3,
        ///        "isComplete": true
        ///     }
        ///
        /// </remarks>
        /// <param name="issue"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Issue>> PostIssueItem(Issue issue)
        {
            _context.Issues.Add(issue);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetIssueItem), new { id = issue.Id }, issue);
        }


        /// <summary>
        /// Update an issue with id(Guid) parameter
        /// </summary>
        /// <param name="id"></param>
        /// <param name="issue"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIssueItem(Guid id, Issue issue)
        {
            if (id != issue.Id)
            {
                return BadRequest();
            }

            _context.Entry(issue).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }


        /// <summary>
        /// Delete a specific issue with id(Guid) parameter
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIssueItem(Guid id)
        {
            var issueItem = await _context.Issues.FindAsync(id);

            if (issueItem == null)
            {
                return NotFound();
            }

            _context.Issues.Remove(issueItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
