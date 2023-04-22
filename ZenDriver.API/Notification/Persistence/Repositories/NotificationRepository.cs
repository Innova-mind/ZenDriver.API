using ZenDriver.API.Shared.Persistence.Contexts;
using ZenDriver.API.Shared.Persistence.Repositories;

using Microsoft.EntityFrameworkCore;
using ZenDriver.API.Notification.Domain.Models;
using ZenDriver.API.Notification.Domain.Repositories;

namespace ZenDriver.API.Notification.Persistence.Repositories
{

    public class NotificationRepository : BaseRepository, INotificationRepository
    {
        public NotificationRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Domain.Models.Notification>> GetNotificationsAsync()
        {
            return await _context.Notifications.Include(p => p.Emitter).Include(q => q.Receiver).ToListAsync();
        }

        public async Task AddNotificationAsync(Domain.Models.Notification notification)
        {
            await _context.Notifications.AddAsync(notification);
        }

        public async Task<Domain.Models.Notification> FindNotificationByIdAsync(int id)
        {
            return await _context.Notifications.FindAsync(id);
        }
               
        public void Remove(Domain.Models.Notification notification)
        {
            _context.Notifications.Remove(notification);
        }

    }
}