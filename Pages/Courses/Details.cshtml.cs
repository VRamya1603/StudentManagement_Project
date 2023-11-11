using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;
using StudentSystem.Data;

namespace StudentManagement.Pages_Courses
{
    public class DetailsModel : PageModel
    {
        private readonly StudentSystem.Data.AppDbContext _context;

        public DetailsModel(StudentSystem.Data.AppDbContext context)
        {
            _context = context;
        }

      public Course Course { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            Course = await _context.Course.Include(c => c.Students).Include(c => c.Staff).FirstOrDefaultAsync(c => c.CourseId == id);
            if(Course == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
