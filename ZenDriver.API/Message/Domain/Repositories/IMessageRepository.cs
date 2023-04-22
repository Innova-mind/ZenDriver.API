using ZenDriver.API.Message.Domain.Models;

namespace ZenDriver.API.Message.Domain.Repositories
{
    public interface IMessageRepository
    {
        Task<IEnumerable<Message>> GetMessagesAsync();
    
        Task AddMessageAsync(Message message);

        Task<Message> FindMessageByIdAsync(int messageId);
        
        Task<IEnumerable<Message>> GetLastMessageRecruiter(int id);

        Task<IEnumerable<Message>> GetLastMessageDriver(int id);
    }
}
