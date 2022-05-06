using Music_School_DB.Facade;

namespace Music_School_DB.Pages
{
    public interface IIndexModel<TView> where TView : UniqueView
    {
        string[] IndexColumns { get; }
        IList<TView>? Items { get; }
        object? GetValue(string name, TView v);
        string? DisplayName(string name);
    }
}
