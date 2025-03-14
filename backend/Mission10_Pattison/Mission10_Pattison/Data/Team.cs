using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Mission10_Pattison.Data
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }

        public string TeamName { get; set; } = string.Empty;

        public int? CaptainID { get; set; }  
        public List<Bowler>? Bowlers { get; set; }
    }
}
