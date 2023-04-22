using ZenDriver.API.Settings.Domain.Models;

namespace ZenDriver.API.Settings.Resources;
public class EducationResource
{
    public int Id { get; set; }
    public string Grade_education { get; set; }

    public Driverprofile Driverprofile { get; set; }

}
