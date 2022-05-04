using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Music_School_DB.Facade.Party
{
    public sealed class InstructorStudentsView : NamedView
    {
        [Required][DisplayName("Instructor name")] public string? InstructorID { get; set; } = string.Empty;
        [Required][DisplayName("Student name")] public string? StudentID { get; set; } = string.Empty;
        [DisplayName("Use if needed")] public new string? Code { get; set; }
    }
    public sealed class InstructorStudentsViewFactory : BaseViewFactory<InstructorStudentsView, InstructorStudents, InstructorStudentsData>
    {
        protected override InstructorStudents toEntity(InstructorStudentsData d) => new(d);
    }
}
