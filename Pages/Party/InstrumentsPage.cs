using Music_School_DB.Domain.Party;
using Music_School_DB.Facade.Party;

namespace Music_School_DB.Pages.Party
{
    public class InstrumentsPage : PagedPage<InstrumentView, Instrument, IInstrumentsRepo>
    {
        public InstrumentsPage(IInstrumentsRepo r) : base(r) { }
        protected override Instrument toObject(InstrumentView? item) => new InstrumentViewFactory().Create(item);
        protected override InstrumentView toView(Instrument? entity) => new InstrumentViewFactory().Create(entity);
        public override string[] IndexColumns { get; } = new[] {
            nameof(InstrumentView.ID),
            nameof(InstrumentView.InstrumentName),
            nameof(InstrumentView.Classification)
        };
    }
}
