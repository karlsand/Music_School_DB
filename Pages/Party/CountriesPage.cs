﻿using Music_School_DB.Domain.Party;
using Music_School_DB.Facade.Party;

namespace Music_School_DB.Pages.Party
{
    public class CountriesPage : PagedPage<CountryView, Country, ICountriesRepo>
    {
        public CountriesPage(ICountriesRepo r) : base(r) { }
        protected override Country toObject(CountryView? item) => new CountryViewFactory().Create(item);
        protected override CountryView toView(Country? entity) => new CountryViewFactory().Create(entity);
        public override string[] IndexColumns { get; } = new[] {
            nameof(CountryView.ID),
            nameof(CountryView.Code),
            nameof(CountryView.Name),
            nameof(CountryView.Description)
        };
        public List<Currency?> Currencies => toObject(Item).Currencies;
    }
}
