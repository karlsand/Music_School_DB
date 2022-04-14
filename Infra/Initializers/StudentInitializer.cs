using Microsoft.EntityFrameworkCore;
using Music_School_DB.Data.Party;

namespace Music_School_DB.Infra.Initializers
{
    public sealed class StudentInitializer : BaseInitializer<StudentData>
    {
        public StudentInitializer(MSDb? db) : base(db, db?.Students) { }
        protected override IEnumerable<StudentData> getEntities => new[]
        {
            createStudent("4321", "1", "321", "Peeter", "Peen", "654321", "peeter.p@gmail.com"),
            createStudent("5432", "2", "432", "Jaak", "Jaanus", "654221", "jaak.j@gmail.com"),
            createStudent("6543", "3", "543", "Kalev", "Kuld", "653321", "kalev.k@gmail.com"),
        };
        internal static StudentData createStudent(string id, string instructorId, string instrumentId, string firstName, string lastName, string phoneNr, string email)
        {
            var student = new StudentData
            {
                ID = id,
                InstructorID = instructorId,
                InstrumentID = instrumentId,
                FirstName = firstName,
                LastName = lastName,
                PhoneNr = phoneNr,
                Email = email
            };
            return student;
        }
    }
}
