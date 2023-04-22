using ZenDriver.API.Security.Domain.Models;
using ZenDriver.API.Settings.Domain.Models;

namespace ZenDriver.API.Settings.Resources;

public class RecruiterResource
{
    public int Id { get; set; }
    public User User { get; set; }
    public Company Company { get; set; }
    public IEnumerable<Post> Posts { get; set; }
}