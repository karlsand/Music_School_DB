using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Music_School_DB.Facade.Party
{
    public sealed class InstructorView : UniqueView
    {
        [Required][DisplayName("Instrument ID")] public string? InstrumentID { get; set; }
        [Required][DisplayName("First name")] public string? FirstName { get; set; }
        [Required][DisplayName("Last name")] public string? LastName { get; set; }
        [Required][DisplayName("Email")] public string? Email { get; set; }
        [Required][DisplayName("Phone number")] public string? PhoneNr { get; set; }
        [Required][DisplayName("Country of birth")] public string? CoBID { get; set; }
        [DisplayName("Full information")] public string? FullName { get; set; }
    }
    public sealed class InstructorViewFactory : BaseViewFactory<InstructorView, Instructor, InstructorData>
    {
        protected override Instructor toEntity(InstructorData d) => new(d);
        public override InstructorView Create(Instructor? e)
        {
            var v = base.Create(e);
            v.FullName = e?.ToString();
            return v;
        }
    }
}
