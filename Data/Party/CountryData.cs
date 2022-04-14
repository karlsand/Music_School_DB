using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_School_DB.Data.Party
{
    public class CountryData : EntityData
    {
        public string Code { get; set; } = string.Empty;
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
