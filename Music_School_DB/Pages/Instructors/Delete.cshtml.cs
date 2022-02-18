#nullable disable
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Music_School_DB.Domain.Party;
using Music_School_DB.Facade.Party;

namespace Music_School_DB.Pages.Instructors
{
    public class DeleteModel : PageModel
    {
        private readonly Music_School_DB.Data.Music_School_DBContext _context;

        public DeleteModel(Music_School_DB.Data.Music_School_DBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public InstructorView Instructor { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var d = await _context.Instructors.FirstOrDefaultAsync(m => m.ID == id);
            Instructor = new InstructorViewFactory().Create(new Instructor(d));

            if (Instructor == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var d = await _context.Instructors.FindAsync(id);

            if (d != null)
            {
                _context.Instructors.Remove(d);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
