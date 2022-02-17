using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Music_School_DB.Facade.Party
{
    public class InstructorView
    {
        [Required] public string ID { get; set; }
        [DisplayName("Instrument ID")] [Required] public string? InstrumentID { get; set; }
        [DisplayName("First name")] public string? FirstName { get; set; }
        [DisplayName("Last name")] [Required] public string? LastName { get; set; }
        [DisplayName("Email")] [Required] public string? Email { get; set; }
        [DisplayName("Phone number")] public string? PhoneNr { get; set; }
        [DisplayName("Full information")] public string? FullName { get; set; }
    }
}
