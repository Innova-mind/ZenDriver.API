using ZenDriver.API.DriverProfile.Domain.Communication.Models;
using ZenDriver.API.Shared.Domain.Services.Communication;

namespace ZenDriver.API.DriverProfile.Domain.Services.Communication;
 public class DriverprofileResponse : BaseResponse<Driverprofile>
{
    public DriverprofileResponse(string message) : base (message)
    {

    }

    public DriverprofileResponse(Driverprofile resource) : base (resource)
    {

    }
}