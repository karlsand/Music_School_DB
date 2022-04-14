using Microsoft.EntityFrameworkCore;
using Music_School_DB.Data;
using Music_School_DB.Domain;

namespace Music_School_DB.Infra
{
    public abstract class PagedRepo<TDomain, TData> : OrderedRepo<TDomain, TData> where TDomain : UniqueEntity<TData>, new() where TData : UniqueData, new()
    {
        protected PagedRepo(DbContext? c, DbSet<TData>? s) : base(c, s) { }
    }
}
