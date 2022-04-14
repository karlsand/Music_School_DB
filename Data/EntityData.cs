namespace Music_School_DB.Data
{
    public class EntityData
    {
        public static string NewID => Guid.NewGuid().ToString();
        public string ID { get; set; } = NewID;
    }
}
