using Music_School_DB.Data.Party;
using Music_School_DB.Domain.Party;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Music_School_DB.Facade.Party
{
    public sealed class CurrencyView : BaseView
    {
        [Required] [DisplayName("ISO three-letter code")] public string? Code { get; set; }
        [DisplayName("English name")] public string? Name { get; set; }
        [DisplayName("Native name")] public string? Description { get; set; }
    }
    public sealed class CurrencyViewFactory : BaseViewFactory<CurrencyView, Currency, CurrencyData>
    {
        protected override Currency toEntity(CurrencyData d) => new(d);
    }
}
