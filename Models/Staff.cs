using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public class Staff
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter staff name.")]
        public string? Name { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter Date of birth.")]
        public DateTime DOB {get; set;}
        public double Salary {get; set;}
        [DataType(DataType.Date)]
        [Display(Name ="Hire Date")]
        public DateTime HireDate {get; set;}
        
        public int? CourseId { get; set; }
        public Course? Course { get; set; }
         
    }
}