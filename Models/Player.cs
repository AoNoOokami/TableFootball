using System;
using System.Collections.Generic;

namespace TableFootball.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string Name { get; set; }
        public ICollection<TeamEnrollment> Enrollments { get; set; }
    }
}
