using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Mission10_Pattison.Data
{
    public class Team
    {
        [Key] // Primary key for the Team entity
        public int TeamID { get; set; }

        public string TeamName { get; set; } = string.Empty; // Team name, defaulting to an empty string

        public int? CaptainID { get; set; }  // Nullable ID of the team captain

        public List<Bowler>? Bowlers { get; set; } // List of bowlers associated with the team
    }
}
