using Music_School_DB.Data.Party;

namespace Music_School_DB.Domain.Party
{
    public interface ICountriesRepo : IRepo<Country> { }
    public class Country : Entity<CountryData>
    {
        public Country() : this(new CountryData()) { }
        public Country(CountryData d) : base(d) { }
        public string Code => getValue(Data?.Code);
        public string Name => getValue(Data?.Name);
        public string Description => getValue(Data?.Description);
    }
}
