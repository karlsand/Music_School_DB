namespace Music_School_DB.Data
{
    public class NamedData : UniqueData
    {
        public string Code { get; set; } = string.Empty;
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
