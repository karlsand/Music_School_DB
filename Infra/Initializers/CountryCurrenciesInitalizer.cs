using System.Globalization;
using Music_School_DB.Data;
using Music_School_DB.Data.Party;
using Music_School_DB.Domain;

namespace Music_School_DB.Infra.Initializers
{
    public sealed class CountryCurrenciesInitalizer : BaseInitializer<CountryCurrencyData>
    {
        public CountryCurrenciesInitalizer(MSDb? db) : base(db, db?.CountryCurrencies) { }
        protected override IEnumerable<CountryCurrencyData> getEntities
        {
            get
            {
                var l = new List<CountryCurrencyData>();
                foreach (CultureInfo cul in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
                {
                    var c = new RegionInfo(new CultureInfo(cul.Name, false).LCID);
                    var countryID = c.ThreeLetterISORegionName;
                    var currencyID = c.ISOCurrencySymbol;
                    var nativeName = c.CurrencyNativeName;
                    var currencyCode = c.CurrencySymbol;
                    var d = createEntity(countryID, currencyID, currencyCode, nativeName);
                    l.Add(d);
                }
                return l;
            }
        }
        internal static CountryCurrencyData createEntity(string countryID, string currencyID, string code, string? name = null, string? description = null) 
            => new()
        {
            ID = UniqueData.NewID,
            CountryID = countryID,
            CurrencyID = currencyID,
            Code = code ?? UniqueEntity.DefaultStr,
            Name = name,
            Description = description,
        };
    }
}
