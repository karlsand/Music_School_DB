using Music_School_DB.Domain.Party;
using Music_School_DB.Facade.Party;

namespace Music_School_DB.Pages
{
    public class InstructrosPage : BasePage<InstructorView, Instructor, IInstructorsRepo>
    {
        public InstructrosPage(IInstructorsRepo r) : base(r) { }
        protected override Instructor toObject(InstructorView? item) => new InstructorViewFactory().Create(item);
        protected override InstructorView toView(Instructor? entity) => new InstructorViewFactory().Create(entity);
    }
}
