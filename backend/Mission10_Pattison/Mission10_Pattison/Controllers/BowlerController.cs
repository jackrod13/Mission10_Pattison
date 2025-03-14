using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission10_Pattison.Data;

namespace Mission10_Pattison.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private readonly BowlerDbContext _context;

        // Constructor to inject the database context
        public BowlerController(BowlerDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetBowlers()
        {
            // Fetch bowlers who belong to teams with ID 1 or 2, including their team data
            var bowlers = _context.Bowlers
                .Include(b => b.Team)
                .Where(b => b.TeamID == 1 || b.TeamID == 2)
                .Select(b => new
                {
                    bowlerID = b.BowlerID,
                    bowlerName = b.BowlerFirstName + " " + (b.BowlerMiddleInit ?? "") + " " + b.BowlerLastName,
                    teamName = b.Team != null ? b.Team.TeamName : "No Team",
                    bowlerAddress = b.BowlerAddress,
                    bowlerCity = b.BowlerCity,
                    bowlerState = b.BowlerState,
                    bowlerZip = b.BowlerZip,
                    bowlerPhoneNumber = b.BowlerPhoneNumber
                })
                .ToList();

            return Ok(bowlers); // Return the filtered list of bowlers as JSON
        }
    }
}
