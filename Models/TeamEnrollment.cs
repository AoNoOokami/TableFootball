using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TableFootball.Models
{
    public class TeamEnrollment
    {
        public int TeamEnrollmentID { get; set; }
        public int PlayerID { get; set; }
        public int TeamID { get; set; }

        public Player Player { get; set; }
        public Team Team { get; set; }
    }
}
