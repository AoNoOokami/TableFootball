using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TableFootball.Models
{
    public class TeamEnrollment
    {
        public int TeamEnrollmentID { get; set; }
        [Required]
        public int PlayerID { get; set; }
        [Required]
        public int TeamID { get; set; }

        public Player Player { get; set; }
        public Team Team { get; set; }
    }
}
