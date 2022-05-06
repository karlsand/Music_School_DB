using Music_School_DB.Data.Party;

namespace Music_School_DB.Infra.Initializers
{
    public sealed class StudentsInitializer : BaseInitializer<StudentData>
    {
        public StudentsInitializer(MSDb? db) : base(db, db?.Students) { }
        internal static StudentData createStudent(string id, string instructorId, string instrumentId, string firstName, string lastName, string phoneNr, string email, string CoBID)
        {
            var student = new StudentData
            {
                ID = id,
                InstructorID = instructorId,
                InstrumentID = instrumentId,
                FirstName = firstName,
                LastName = lastName,
                PhoneNr = phoneNr,
                Email = email,
                CoBID = CoBID,
            };
            return student;
        }
        protected override IEnumerable<StudentData> getEntities => new[]
        {
            createStudent("4321", "1", "1", "Peeter", "Peen", "654321", "peeter.p@gmail.com", "EST"),
            createStudent("5432", "2", "2", "Jaak", "Jaanus", "654221", "jaak.j@gmail.com", "EST"),
            createStudent("6543", "3", "3", "Kalev", "Kuld", "653321", "kalev.k@gmail.com", "EST"),
        };
    }
}
