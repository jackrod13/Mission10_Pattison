using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission10_Pattison.Data
{
    public class Bowler
    {
        [Key] // Primary key for the Bowler entity
        public int BowlerID { get; set; }

        // Bowler personal details (nullable)
        public string? BowlerLastName { get; set; }
        public string? BowlerFirstName { get; set; }
        public string? BowlerMiddleInit { get; set; }
        public string? BowlerAddress { get; set; }
        public string? BowlerCity { get; set; }
        public string? BowlerState { get; set; }
        public string? BowlerZip { get; set; }
        public string? BowlerPhoneNumber { get; set; }

        // Foreign key reference to Team
        public int? TeamID { get; set; }
        [ForeignKey("TeamID")]
        public Team? Team { get; set; } // Navigation property to access related Team
    }
}
