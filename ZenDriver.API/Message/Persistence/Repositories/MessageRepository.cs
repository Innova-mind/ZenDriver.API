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

        public async Task<IEnumerable<MessageZenDriver>> GetMessagesAsync()
        {
            return await _context.Messages.Include(p => p.Emitter).Include(q => q.Receiver).ToListAsync();
        }

        public async Task AddMessageAsync(MessageZenDriver message)
        {
            await _context.Messages.AddAsync(message);
        }

        public async Task<MessageZenDriver> FindMessageByIdAsync(int id)
        {
            return await _context.Messages.FindAsync(id);
        }

        public async Task<IEnumerable<MessageZenDriver>> GetLastMessageRecruiter(int id)
        {
            var lastMessage = await _context.Messages.FromSqlInterpolated($"SELECT * FROM messages m WHERE id IN (SELECT MAX(id) FROM messages WHERE emitter_id = {id} GROUP BY receiver_id)").Include(p => p.Receiver).ToListAsync();
            return lastMessage;
        }

        public async Task<IEnumerable<MessageZenDriver>> GetLastMessageDriver(int id)
        {
            var lastMessage = await _context.Messages.FromSqlInterpolated($"SELECT * FROM messages m WHERE id IN (SELECT MAX(id) FROM messages WHERE receiver_id = {id} GROUP BY emitter_id)").Include(p => p.Emitter).ToListAsync();
            return lastMessage;
        }
    }
}