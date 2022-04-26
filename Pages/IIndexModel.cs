﻿using Music_School_DB.Facade;

namespace Music_School_DB.Pages
{
    public interface IIndexModel<TView> where TView : UniqueView
    {
        public string[] IndexColumns { get; }
        public IList<TView>? Items { get; }
        public object? GetValue(string name, TView v);
    }
}
