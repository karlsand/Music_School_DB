using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Music_School_DB.Facade.Party
{
    public sealed class StudentView : UniqueView
    {
        [DisplayName("Instrument ID")] public string? InstrumentID { get; set; }
        [DisplayName("Instructor ID")] [Required] public string? InstructorID { get; set; }
        [DisplayName("First name")] [Required] public string? FirstName { get; set; }
        [DisplayName("Last name")] [Required] public string? LastName { get; set; }
        [DisplayName("Email")] [Required] public string? Email { get; set; }
        [DisplayName("Phone number")] [Required] public string? PhoneNr { get; set; }
    }
    public sealed class StudentViewFactory : BaseViewFactory<StudentView, Student, StudentData>
    {
        protected override Student toEntity(StudentData d) => new(d);
    }
}
