using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;

namespace Music_School_DB.Infra.Party
{
    public class CountriesRepo : Repo<Country, CountryData>, ICountriesRepo
    {
        public CountriesRepo(MSDb? db) : base(db, db?.Countries) { }
        protected override Country toDomain(CountryData d) => new(d);
    }
}
