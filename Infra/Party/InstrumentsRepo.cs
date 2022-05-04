using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;

namespace Music_School_DB.Infra.Party
{
    public class InstrumentsRepo : Repo<Instrument, InstrumentData>, IInstrumentsRepo
    {
        public InstrumentsRepo(MSDb? db) : base(db, db?.Instruments) { }
        protected override Instrument toDomain(InstrumentData d) => new(d);
        internal override IQueryable<InstrumentData> addFilter(IQueryable<InstrumentData> q)
        {
            var y = CurrentFilter;
            return string.IsNullOrWhiteSpace(y)
                ? q
                : q.Where(
                x => contains(x.ID, y)
                || contains(x.InstrumentName, y)
                || contains(x.Classification, y));
        }
    }
}
