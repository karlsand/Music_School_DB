using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Music_School_DB.Domain.Party;
using Music_School_DB.Facade.Party;

namespace Music_School_DB.Pages.Instructors
{
    public class InstructrosPage : PageModel
    {
        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.

        private readonly Data.Music_School_DBContext context;

        [BindProperty]
        public InstructorView Instructor { get; set; }

        public IList<InstructorView> Instructors { get; set; }

        public InstructrosPage(Data.Music_School_DBContext c)
        {
            context = c;
        }

        public IActionResult OnGetCreate()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostCreateAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var d = new InstructorViewFactory().Create(Instructor).Data;

            context.Instructors.Add(d);
            await context.SaveChangesAsync();

            return RedirectToPage("./Index", "Index");
        }

        public async Task<IActionResult> OnGetDetailsAsync(string id)
        {
            Instructor = await getInstructor(id);

            return Instructor == null ? NotFound() : Page();
        }

        private async Task<InstructorView> getInstructor(string id)
        {
            if (id == null)
            {
                return null;
            }

            var d = await context.Instructors.FirstOrDefaultAsync(m => m.ID == id);

            if (d == null)
            {
                return null;
            }

            return new InstructorViewFactory().Create(new Instructor(d));
        }

        public async Task<IActionResult> OnGetDeleteAsync(string id)
        {
            Instructor = await getInstructor(id);

            return Instructor == null ? NotFound() : Page();
        }

        public async Task<IActionResult> OnPostDeleteAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var d = await context.Instructors.FindAsync(id);

            if (d != null)
            {
                context.Instructors.Remove(d);
                await context.SaveChangesAsync();
            }

            return RedirectToPage("./Index", "Index");
        }

        public async Task<IActionResult> OnGetEditAsync(string id)
        {
            Instructor = await getInstructor(id);

            return Instructor == null ? NotFound() : Page();
        }

        public async Task<IActionResult> OnPostEditAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var d = new InstructorViewFactory().Create(Instructor).Data;

            context.Attach(d).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!instructorExists(Instructor.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index", "Index");
        }

        private bool instructorExists(string id)
        {
            return context.Instructors.Any(e => e.ID == id);
        }

        public async Task OnGetIndexAsync()
        {
            var list = await context.Instructors.ToListAsync();
            Instructors = new List<InstructorView>();
            foreach (var d in list)
            {
                var v = new InstructorViewFactory().Create(new Instructor(d));
                Instructors.Add(v);
            }
        }
    }
}
