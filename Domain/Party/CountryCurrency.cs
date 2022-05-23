using Music_School_DB.Data.Party;

namespace Music_School_DB.Domain.Party
{
    public interface ICountryCurrenciesRepo : IRepo<CountryCurrency> { }
    public sealed class CountryCurrency : NamedEntity<CountryCurrencyData>
    {
        public CountryCurrency() : this(new ()) { }
        public CountryCurrency(CountryCurrencyData d) : base(d) { }
        public string CountryID => getValue(Data?.CountryID);
        public string CurrencyID => getValue(Data?.CurrencyID);
        public Country? Country => GetRepo.Instance<ICountriesRepo>()?.Get(CountryID);
        public Currency? Currency => GetRepo.Instance<ICurrenciesRepo>()?.Get(CurrencyID);
    }
}
