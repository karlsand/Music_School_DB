#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Music_School_DB.Data
{
    public class Music_School_DBContext : DbContext
    {
        public Music_School_DBContext (DbContextOptions<Music_School_DBContext> options)
            : base(options)
        {
        }

        public DbSet<Music_School_DB.Data.Instructor> Instructor { get; set; }
    }
}
