using ZenDriver.API.Security.Domain.Models;

namespace ZenDriver.API.Settings.Resources;
public class SocialNetworkResource
{
    public int Id { get; set; }
    public string NameSocialNetwork { get; set; }
    public string UrlSocialNetwork { get; set; }

    //Relationships
    public User User { get; set; }
}
