using ZenDriver.API.ApplyForJob.Domain.Models;
using ZenDriver.API.Shared.Domain.Services.Communication;
namespace ZenDriver.API.ApplyForJob.Domain.Services.Communication;
public class SocialNetworkResponse : BaseResponse<SocialNetwork>
{
    public SocialNetworkResponse(string message) : base(message)
    {

    }

    public SocialNetworkResponse(SocialNetwork resource) : base(resource)
    {

    }
}