using Music_School_DB.Data.Party;

namespace Music_School_DB.Domain.Party
{
    public interface IInstrumentsRepo : IRepo<Instrument> { }
    public sealed class Instrument : UniqueEntity<InstrumentData>
    {
        public Instrument() : this(new ()) { }
        public Instrument(InstrumentData d) : base(d) { }
        public string InstrumentName => getValue(Data?.InstrumentName);
        public string Classification => getValue(Data?.Classification);
    }
}
