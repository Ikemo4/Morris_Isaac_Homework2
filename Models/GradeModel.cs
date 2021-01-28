using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Morris_Isaac_Homework2.Models
{
    public class GradeModel
    {
        [Required]
        [Range(0, 100)]
        public int Asgmt { get; set; }
        [Required]
        [Range(0, 100)]
        public int Groupproject { get; set; }
        [Required]
        [Range(0, 100)]
        public int Quiz { get; set; }
        [Required]
        [Range(0, 100)]
        public int Exam { get; set; }
        [Required]
        [Range(0, 100)]
        public int Intex { get; set; }
    }
}
