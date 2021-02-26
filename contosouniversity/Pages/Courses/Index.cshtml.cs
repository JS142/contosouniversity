using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Models;
using contosouniversity.Data;

namespace contosouniversity.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly contosouniversity.Data.contosouniversityContext _context;

        public IndexModel(contosouniversity.Data.contosouniversityContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; }

        public async Task OnGetAsync()
        {
            Course = await _context.Course.ToListAsync();
        }
    }
}
