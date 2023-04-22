using System.ComponentModel.DataAnnotations;

namespace ZenDriver.API.Settings.Resources;
public class SaveDriverResource
{

    [Required]
    public int UserId { get; set; }
    
}
