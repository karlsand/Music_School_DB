using Microsoft.EntityFrameworkCore;
using Music_School_DB.Data.Party;

namespace Music_School_DB.Infra
{
    public sealed class MSDb : DbContext
    {
        public MSDb(DbContextOptions<MSDb> options) : base(options) { }
        public DbSet<InstructorData>? Instructors { get; set; }
        public DbSet<StudentData>? Students { get;  set; }

        protected override void OnModelCreating(ModelBuilder b)
        {
            base.OnModelCreating(b);
            InitializeTables(b);
        }
        public static void InitializeTables(ModelBuilder b)
        {
            string s = "Music_School_DB";
            _ = (b?.Entity<InstructorData>()?.ToTable(nameof(Instructors), s));
            _ = (b?.Entity<StudentData>()?.ToTable(nameof(Students), s));
        }
    }
}
