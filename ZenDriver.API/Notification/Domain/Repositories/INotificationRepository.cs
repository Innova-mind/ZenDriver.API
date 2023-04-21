using ZenDriver.API.Notification.Domain.Models;

namespace ZenDriver.API.Notification.Domain.Repositories;

public interface INotificationRepository
{
    Task<IEnumerable<Models.Notification>> GetNotificationsAsync();
    Task AddNotificationAsync(Models.Notification notification);
    Task<Models.Notification> FindNotificationByIdAsync(int notificationId);    
    void Remove(Models.Notification notification);

}