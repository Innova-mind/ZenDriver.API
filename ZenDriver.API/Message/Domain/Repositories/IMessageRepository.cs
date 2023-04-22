using ZenDriver.API.Message.Domain.Models;

namespace ZenDriver.API.Message.Domain.Repositories;

public interface IMessageRepository
{
    Task<IEnumerable<Models.Message>> GetMessagesAsync();

    Task AddMessageAsync(Models.Message message);

    Task<Models.Message> FindMessageByIdAsync(int messageId);

    Task<IEnumerable<Models.Message>> GetLastMessageRecruiter(int id);

    Task<IEnumerable<Models.Message>> GetLastMessageDriver(int id);
}