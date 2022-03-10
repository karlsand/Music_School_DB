using Music_School_DB.Data;

namespace Music_School_DB.Domain
{
    public abstract class Entity { }
    public abstract class Entity<TData> : Entity where TData : EntityData, new()
    {
        private readonly TData data;
        public TData Data => data;
        public Entity() : this(new TData()) { }
        public Entity(TData d) => data = d;
    }
}
