using Microsoft.AspNetCore.Mvc.Rendering;
using Music_School_DB.Domain.Party;
using Music_School_DB.Facade.Party;

namespace Music_School_DB.Pages.Party
{
    public class InstructorStudentsPage : PagedPage<InstructorStudentView, InstructorStudent, IInstructorStudentsRepo>
    {
        private readonly IInstructorsRepo instructors;
        private readonly IStudentsRepo students;
        public InstructorStudentsPage(IInstructorStudentsRepo r, IInstructorsRepo i, IStudentsRepo s) : base(r)
        {
            instructors = i;
            students = s;
        }
        protected override InstructorStudent toObject(InstructorStudentView? item) => new InstructorStudentViewFactory().Create(item);
        protected override InstructorStudentView toView(InstructorStudent? entity) => new InstructorStudentViewFactory().Create(entity);
        public override string[] IndexColumns { get; } = new[] {
            nameof(InstructorStudentView.ID),
            nameof(InstructorStudentView.Code),
            nameof(InstructorStudentView.Name),
            nameof(InstructorStudentView.InstructorID),
            nameof(InstructorStudentView.StudentID),
            nameof(InstructorStudentView.Description)
        };
        public IEnumerable<SelectListItem> Instructors
            => instructors?.GetAll(x => x.ToString())?.Select(x => new SelectListItem(x.ToString(), x.ID)) ?? new List<SelectListItem>();
        public IEnumerable<SelectListItem> Students
            => students?.GetAll(x => x.ToString())?.Select(x => new SelectListItem(x.ToString(), x.ID)) ?? new List<SelectListItem>();
        public string InstructorName(string? instructorID = null)
            => Instructors?.FirstOrDefault(x => x.Value == (instructorID ?? string.Empty))?.Text ?? "Unspecified";
        public string StudentName(string? studentID = null)
            => Students?.FirstOrDefault(x => x.Value == (studentID ?? string.Empty))?.Text ?? "Unspecified";
        public override object? GetValue(string name, InstructorStudentView v)
        {
            var r = base.GetValue(name, v);
            return name == nameof(InstructorStudentView.InstructorID) ? InstructorName(r as string) 
                : name == nameof(InstructorStudentView.StudentID) ? StudentName(r as string)
                : r;
        }
    }
}