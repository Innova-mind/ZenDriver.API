using ZenDriver.API.Message.Domain.Models;
using ZenDriver.API.Shared.Domain.Services.Communication;

namespace ZenDriver.API.Message.Domain.Services.Communication;

 public class MessageResponse : BaseResponse<Models.Message>
{
    public MessageResponse(string message) : base(message)
    {

    }

    public MessageResponse(Models.Message resource) : base(resource)
    {

    }
}
