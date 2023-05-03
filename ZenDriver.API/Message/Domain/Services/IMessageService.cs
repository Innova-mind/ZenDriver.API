using ZenDriver.API.Message.Domain.Models;
using ZenDriver.API.Message.Domain.Services.Communication;

namespace ZenDriver.API.Message.Domain.Services;

public interface IMessageService
{     
    Task<IEnumerable<MessageZenDriver>> GetMessagesAsync();

    Task<MessageResponse> AddMessageAsync(MessageZenDriver message);
    Task<IEnumerable<MessageZenDriver>> GetMessagesByEmitterIdAsync(int emitterId);
}