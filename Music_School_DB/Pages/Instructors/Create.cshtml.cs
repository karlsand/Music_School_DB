﻿#nullable disable
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Music_School_DB.Facade.Party;

namespace Music_School_DB.Pages.Instructors
{
    public class CreateModel : PageModel
    {
        private readonly Music_School_DB.Data.Music_School_DBContext _context;

        public CreateModel(Music_School_DB.Data.Music_School_DBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public InstructorView Instructor { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var d = new InstructorViewFactory().Create(Instructor).Data;

            _context.Instructors.Add(d);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
