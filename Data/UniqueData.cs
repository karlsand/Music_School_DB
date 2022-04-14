namespace Music_School_DB.Data
{
    public class UniqueData
    {
        public static string NewID => Guid.NewGuid().ToString();
        public string ID { get; set; } = NewID;
    }
}
