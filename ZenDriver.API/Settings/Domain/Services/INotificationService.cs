using ZenDriver.API.Settings.Domain.Models;
using ZenDriver.API.Settings.Domain.Services.Communication;

namespace ZenDriver.API.Settings.Domain.Services;

public interface INotificationService
{
    Task<IEnumerable<Notification>> GetNotificationsAsync();
    Task<NotificationResponse> AddNotificationAsync(Notification notification);    
    Task<NotificationResponse> DeleteAsync(int id);

}