using Music_School_DB.Domain.Party;
using Music_School_DB.Facade.Party;

namespace Music_School_DB.Pages.Party
{
    public class InstructrosPage : PagedPage<InstructorView, Instructor, IInstructorsRepo>
    {
        public InstructrosPage(IInstructorsRepo r) : base(r) { }
        protected override Instructor toObject(InstructorView? item) => new InstructorViewFactory().Create(item);
        protected override InstructorView toView(Instructor? entity) => new InstructorViewFactory().Create(entity);
        public override string[] IndexColumns { get; } = new[] {
            nameof(InstructorView.ID),
            nameof(InstructorView.InstrumentID),
            nameof(InstructorView.FirstName),
            nameof(InstructorView.LastName),
            nameof(InstructorView.Email),
            nameof(InstructorView.PhoneNr),
        };
    }
}
