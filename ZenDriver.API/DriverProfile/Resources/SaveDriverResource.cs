using System.ComponentModel.DataAnnotations;

namespace ZenDriver.API.DriverProfile.Resources;
public class SaveDriverResource
{
    [Required]
    public int Id { get; set; }
    
}
