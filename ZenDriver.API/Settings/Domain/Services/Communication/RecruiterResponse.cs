using ZenDriver.API.Shared.Domain.Services.Communication;
using ZenDriver.API.Settings.Domain.Models;

namespace ZenDriver.API.Settings.Domain.Services.Communication;

public class RecruiterResponse : BaseResponse<Recruiter>
{
    public RecruiterResponse(string message) : base(message)
    {
    }

    public RecruiterResponse(Recruiter resource) : base(resource)
    {
    }
}