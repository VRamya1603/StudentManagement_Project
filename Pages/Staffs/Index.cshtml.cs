using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;
using StudentSystem.Data;

namespace StudentManagement.Pages_Staffs
{
    public class IndexModel : PageModel
    {
        private readonly StudentSystem.Data.AppDbContext _context;

        public IndexModel(StudentSystem.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Staff != null)
            {
                Staff = await _context.Staff
                .Include(s => s.Course).ToListAsync();
            }
        }
    }
}
