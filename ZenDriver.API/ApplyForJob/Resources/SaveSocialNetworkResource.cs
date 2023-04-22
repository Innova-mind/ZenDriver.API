using ZenDriver.API.Security.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace ZenDriver.API.ApplyForJob.Resources;
public class SaveSocialNetworkResource
{ 

    [Required]
    public int UserId { get; set; }
    [MaxLength(100)]
    public string NameSocialNetwork { get; set; }
    [MaxLength(500)]
    public string UrlSocialNetwork { get; set; }

}
