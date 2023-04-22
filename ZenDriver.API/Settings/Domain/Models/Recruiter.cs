using System.Text.Json.Serialization;
using ZenDriver.API.Security.Domain.Models;

namespace ZenDriver.API.Settings.Domain.Models;

public class Recruiter
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int CompanyId { get; set; }
    
    [JsonIgnore]
    public User User { get; set; }
    [JsonIgnore]
    public Company Company { get; set; }
    [JsonIgnore]
    public IEnumerable<Post> Posts { get; set; }
}