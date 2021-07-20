using System.Collections.Generic;

namespace TableFootball.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string Name { get; set; }
        public ICollection<TeamEnrollment> Enrollments { get; set; }
    }
}
