#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Music_School_DB.Data;
using Music_School_DB.Domain.Party;
using Music_School_DB.Facade.Party;

namespace Music_School_DB.Pages.Instructors
{
    public class DetailsModel : PageModel
    {
        private readonly Music_School_DB.Data.Music_School_DBContext _context;

        public DetailsModel(Music_School_DB.Data.Music_School_DBContext context)
        {
            _context = context;
        }

        public InstructorView Instructor { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var d = await _context.Instructors.FirstOrDefaultAsync(m => m.ID == id);

            if (d == null)
            {
                return NotFound();
            }

            Instructor = new InstructorViewFactory().Create(new Instructor(d));

            return Page();
        }
    }
}
