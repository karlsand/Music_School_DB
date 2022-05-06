using Music_School_DB.Data.Party;

namespace Music_School_DB.Infra.Initializers
{
    public sealed class InstructorsInitializer : BaseInitializer<InstructorData>
    {
        public InstructorsInitializer(MSDb? db) : base(db, db?.Instructors) { } 
        internal static InstructorData createInstructor(string id, string instrumentId, string firstName, string lastName, string phoneNr, string email, string CoBID)
        {
            var instructor = new InstructorData
            {
                ID = id,
                InstrumentID = instrumentId,
                FirstName = firstName,
                LastName = lastName,
                PhoneNr = phoneNr,
                Email = email,
                CoBID = CoBID,
            };
            return instructor;
        }
        protected override IEnumerable<InstructorData> getEntities => new[]
        {
            createInstructor("1234", "1", "Peeter", "Peen", "123456", "peeter.p@gmail.com", "EST"),
            createInstructor("2345", "2", "Jaak", "Jaanus", "122456", "jaak.j@gmail.com", "EST"),
            createInstructor("3456", "3", "Kalev", "Kuld", "123356", "kalev.k@gmail.com", "EST"),
        };
    }
}
