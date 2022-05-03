using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;

namespace Music_School_DB.Infra.Party
{
    public class CurrenciesRepo : Repo<Currency, CurrencyData>, ICurrenciesRepo
    {
        public CurrenciesRepo(MSDb? db) : base(db, db?.Currencies) { }
        protected override Currency toDomain(CurrencyData d) => new(d);
        internal override IQueryable<CurrencyData> addFilter(IQueryable<CurrencyData> q)
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
