using ZenDriver.API.Settings.Domain.Models;

namespace ZenDriver.API.Settings.Resources;

public class PostResource
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime date { get; set; }
    public Recruiter Recruiter { get; set; }
}