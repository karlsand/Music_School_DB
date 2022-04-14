using Music_School_DB.Domain.Party;
using Music_School_DB.Facade.Party;

namespace Music_School_DB.Pages
{
    public class CurrenciesPage : BasePage<CurrencyView, Currency, ICurrenciesRepo>
    {
        public CurrenciesPage(ICurrenciesRepo r) : base(r) { }
        protected override Currency toObject(CurrencyView? item) => new CurrencyViewFactory().Create(item);
        protected override CurrencyView toView(Currency? entity) => new CurrencyViewFactory().Create(entity);
    }
}
