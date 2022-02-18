#nullable disable
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Music_School_DB.Data;
using Music_School_DB.Domain.Party;
using Music_School_DB.Facade.Party;

namespace Music_School_DB.Pages.Instructors
{
    public class IndexModel : PageModel
    {
        private readonly Music_School_DBContext _context;

        public IndexModel(Music_School_DBContext context)
        {
            _context = context;
        }

        public IList<InstructorView> Instructors { get;set; }

        public async Task OnGetAsync()
        {
            var list = await _context.Instructors.ToListAsync();
            Instructors = new List<InstructorView>();
            foreach (var d in list)
            {
                var v = new InstructorViewFactory().Create(new Instructor(d));
                Instructors.Add(v);
            }
        }
    }
}
