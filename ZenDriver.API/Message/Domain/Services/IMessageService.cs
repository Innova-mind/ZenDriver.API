using ZenDriver.API.Message.Domain.Models;
using ZenDriver.API.Message.Domain.Services.Communication;

namespace ZenDriver.API.Message.Domain.Services;

public interface IMessageService
{     
    Task<IEnumerable<Message>> GetMessagesAsync();

    Task<MessageResponse> AddMessageAsync(Message message);
}