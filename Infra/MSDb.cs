using Microsoft.EntityFrameworkCore;
using Music_School_DB.Data.Party;

namespace Music_School_DB.Infra
{
    public sealed class MSDb : DbContext
    {
        public MSDb(DbContextOptions<MSDb> options) : base(options) { }
        public DbSet<InstructorData>? Instructors { get; internal set; }
        public DbSet<InstrumentData>? Instruments { get; internal set; }
        public DbSet<StudentData>? Students { get; internal set; }
        public DbSet<CountryData>? Countries { get; internal set; }
        public DbSet<CurrencyData>? Currencies { get; internal set; }
        public DbSet<CountryCurrencyData>? CountryCurrencies { get; internal set; }
        public DbSet<InstructorStudentData>? InstructorStudents { get; internal set; }

        protected override void OnModelCreating(ModelBuilder b)
        {
            base.OnModelCreating(b);
            InitializeTables(b);
        }
        public static void InitializeTables(ModelBuilder b)
        {
            string s = "Music_School_DB";
            _ = (b?.Entity<InstructorData>()?.ToTable(nameof(Instructors), s));
            _ = (b?.Entity<InstrumentData>()?.ToTable(nameof(Instruments), s));
            _ = (b?.Entity<StudentData>()?.ToTable(nameof(Students), s));
            _ = (b?.Entity<CountryData>()?.ToTable(nameof(Countries), s));
            _ = (b?.Entity<CurrencyData>()?.ToTable(nameof(Currencies), s));
            _ = (b?.Entity<CountryCurrencyData>()?.ToTable(nameof(CountryCurrencies), s));
            _ = (b?.Entity<InstructorStudentData>()?.ToTable(nameof(InstructorStudents), s));
        }
    }
}
