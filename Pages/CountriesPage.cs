using Music_School_DB.Domain.Party;
using Music_School_DB.Facade.Party;

namespace Music_School_DB.Pages
{
    public class CountriesPage : BasePage<CountryView, Country, ICountriesRepo>
    {
        public CountriesPage(ICountriesRepo r) : base(r) { }
        protected override Country toObject(CountryView? item) => new CountryViewFactory().Create(item);
        protected override CountryView toView(Country? entity) => new CountryViewFactory().Create(entity);
    }
}
