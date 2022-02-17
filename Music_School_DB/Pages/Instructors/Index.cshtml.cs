#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Music_School_DB.Data;

namespace Music_School_DB.Pages.Instructors
{
    public class IndexModel : PageModel
    {
        private readonly Music_School_DB.Data.Music_School_DBContext _context;

        public IndexModel(Music_School_DB.Data.Music_School_DBContext context)
        {
            _context = context;
        }

        public IList<Instructor> Instructor { get;set; }

        public async Task OnGetAsync()
        {
            Instructor = await _context.Instructor.ToListAsync();
        }
    }
}
