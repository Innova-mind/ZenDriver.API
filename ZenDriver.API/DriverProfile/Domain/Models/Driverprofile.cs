using ZenDriver.API.DriverProfile.Domain.Models;

namespace ZenDriver.API.DriverProfile.Domain.Communication.Models;
public class Driverprofile
{
    public int Id { get; set; }
    

    //Relationships
    public int DriverId { get; set; }
    public Driver Driver { get; set; }

    public int LicenseId { get; set; }
    public License License { get; set; }
    //public Education Education { get; set; }
}