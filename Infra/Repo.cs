using Microsoft.EntityFrameworkCore;
using Music_School_DB.Data;
using Music_School_DB.Domain;

namespace Music_School_DB.Infra
{
    public abstract class Repo<TDomain, TData> : PagedRepo<TDomain, TData> 
        where TDomain : UniqueEntity<TData>, new() 
        where TData : UniqueData, new()
    {
        protected Repo(DbContext? c, DbSet<TData>? s) : base(c, s) { }
        internal protected static bool contains(string? value, string? s) => (s is null) || (value?.Contains(s) ?? false);
    }
}
