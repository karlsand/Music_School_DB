using Microsoft.AspNetCore.Mvc.Rendering;
using Music_School_DB.Domain.Party;
using Music_School_DB.Facade.Party;

namespace Music_School_DB.Pages.Party
{
    public class InstructorsPage : PagedPage<InstructorView, Instructor, IInstructorsRepo>
    {
        private readonly ICountriesRepo countries;
        public InstructorsPage(IInstructorsRepo r, ICountriesRepo c) : base(r) => countries = c;
        protected override Instructor toObject(InstructorView? item) => new InstructorViewFactory().Create(item);
        protected override InstructorView toView(Instructor? entity) => new InstructorViewFactory().Create(entity);
        public override string[] IndexColumns { get; } = new[] {
            nameof(InstructorView.ID),
            nameof(InstructorView.InstrumentID),
            nameof(InstructorView.FirstName),
            nameof(InstructorView.LastName),
            nameof(InstructorView.Email),
            nameof(InstructorView.PhoneNr),
            nameof(InstructorView.CoBID)
        };
        public IEnumerable<SelectListItem> Countries
            => countries?.GetAll(x => x.Name)?.Select(x => new SelectListItem(x.Name, x.ID)) ?? new List<SelectListItem>();
        public string CountryName(string? countryID = null)
            => Countries?.FirstOrDefault(x => x.Value == (countryID ?? string.Empty))?.Text ?? "Unspecified";
        public override object? GetValue(string name, InstructorView v)
        {
            var r = base.GetValue(name, v);
            return name == nameof(InstructorView.CoBID) ? CountryName(r as string) : r;
        }
    }
}