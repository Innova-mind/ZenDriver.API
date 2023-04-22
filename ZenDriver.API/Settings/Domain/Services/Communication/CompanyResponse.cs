using ZenDriver.API.Shared.Domain.Services.Communication;
using ZenDriver.API.Settings.Domain.Models;

namespace ZenDriver.API.Settings.Domain.Services.Communication;

public class CompanyResponse : BaseResponse<Company>
{
    public CompanyResponse(Company resource) : base(resource)
    {
    }
    
    public CompanyResponse(string message) : base(message)
    {
    }
}