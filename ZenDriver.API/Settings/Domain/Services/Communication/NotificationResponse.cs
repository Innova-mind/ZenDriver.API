using ZenDriver.API.Shared.Domain.Services.Communication;
using ZenDriver.API.Settings.Domain.Models;

namespace ZenDriver.API.Settings.Domain.Services.Communication;

public class NotificationResponse : BaseResponse<Notification>

{
    public NotificationResponse(string notification) : base(notification)
    {
    }
    
    public NotificationResponse(Notification resource) : base(resource)
    {
    }
}