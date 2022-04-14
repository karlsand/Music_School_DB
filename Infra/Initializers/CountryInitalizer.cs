using System.Globalization;
using Music_School_DB.Data.Party;

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
                    var d = createCountry(c.ThreeLetterISORegionName, c.NativeName, c.EnglishName);
                    if (l.FirstOrDefault(x => x.ID == d.ID) is not null) continue;
                    l.Add(d);
                }
                return l; 
            } 
        }
        internal static CountryData createCountry(string code, string description, string name) => new()
        {
            ID = code,
            Code = code,
            Description = description,
            Name = name,
        };
    }
}
