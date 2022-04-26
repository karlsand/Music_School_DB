using Music_School_DB.Domain.Party;
using Music_School_DB.Facade.Party;

namespace Music_School_DB.Pages.Party
{
    public class StudentsPage : PagedPage<StudentView, Student, IStudentRepo>
    {
        public StudentsPage(IStudentRepo r) : base(r) { }
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
        };
    }
}
