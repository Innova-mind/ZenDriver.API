
namespace ZenDriver.API.DriverProfile.Domain.Models;
public class License
{
    public int Id { get; set; }

    public string Gategory { get;set;}
    public string Description { get; set; }

    //Relationships
    public DriverProfile DriverProfile { get; set; }

}
