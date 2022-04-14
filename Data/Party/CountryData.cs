using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_School_DB.Data.Party
{
    public class CountryData : EntityData
    {
        public string Code { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }
    }
    public class CurrencyData : EntityData
    {

    }
}
