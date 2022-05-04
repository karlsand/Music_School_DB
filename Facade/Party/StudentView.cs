using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Music_School_DB.Facade.Party
{
    public sealed class StudentView : UniqueView
    {
        [Required][DisplayName("Instrument ID")] public string? InstrumentID { get; set; }
        [Required][DisplayName("Instructor ID")] public string? InstructorID { get; set; }
        [Required][DisplayName("First name")] public string? FirstName { get; set; }
        [Required][DisplayName("Last name")] public string? LastName { get; set; }
        [Required][DisplayName("Email")] public string? Email { get; set; }
        [Required][DisplayName("Phone number")] public string? PhoneNr { get; set; }
        [DisplayName("Country of birth")] public string? CoBID { get; set; }
    }
    public sealed class StudentViewFactory : BaseViewFactory<StudentView, Student, StudentData>
    {
        protected override Student toEntity(StudentData d) => new(d);
    }
}
