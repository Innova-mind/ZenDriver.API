using ZenDriver.API.Message.Domain.Models;
using ZenDriver.API.Message.Domain.Services.Communication;

namespace ZenDriver.API.Message.Domain.Services;

public interface IMessageService
{     
    Task<IEnumerable<Models.Message>> GetMessagesAsync();

    Task<MessageResponse> AddMessageAsync(Models.Message message);
}