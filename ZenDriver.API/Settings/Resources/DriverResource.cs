using ZenDriver.API.Security.Domain.Models;

namespace ZenDriver.API.Settings.Resources;
public class DriverResource
{
    public int Id { get; set; }
    public User User { get; set; }
}
