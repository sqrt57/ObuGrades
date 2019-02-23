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
    public class IndexModel : PageModel
    {
        private readonly ObuGrades.Data.ApplicationDbContext _context;

        public IndexModel(ObuGrades.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Grade> Grade { get;set; }

        public async Task OnGetAsync()
        {
            Grade = await _context.Grade.ToListAsync();
        }
    }
}
