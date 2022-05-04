using Music_School_DB.Data.Party;

namespace Music_School_DB.Infra.Initializers
{
    public sealed class InstrumentInitializer : BaseInitializer<InstrumentData>
    {
        public InstrumentInitializer(MSDb? db) : base(db, db?.Instruments) { }
        internal static InstrumentData createInstrument(string id, string instrumentName, string classification)
        {
            var instrument = new InstrumentData
            {
                ID = id,
                InstrumentName = instrumentName,
                Classification = classification,
            };
            return instrument;
        }
        protected override IEnumerable<InstrumentData> getEntities => new[]
        {
            createInstrument("1", "Accordion", "Free-reed aerophone"),
            createInstrument("2", "Acoustic guitar", "Chordophone"),
            createInstrument("3", "Harp", "Chordophone"),
            createInstrument("4", "Clarinet", "Single-reeded woodwind instrument"),
            createInstrument("5", "Trumpet", "Brass instrument"),
        };
    }
}
