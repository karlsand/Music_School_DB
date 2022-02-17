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
    public class DetailsModel : PageModel
    {
        private readonly Music_School_DB.Data.Music_School_DBContext _context;

        public DetailsModel(Music_School_DB.Data.Music_School_DBContext context)
        {
            _context = context;
        }

        public Instructor Instructor { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Instructor = await _context.Instructor.FirstOrDefaultAsync(m => m.ID == id);

            if (Instructor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
