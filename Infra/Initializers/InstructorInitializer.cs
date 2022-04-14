using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Music_School_DB.Data.Party;

namespace Music_School_DB.Infra.Initializers
{
    public sealed class InstructorInitializer : BaseInitializer<InstructorData>
    {
        public InstructorInitializer(MSDb? db) : base(db, db?.Instructors) { } 
        internal static InstructorData createInstructor(string id, string instrumentId, string firstName, string lastName, string phoneNr, string email)
        {
            var instructor = new InstructorData
            {
                ID = id,
                InstrumentID = instrumentId,
                FirstName = firstName,
                LastName = lastName,
                PhoneNr = phoneNr,
                Email = email
            };
            return instructor;
        }
        protected override IEnumerable<InstructorData> getEntities => new[]
        {
            createInstructor("1234", "321", "Peeter", "Peen", "123456", "peeter.p@gmail.com"),
            createInstructor("2345", "432", "Jaak", "Jaanus", "122456", "jaak.j@gmail.com"),
            createInstructor("3456", "543", "Kalev", "Kuld", "123356", "kalev.k@gmail.com"),
        };
    }
}
