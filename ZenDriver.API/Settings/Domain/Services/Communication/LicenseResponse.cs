using ZenDriver.API.Shared.Domain.Services.Communication;
using ZenDriver.API.Settings.Domain.Models;

namespace ZenDriver.API.Settings.Domain.Services.Communication;
 public class LicenseResponse : BaseResponse<License>
{
    public LicenseResponse(string message) : base (message)
    {

    }

    public LicenseResponse(License resource) : base (resource)
    {

    }
}