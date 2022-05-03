﻿using Music_School_DB.Domain;
using Music_School_DB.Facade;

namespace Music_School_DB.Pages
{
    public abstract class OrderedPage<TView, TEntity, TRepo> : FilteredPage<TView, TEntity, TRepo>
        where TView : UniqueView, new()
        where TEntity : UniqueEntity
        where TRepo : IOrderedRepo<TEntity>
    {
        protected OrderedPage(TRepo r) : base(r) { }
        public string? CurrentOrder
        {
            get => repo.CurrentOrder;
            set => repo.CurrentOrder = value;
        }
        public string? SortOrder(string propertyName) => repo.SortOrder(propertyName);
    }
}
