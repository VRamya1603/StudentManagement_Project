using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentManagement.Models;
using StudentSystem.Data;

namespace StudentManagement.Pages_Classes
{
    public class CreateModel : PageModel
    {
        private readonly StudentSystem.Data.AppDbContext _context;

        public CreateModel(StudentSystem.Data.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "CourseName");
            return Page();
        }

        [BindProperty]
        public Classes Classes { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Classes == null || Classes == null)
            {
                return Page();
            }

            _context.Classes.Add(Classes);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
