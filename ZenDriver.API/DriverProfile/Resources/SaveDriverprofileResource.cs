using System.ComponentModel.DataAnnotations;

namespace ZenDriver.API.DriverProfile.Resources;

public class SaveDriverprofileResource
{
    [Required]
    public int Id { get; set; }

}