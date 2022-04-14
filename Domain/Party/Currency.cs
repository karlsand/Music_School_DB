using Music_School_DB.Data.Party;

namespace Music_School_DB.Domain.Party
{
    public interface ICurrenciesRepo : IRepo<Currency> { }
    public class Currency : Entity<CurrencyData>
    {
        public Currency() : this(new CurrencyData()) { }
        public Currency(CurrencyData d) : base(d) { }
        public string Code => getValue(Data?.Code);
        public string Name => getValue(Data?.Name);
        public string Description => getValue(Data?.Description);
    }
}
