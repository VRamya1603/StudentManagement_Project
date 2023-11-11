using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [Required(ErrorMessage = "Please enter course name.")]
        public string? CourseName { get; set; }
        [Required(ErrorMessage = "Please enter fees.")]
        public double Fees {get; set;}

        // 1 to many 
        public ICollection<Student>? Students { get; set; }
        public ICollection<Staff>? Staff {get; set;}
        // 1 to 1
        public Classes? Classes {get; set;}
        
    }
}