using System.Globalization;
using Music_School_DB.Data;
using Music_School_DB.Data.Party;
using Music_School_DB.Domain;

namespace Music_School_DB.Infra.Initializers
{
    public sealed class CountriesInitalizer : BaseInitializer<CountryData>
    {
        public CountriesInitalizer(MSDb? db) : base(db, db?.Countries) { }
        protected override IEnumerable<CountryData> getEntities 
        { 
            get {
                var l = new List<CountryData>();
                foreach (CultureInfo cul in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
                {
                    var c = new RegionInfo(new CultureInfo(cul.Name, false).LCID);
                    var id = c.ThreeLetterISORegionName;
                    if (!isCorrectIsoCode(id)) continue;
                    if (l.FirstOrDefault(x => x.ID == id) is not null) continue;
                    var d = createCountry(id, c.NativeName, c.EnglishName);
                    l.Add(d);
                }
                return l; 
            } 
        }
        internal static CountryData createCountry(string code, string name, string description) 
            => new()
        {
            ID = code ?? UniqueData.NewID,
            Code = code ?? UniqueEntity.DefaultStr,
            Name = name,
            Description = description,
        };
    }
}
