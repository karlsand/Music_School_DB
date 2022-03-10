using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Music_School_DB.Data;
using Music_School_DB.Domain.Party;
using Music_School_DB.Facade.Party;
using Music_School_DB.Infra.Party;

namespace Music_School_DB.Pages.Instructors
{
    public class InstructrosPage : PageModel
    {
        private readonly IInstructorsRepo repo;
        [BindProperty]
        public InstructorView Instructor { get; set; }
        public IList<InstructorView> Instructors { get; set; }
        public InstructrosPage(Music_School_DBContext c) => repo = new InstructorsRepo(c, c.Instructors);
        public IActionResult OnGetCreate() => Page();
        public async Task<IActionResult> OnPostCreateAsync()
        {
            if (!ModelState.IsValid) return Page();
            await repo.AddAsync(new InstructorViewFactory().Create(Instructor));
            return RedirectToPage("./Index", "Index");
        }
        public async Task<IActionResult> OnGetDetailsAsync(string id)
        {
            Instructor = await getInstructor(id);
            return Instructor == null ? NotFound() : Page();
        }
        public async Task<IActionResult> OnGetDeleteAsync(string id)
        {
            Instructor = await getInstructor(id);
            return Instructor == null ? NotFound() : Page();
        }
        public async Task<IActionResult> OnPostDeleteAsync(string id)
        {
            if (id == null) return NotFound();
            await repo.DeleteAsync(id);
            return RedirectToPage("./Index", "Index");
        }
        public async Task<IActionResult> OnGetEditAsync(string id)
        {
            Instructor = await getInstructor(id);
            return Instructor == null ? NotFound() : Page();
        }
        public async Task<IActionResult> OnPostEditAsync()
        {
            if (!ModelState.IsValid) return Page();
            var obj = new InstructorViewFactory().Create(Instructor);
            var updated = await repo.UpdateAsync(obj);
            if (!updated) NotFound();
            return RedirectToPage("./Index", "Index");
        }
        public async Task<IActionResult> OnGetIndexAsync()
        {
            var list = await repo.GetAsync();
            Instructors = new List<InstructorView>();
            foreach (var obj in list)
            {
                var v = new InstructorViewFactory().Create(obj);
                Instructors.Add(v);
            }
            return Page();
        }
        private async Task<InstructorView> getInstructor(string id) => new InstructorViewFactory().Create(await repo.GetAsync(id));
    }
}
