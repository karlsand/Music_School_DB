using System.Globalization;
using Music_School_DB.Data;
using Music_School_DB.Data.Party;
using Music_School_DB.Domain;

namespace Music_School_DB.Infra.Initializers
{
    public sealed class CurrencyInitalizer : BaseInitializer<CurrencyData>
    {
        public CurrencyInitalizer(MSDb? db) : base(db, db?.Currencies) { }
        protected override IEnumerable<CurrencyData> getEntities
        {
            get
            {
                var l = new List<CurrencyData>();
                foreach (CultureInfo cul in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
                {
                    var c = new RegionInfo(new CultureInfo(cul.Name, false).LCID);
                    if (l.FirstOrDefault(x => x.ID == c.ISOCurrencySymbol) is not null) continue;
                    if (string.IsNullOrWhiteSpace(c.ISOCurrencySymbol)) continue;
                    var d = createCurrency(c.ISOCurrencySymbol, c.CurrencyEnglishName, c.CurrencyNativeName);
                    l.Add(d);
                }
                return l;
            }
        }
        internal static CurrencyData createCurrency(string code, string name, string description) => new()
        {
            ID = code ?? EntityData.NewID,
            Code = code ?? Entity.DefaultStr,
            Name = name,
            Description = description,
        };
    }
}
