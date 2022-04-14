using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;

namespace Music_School_DB.Facade.Party
{
    public sealed class CurrencyView : IsoNamedView
    {
    }
    public sealed class CurrencyViewFactory : BaseViewFactory<CurrencyView, Currency, CurrencyData>
    {
        protected override Currency toEntity(CurrencyData d) => new(d);
    }
}
