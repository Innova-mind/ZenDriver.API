using ZenDriver.API.Notification.Domain.Models;
using ZenDriver.API.Notification.Domain.Services.Communication;

namespace ZenDriver.API.Notification.Domain.Services;

public interface INotificationService
{
    Task<IEnumerable<Models.Notification>> GetNotificationsAsync();
    Task<NotificationResponse> AddNotificationAsync(Models.Notification notification);    
    Task<NotificationResponse> DeleteAsync(int id);

}