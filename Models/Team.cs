using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TableFootball.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        [Required]
        public string Name { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }

        public ICollection<TeamEnrollment> Enrollments { get; set; }
    }
}
