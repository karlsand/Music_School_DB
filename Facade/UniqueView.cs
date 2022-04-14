using System.ComponentModel.DataAnnotations;

namespace Music_School_DB.Facade
{
    public abstract class UniqueView
    {
        [Required] public string ID { get; set; } = Guid.NewGuid().ToString();
    }
}
