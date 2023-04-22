using System.ComponentModel.DataAnnotations;

namespace ZenDriver.API.Settings.Resources;

public class SaveRecruiterResource
{
    [Required]
    public int UserId { get; set; }
    
    [Required]
    public int CompanyId { get; set; }
}