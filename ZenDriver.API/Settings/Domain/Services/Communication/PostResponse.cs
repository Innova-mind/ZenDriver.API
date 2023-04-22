using ZenDriver.API.Shared.Domain.Services.Communication;
using ZenDriver.API.Settings.Domain.Models;

namespace ZenDriver.API.Settings.Domain.Services.Communication;

public class PostResponse : BaseResponse<Post>
{
    public PostResponse(Post resource) : base(resource)
    {
    }
    
    public PostResponse(string message) : base(message)
    {
    }
}