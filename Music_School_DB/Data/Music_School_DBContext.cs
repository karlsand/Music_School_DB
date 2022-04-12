#nullable disable
using Microsoft.EntityFrameworkCore;

namespace Music_School_DB.Data
{
    public class Music_School_DBContext : DbContext
    {
        public Music_School_DBContext (DbContextOptions<Music_School_DBContext> options)
            : base(options)
        {
        }
    }
}
