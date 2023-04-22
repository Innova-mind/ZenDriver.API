using ZenDriver.API.Shared.Domain.Services.Communication;
using ZenDriver.API.Settings.Domain.Models;

namespace ZenDriver.API.Settings.Domain.Services.Communication;

 public class MessageResponse : BaseResponse<Message>
{
    public MessageResponse(string message) : base(message)
    {

    }

    public MessageResponse(Message resource) : base(resource)
    {

    }
}
