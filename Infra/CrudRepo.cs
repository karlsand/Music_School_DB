using Microsoft.EntityFrameworkCore;
using Music_School_DB.Data;
using Music_School_DB.Domain;
using System.Linq;

namespace Music_School_DB.Infra
{
    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public abstract class CrudRepo<TDomain, TData> : BaseRepo<TDomain, TData>
        where TDomain : UniqueEntity<TData>, new()
        where TData : UniqueData, new()
    {
        protected CrudRepo(DbContext? c, DbSet<TData>? s) : base(c, s) { }
        public override bool Add(TDomain obj) => AddAsync(obj).GetAwaiter().GetResult();
        public override bool Delete(string id) => DeleteAsync(id).GetAwaiter().GetResult();
        public override List<TDomain> Get() => GetAsync().GetAwaiter().GetResult();
        public override List<TDomain> GetAll<TKey>(Func<TDomain, TKey>? orderBy = null)
        {
            var r = new List<TDomain>();
            if (set is null) return r;
            foreach (var d in set) r.Add(toDomain(d));
            return (orderBy is null)? r : r.OrderBy(orderBy).ToList();
        } 
        public override bool Update(TDomain obj) => UpdateAsync(obj).GetAwaiter().GetResult();
        public override TDomain Get(string id) => GetAsync(id).GetAwaiter().GetResult();
        public override async Task<bool> AddAsync(TDomain obj)
        {
            var d = obj.Data;
            try
            {
                _ = (set is null) ? null : await set.AddAsync(d);
                _ = (db is null) ? 0 : await db.SaveChangesAsync();
                return true;
            } catch { return false; }
        }
        public override async Task<bool> DeleteAsync(string id)
        {
            try
            {
                var d = (set is null) ? null : await set.FindAsync(id);
                if (d == null) return false;
                _ = set?.Remove(d);
                _ = (db is null) ? 0 : await db.SaveChangesAsync();
                return true;
            } catch { return false; }
        }
        public override async Task<List<TDomain>> GetAsync()
        {
            try
            {
                var query = createSql();
                var list = await CrudRepo<TDomain, TData>.runSql(query);
                var items = new List<TDomain>();
                foreach (var d in list)
                {
                    var obj = toDomain(d);
                    items.Add(obj);
                }
                return items;
            } catch { return new List<TDomain>(); }
        }
        internal protected virtual IQueryable<TData> createSql() => from s in set select s;
        internal static async Task<List<TData>> runSql(IQueryable<TData> query) => await query.AsNoTracking().ToListAsync();
        public override async Task<TDomain> GetAsync(string id)
        {
            try
            {
                if (id == null)
                {
                    return new TDomain();
                }
                var d = (set is null) ? null : await set.FirstOrDefaultAsync(x => x.ID == id);
                if (d == null)
                {
                    return new TDomain();
                }
                return toDomain(d);
            } catch { return new TDomain(); }
        }
        public override async Task<bool> UpdateAsync(TDomain obj)
        {
            try
            {
                var d = obj.Data;
                if (db is not null) db.Attach(d).State = EntityState.Modified;
                _ = (db is null) ? 0 : await db.SaveChangesAsync();
                return true;
            } catch { return false; }
        }
        protected abstract TDomain toDomain(TData d);
    }
}
