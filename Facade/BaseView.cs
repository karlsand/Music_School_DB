using System.ComponentModel.DataAnnotations;

namespace Music_School_DB.Facade
{
    public abstract class BaseView
    {
        [Required] public string ID { get; set; } = Guid.NewGuid().ToString();
    }
}
