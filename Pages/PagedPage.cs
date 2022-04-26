﻿using Microsoft.AspNetCore.Mvc;
using Music_School_DB.Aids;
using Music_School_DB.Domain;
using Music_School_DB.Facade;

namespace Music_School_DB.Pages
{
    public abstract class PagedPage<TView, TEntity, TRepo> : OrderedPage<TView, TEntity, TRepo>, IPageModel, IIndexModel<TView>
        where TView : UniqueView
        where TEntity : UniqueEntity
        where TRepo : IPagedRepo<TEntity>
    {
        protected PagedPage(TRepo r) : base(r) { }
        public int PageIndex
        {
            get => repo.PageIndex;
            set => repo.PageIndex = value;
        }
        public int TotalPages => repo.TotalPages;
        public bool HasNextPage => repo.HasNextPage;
        public bool HasPreviousPage => repo.HasPreviousPage;
        protected override void setAttributes(int idx, string? order, string? filter)
        {
            PageIndex = idx;
            CurrentFilter = filter;
            CurrentOrder = order;
        }
        protected override IActionResult redirectToIndex() => RedirectToPage("./Index", "Index",
            new { pageIndex = PageIndex, currentFilter = CurrentFilter, sortOrder = CurrentOrder, });
        public virtual string[] IndexColumns => Array.Empty<string>();
        public object? GetValue(string name, TView v)
            => Safe.Run(() =>
            {
                var pi = v?.GetType()?.GetProperty(name);
                return pi == null ? null : pi.GetValue(v);
            }, null);
    }
}
