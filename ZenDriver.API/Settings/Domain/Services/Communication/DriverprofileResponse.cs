using ZenDriver.API.Shared.Domain.Services.Communication;
using ZenDriver.API.Settings.Domain.Models;

namespace ZenDriver.API.Settings.Domain.Services.Communication;
 public class DriverprofileResponse : BaseResponse<Driverprofile>
{
    public DriverprofileResponse(string message) : base (message)
    {

    }

    public DriverprofileResponse(Driverprofile resource) : base (resource)
    {

    }
}