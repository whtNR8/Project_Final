using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Students
    {
        [Key]
        [Required]
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]
        public int StudentAge { get; set; }
        [Required]
        public string StudentCareer { get; set; }
        [Required]
        public int StudentSemester { get; set; }



    }
}
