using Music_School_DB.Data.Party;

namespace Music_School_DB.Domain.Party
{
    public interface ICountriesRepo : IRepo<Country> { }
    public class Country : NamedEntity<CountryData>
    {
        public Country() : this(new ()) { }
        public Country(CountryData d) : base(d) { }
    }
}
