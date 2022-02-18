#nullable disable
using Microsoft.EntityFrameworkCore;
using Music_School_DB.Data.Party;

namespace Music_School_DB.Data
{
    public class Music_School_DBContext : DbContext
    {
        public Music_School_DBContext (DbContextOptions<Music_School_DBContext> options)
            : base(options)
        {
        }

        public DbSet<InstructorData> Instructors { get; set; }
    }
}
