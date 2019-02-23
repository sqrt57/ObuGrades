using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ObuGrades.Data;
using ObuGrades.Models;

namespace ObuGrades.Pages.Grades
{
    public class DetailsModel : PageModel
    {
        private readonly ObuGrades.Data.ApplicationDbContext _context;

        public DetailsModel(ObuGrades.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Grade Grade { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Grade = await _context.Grade.FirstOrDefaultAsync(m => m.ID == id);

            if (Grade == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
