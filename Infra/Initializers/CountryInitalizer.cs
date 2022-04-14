using System.Globalization;
using Music_School_DB.Data;
using Music_School_DB.Data.Party;
using Music_School_DB.Domain;

namespace Music_School_DB.Infra.Initializers
{
    public sealed class CountryInitalizer : BaseInitializer<CountryData>
    {
        public CountryInitalizer(MSDb? db) : base(db, db?.Countries) { }
        protected override IEnumerable<CountryData> getEntities 
        { 
            get {
                var l = new List<CountryData>();
                foreach (CultureInfo cul in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
                {
                    var c = new RegionInfo(new CultureInfo(cul.Name, false).LCID);
                    if (l.FirstOrDefault(x => x.ID == c.ThreeLetterISORegionName) is not null) continue;
                    if (string.IsNullOrWhiteSpace(c.ThreeLetterISORegionName)) continue;
                    var d = createCountry(c.ThreeLetterISORegionName, c.NativeName, c.EnglishName);
                    l.Add(d);
                }
                return l; 
            } 
        }
        internal static CountryData createCountry(string code, string name, string description) => new()
        {
            ID = code ?? EntityData.NewID,
            Code = code ?? Entity.DefaultStr,
            Name = name,
            Description = description,
        };
    }
}
