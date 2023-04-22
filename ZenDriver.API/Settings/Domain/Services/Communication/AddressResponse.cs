using ZenDriver.API.Shared.Domain.Services.Communication;
using ZenDriver.API.Settings.Domain.Models;

namespace ZenDriver.API.Settings.Domain.Services.Communication;
 public class AddressResponse : BaseResponse<Address>
{
    public AddressResponse(string message) : base (message)
    {

    }

    public AddressResponse(Address resource) : base (resource)
    {

    }
}