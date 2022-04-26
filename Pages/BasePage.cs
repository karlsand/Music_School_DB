using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Music_School_DB.Aids;
using Music_School_DB.Domain;
using Music_School_DB.Facade;

namespace Music_School_DB.Pages
{
    public abstract class BasePage<TView, TEntity, TRepo> : PageModel
        where TView : UniqueView 
        where TEntity : UniqueEntity
        where TRepo : IBaseRepo<TEntity>
    {
        protected readonly TRepo repo;
        protected abstract TView toView(TEntity? entity);
        protected abstract TEntity toObject(TView? item);
        protected abstract IActionResult redirectToIndex();
        [BindProperty] public TView? Item { get; set; }
        public IList<TView>? Items { get; set; }
        public string ItemID => Item?.ID ?? string.Empty;
        public BasePage(TRepo r) => repo = r;
        protected abstract void setAttributes(int idx, string? order, string? filter);
        protected virtual async Task<IActionResult> perform(Func<Task<IActionResult>> f,
            int idx, string? order, string? filter, bool removeKeys = false)
        {
            setAttributes(idx, order, filter);
            if(removeKeys) removeKey(nameof(order), nameof(filter));
            return await f();
        }
        protected abstract Task<IActionResult> postCreateAsync();
        protected abstract Task<IActionResult> getDetailsAsync(string id);
        protected abstract Task<IActionResult> getDeleteAsync(string id);
        protected abstract Task<IActionResult> postDeleteAsync(string id);
        protected abstract Task<IActionResult> getEditAsync(string id);
        protected abstract Task<IActionResult> postEditAsync();
        protected abstract Task<IActionResult> getIndexAsync();
        internal virtual void removeKey(params string[] keys)
        {
            foreach(var key in keys ?? Array.Empty<string>())
            {
                Safe.Run(() => ModelState.Remove(key));
            }
        }
        public IActionResult OnGetCreate(int idx = 0, string? order = null, string? filter = null)
        {
            setAttributes(idx, order, filter);
            return getCreate();
        }
        protected abstract IActionResult getCreate();
        public async Task<IActionResult> OnPostCreateAsync(int idx = 0, string? order = null, string? filter = null) 
            => await perform(() => postCreateAsync(), idx, order, filter, true);
        public async Task<IActionResult> OnGetDetailsAsync(string id, int idx = 0, string? order = null, string? filter = null)
            => await perform(() => getDetailsAsync(id), idx, order, filter);   
        public async Task<IActionResult> OnGetDeleteAsync(string id, int idx = 0, string? order = null, string? filter = null) 
            => await perform(() => getDeleteAsync(id), idx, order, filter);
        public async Task<IActionResult> OnPostDeleteAsync(string id, int idx = 0, string? order = null, string? filter = null)
            => await perform(() => postDeleteAsync(id), idx, order, filter);
        public async Task<IActionResult> OnGetEditAsync(string id, int idx = 0, string? order = null, string? filter = null)
            => await perform(() => getEditAsync(id), idx, order, filter);
        public async Task<IActionResult> OnPostEditAsync(int idx = 0, string? order = null, string? filter = null)
            => await perform(() => postEditAsync(), idx, order, filter, true);
        public async Task<IActionResult> OnGetIndexAsync(int idx = 0, string? order = null, string? filter = null)
            => await perform(() => getIndexAsync(), idx, order, filter);
    }
}
