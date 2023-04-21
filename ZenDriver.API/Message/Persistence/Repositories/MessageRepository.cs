using ZenDriver.API.Message.Domain.Repositories;
using ZenDriver.API.Shared.Persistence.Repositories;
using ZenDriver.API.Shared.Persistence.Contexts;
using ZenDriver.API.Message.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ZenDriver.API.Message.Persistence.Repositories
{
    public class MessageRepository : BaseRepository, IMessageRepository
    {
        public MessageRepository(AppDbContext context) : base(context)
        {
            
        }

        public async Task<IEnumerable<Message>> GetMessagesAsync()
        {
            return await _context.Messages.ToListAsync();
        }

        public async Task AddMessageAsync(Message message)
        {
            await _context.Messages.AddAsync(message);
        }

        public async Task<Message> FindMessageByIdAsync(int id)
        {
            return await _context.Messages.FindAsync(id);
        }
 
    }
}