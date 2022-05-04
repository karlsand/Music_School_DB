using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Music_School_DB.Facade.Party
{
    public sealed class CountryCurrencyView : NamedView
    {
        [Required][DisplayName("Country")] public string? CountryID { get; set; } = string.Empty;
        [Required][DisplayName("Currency")] public string? CurrencyID { get; set; } = string.Empty;
        [DisplayName("Currency native code")] public new string? Code { get; set; }
        [DisplayName("Currency native name")] public new string? Name { get; set; }
    }
    public sealed class CountryCurrencyViewFactory : BaseViewFactory<CountryCurrencyView, CountryCurrency, CountryCurrencyData>
    {
        protected override CountryCurrency toEntity(CountryCurrencyData d) => new(d);
    }
}
