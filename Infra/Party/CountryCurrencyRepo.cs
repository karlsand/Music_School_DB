using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;

namespace Music_School_DB.Infra.Party
{
    public class CountryCurrencyRepo : Repo<CountryCurrency, CountryCurrencyData>, ICountryCurrencyRepo
    {
        public CountryCurrencyRepo(MSDb? db) : base(db, db?.CountryCurrency) { }
        protected override CountryCurrency toDomain(CountryCurrencyData d) => new(d);
        internal override IQueryable<CountryCurrencyData> addFilter(IQueryable<CountryCurrencyData> q)
        {
            var y = CurrentFilter;
            return string.IsNullOrWhiteSpace(y)
                ? q
                : q.Where(
                x => contains(x.ID, y)
                || contains(x.Code, y)
                || contains(x.Name, y)
                || contains(x.CountryID, y)
                || contains(x.CurrencyID, y));
        }
    }
}
