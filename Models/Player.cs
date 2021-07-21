using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TableFootball.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<TeamEnrollment> Enrollments { get; set; }
    }
}
