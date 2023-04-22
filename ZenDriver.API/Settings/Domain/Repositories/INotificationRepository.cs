using ZenDriver.API.Settings.Domain.Models;

namespace ZenDriver.API.Settings.Domain.Repositories;

public interface INotificationRepository
{
    Task<IEnumerable<Notification>> GetNotificationsAsync();
    Task AddNotificationAsync(Notification notification);
    Task<Notification> FindNotificationByIdAsync(int notificationId);    
    void Remove(Notification notification);

}