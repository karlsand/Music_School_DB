namespace Music_School_DB.Data.Party
{
    public sealed class StudentData : UniqueData
    {
        public string? InstrumentID { get; set; }
        public string? InstructorID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNr { get; set; }
        public string? CoB { get; set; }
    }
}
