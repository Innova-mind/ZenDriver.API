using ZenDriver.API.Settings.Domain.Models;

namespace ZenDriver.API.Settings.Resources;

public class DriverprofileResource
{
    public int Id { get; set; }
    

    public Driver Driver { get; set; }

    public License License { get; set; }
}