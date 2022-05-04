using Music_School_DB.Data.Party;

namespace Music_School_DB.Domain.Party
{
    public interface ICurrenciesRepo : IRepo<Currency> { }
    public class Currency : NamedEntity<CurrencyData>
    {
        public Currency() : this(new ()) { }
        public Currency(CurrencyData d) : base(d) { }
    }
}
