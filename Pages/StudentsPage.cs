using Music_School_DB.Domain.Party;
using Music_School_DB.Facade.Party;

namespace Music_School_DB.Pages
{
    public class StudentsPage : BasePage<StudentView, Student, IStudentRepo>
    {
        public StudentsPage(IStudentRepo r) : base(r) { }
        protected override Student toObject(StudentView? item) => new StudentViewFactory().Create(item);
        protected override StudentView toView(Student? entity) => new StudentViewFactory().Create(entity);
    }
}
