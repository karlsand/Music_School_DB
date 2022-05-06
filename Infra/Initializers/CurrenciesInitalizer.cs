using System.Globalization;
using Music_School_DB.Data;
using Music_School_DB.Data.Party;
using Music_School_DB.Domain;

namespace Music_School_DB.Infra.Initializers
{
    public sealed class CurrenciesInitalizer : BaseInitializer<CurrencyData>
    {
        public CurrenciesInitalizer(MSDb? db) : base(db, db?.Currencies) { }
        protected override IEnumerable<CurrencyData> getEntities
        {
            get
            {
                var l = new List<CurrencyData>();
                foreach (CultureInfo cul in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
                {
                    var c = new RegionInfo(new CultureInfo(cul.Name, false).LCID);
                    var id = c.ISOCurrencySymbol;
                    if (!isCorrectIsoCode(id)) continue;
                    if (l.FirstOrDefault(x => x.ID == id) is not null) continue;
                    var d = createCurrency(id, c.CurrencyEnglishName, c.CurrencyNativeName);
                    l.Add(d);
                }
                return l;
            }
        }
        internal static CurrencyData createCurrency(string code, string name, string description) => new()
        {
            ID = code ?? UniqueData.NewID,
            Code = code ?? UniqueEntity.DefaultStr,
            Name = name,
            Description = description,
        };
    }
}
