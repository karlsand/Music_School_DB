using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;

namespace Music_School_DB.Infra.Party
{
    public class CountriesRepo : Repo<Country, CountryData>, ICountriesRepo
    {
        public CountriesRepo(MSDb? db) : base(db, db?.Countries) { }
        protected override Country toDomain(CountryData d) => new(d);
        internal override IQueryable<CountryData> addFilter(IQueryable<CountryData> q)
        {
            var y = CurrentFilter;
            return string.IsNullOrWhiteSpace(y)
                ? q
                : q.Where(
                x => contains(x.ID, y)
                || contains(x.Code, y)
                || contains(x.Name, y)
                || contains(x.Description, y));
        }
    }
}
