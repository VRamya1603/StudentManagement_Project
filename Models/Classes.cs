using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public class Classes
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter course name.")]
        public string? ClassName { get; set; }
    
        public int CourseId {get; set;}
        public Course? Course {get; set;}
    }
}