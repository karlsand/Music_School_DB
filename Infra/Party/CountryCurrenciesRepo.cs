using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;

namespace Music_School_DB.Infra.Party
{
    public class CountryCurrenciesRepo : Repo<CountryCurrency, CountryCurrencyData>, ICountryCurrenciesRepo
    {
        public CountryCurrenciesRepo(MSDb? db) : base(db, db?.CountryCurrencies) { }
        protected override CountryCurrency toDomain(CountryCurrencyData d) => new(d);
        internal override IQueryable<CountryCurrencyData> addFilter(IQueryable<CountryCurrencyData> q)
        {
            var y = CurrentFilter;
            return string.IsNullOrWhiteSpace(y)
                ? q
                : q.Where(
                x => x.ID.Contains(y)
                || x.Code.Contains(y)
                || x.Name.Contains(y)
                || x.Description.Contains(y)
                || x.CountryID.Contains(y)
                || x.CurrencyID.Contains(y));
        }
    }
}