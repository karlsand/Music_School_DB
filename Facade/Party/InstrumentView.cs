using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Music_School_DB.Facade.Party
{
    public sealed class InstrumentView : UniqueView
    {
        [DisplayName("Instrument name")] public string? InstrumentName { get; set; }
        [DisplayName("Classification")] public string? Classification { get; set; }
    }
    public sealed class InstrumentViewFactory : BaseViewFactory<InstrumentView, Instrument, InstrumentData>
    {
        protected override Instrument toEntity(InstrumentData d) => new(d);
    }
}
