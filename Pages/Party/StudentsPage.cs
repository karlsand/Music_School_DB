using Microsoft.AspNetCore.Mvc.Rendering;
using Music_School_DB.Domain.Party;
using Music_School_DB.Facade.Party;

namespace Music_School_DB.Pages.Party
{
    public class StudentsPage : PagedPage<StudentView, Student, IStudentRepo>
    {
        private readonly ICountriesRepo countries;
        public StudentsPage(IStudentRepo r, ICountriesRepo c) : base(r) => countries = c;
        protected override Student toObject(StudentView? item) => new StudentViewFactory().Create(item);
        protected override StudentView toView(Student? entity) => new StudentViewFactory().Create(entity);
        public override string[] IndexColumns { get; } = new[] {
            nameof(StudentView.ID),
            nameof(StudentView.InstrumentID),
            nameof(StudentView.InstructorID),
            nameof(StudentView.FirstName),
            nameof(StudentView.LastName),
            nameof(StudentView.Email),
            nameof(StudentView.PhoneNr),
            nameof(StudentView.CoB),
        };
        public IEnumerable<SelectListItem> Countries 
            => countries?.GetAll(x => x.Name)?.Select(x => new SelectListItem(x.Name, x.ID)) ?? new List<SelectListItem>();
        public string CountryName(string? countryID = null)
            => Countries?.FirstOrDefault(x => x.Value == (countryID ?? string.Empty))?.Text ?? "Unspecified";
        public override object? GetValue(string name, StudentView v)
        {
            var r = base.GetValue(name, v);
            return name == nameof(StudentView.CoB) ? CountryName(r as string) : r;
        }
    }
}