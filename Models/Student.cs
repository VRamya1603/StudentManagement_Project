using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter student name.")]
        public string? Name { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter date of birth.")]
        [Display(Name = "Date Of Birth")]
        public DateTime DOB { get; set; }
        [Display(Name ="Blood Group")]
        public string? BloodGroup{get; set;}
        [Required]
        public string? Gender{get; set;}

        public int? CourseId { get; set; }
        public Course? Course { get; set; }

    }
}