using Microsoft.AspNetCore.Mvc;
using Music_School_DB.Domain;
using Music_School_DB.Facade;

namespace Music_School_DB.Pages
{
    public abstract class CrudPage<TView, TEntity, TRepo> : BasePage<TView, TEntity, TRepo>
        where TView : UniqueView, new()
        where TEntity : UniqueEntity
        where TRepo : ICrudRepo<TEntity>
    {
        protected CrudPage(TRepo r) : base(r) { }
        protected override IActionResult getCreate() => Page();
        protected virtual async Task<IActionResult> getItemPage(string id)
        {
            Item = await getItem(id);
            return Item == null ? NotFound() : Page();
        }
        
        protected override async Task<IActionResult> getDetailsAsync(string id) => await getItemPage(id);
        protected override async Task<IActionResult> getDeleteAsync(string id) => await getItemPage(id);
        protected override async Task<IActionResult> getEditAsync(string id) => await getItemPage(id);
        protected override async Task<IActionResult> getIndexAsync()
        {
            var list = await repo.GetAsync();
            Items = new List<TView>();
            foreach (var obj in list)
            {
                var v = toView(obj);
                Items.Add(v);
            }
            return Page();
        }
        protected override async Task<IActionResult> postCreateAsync()
        {
            if (!ModelState.IsValid) return Page();
            _ = await repo.AddAsync(toObject(Item));
            return redirectToIndex();
        }
        protected override async Task<IActionResult> postDeleteAsync(string id)
        {
            if (id == null) return NotFound();
            _ = await repo.DeleteAsync(id);
            return redirectToIndex();
        }
        protected override async Task<IActionResult> postEditAsync()
        {
            if (!ModelState.IsValid) return Page();
            var obj = toObject(Item);
            var updated = await repo.UpdateAsync(obj);
            if (!updated) NotFound();
            return redirectToIndex();
        }
        private async Task<TView> getItem(string id) => toView(await repo.GetAsync(id));
    }
}
