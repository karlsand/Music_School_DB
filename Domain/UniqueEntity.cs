using Music_School_DB.Data;

namespace Music_School_DB.Domain
{
    public abstract class UniqueEntity 
    {
        public static string DefaultStr => "Undefined";
        protected static string getValue(string? v) => v ?? DefaultStr;
    }
    public abstract class UniqueEntity<TData> : UniqueEntity where TData : UniqueData, new()
    {
        private readonly TData data;
        public TData Data => data;
        public UniqueEntity() : this(new TData()) { }
        public UniqueEntity(TData d) => data = d;
        public string ID => getValue(Data?.ID);
    }
}
