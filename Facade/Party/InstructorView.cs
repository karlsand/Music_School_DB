using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Music_School_DB.Facade.Party
{
    public sealed class InstructorView : BaseView
    {
        [DisplayName("Instrument ID")] [Required] public string? InstrumentID { get; set; }
        [DisplayName("First name")] public string? FirstName { get; set; }
        [DisplayName("Last name")] [Required] public string? LastName { get; set; }
        [DisplayName("Email")] [Required] public string? Email { get; set; }
        [DisplayName("Phone number")] public string? PhoneNr { get; set; }
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
