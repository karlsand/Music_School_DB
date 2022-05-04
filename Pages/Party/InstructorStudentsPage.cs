using Microsoft.AspNetCore.Mvc.Rendering;
using Music_School_DB.Domain.Party;
using Music_School_DB.Facade.Party;

namespace Music_School_DB.Pages.Party
{
    public class InstructorStudentsPage : PagedPage<InstructorStudentsView, InstructorStudents, IInstructorStudentsRepo>
    {
        private readonly IInstructorsRepo instructors;
        private readonly IStudentsRepo students;
        public InstructorStudentsPage(IInstructorStudentsRepo r, IInstructorsRepo i, IStudentsRepo s) : base(r)
        {
            instructors = i;
            students = s;
        }
        protected override InstructorStudents toObject(InstructorStudentsView? item) => new InstructorStudentsViewFactory().Create(item);
        protected override InstructorStudentsView toView(InstructorStudents? entity) => new InstructorStudentsViewFactory().Create(entity);
        public override string[] IndexColumns { get; } = new[] {
            nameof(InstructorStudentsView.ID),
            nameof(InstructorStudentsView.Code),
            nameof(InstructorStudentsView.Name),
            nameof(InstructorStudentsView.InstructorID),
            nameof(InstructorStudentsView.StudentID),
            nameof(InstructorStudentsView.Description),
        };
        public IEnumerable<SelectListItem> Instructors
            => instructors?.GetAll(x => x.ToString())?.Select(x => new SelectListItem(x.ToString(), x.ID)) ?? new List<SelectListItem>();
        public IEnumerable<SelectListItem> Students
            => students?.GetAll(x => x.ToString())?.Select(x => new SelectListItem(x.ToString(), x.ID)) ?? new List<SelectListItem>();
        public string InstructorName(string? instructorID = null)
            => Instructors?.FirstOrDefault(x => x.Value == (instructorID ?? string.Empty))?.Text ?? "Unspecified";
        public string StudentName(string? studentID = null)
            => Students?.FirstOrDefault(x => x.Value == (studentID ?? string.Empty))?.Text ?? "Unspecified";
        public override object? GetValue(string name, InstructorStudentsView v)
        {
            var r = base.GetValue(name, v);
            return name == nameof(InstructorStudentsView.InstructorID) ? InstructorName(r as string) 
                : name == nameof(InstructorStudentsView.StudentID) ? StudentName(r as string)
                : r;
        }
    }
}