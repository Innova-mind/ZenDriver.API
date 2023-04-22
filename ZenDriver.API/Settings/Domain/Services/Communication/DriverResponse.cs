using ZenDriver.API.Shared.Domain.Services.Communication;
using ZenDriver.API.Settings.Domain.Models;

namespace ZenDriver.API.Settings.Domain.Services.Communication;
 public class DriverResponse : BaseResponse<Driver>
{
    public DriverResponse(string message) : base (message)
    {

    }

    public DriverResponse(Driver resource) : base (resource)
    {

    }
}