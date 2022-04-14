using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;

namespace Music_School_DB.Facade.Party
{
    public sealed class CountryView : IsoNamedView
    {
    }
    public sealed class CountryViewFactory : BaseViewFactory<CountryView, Country, CountryData>
    {
        protected override Country toEntity(CountryData d) => new(d);
    }
}
