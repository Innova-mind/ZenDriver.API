using ZenDriver.API.Settings.Domain.Models;
using ZenDriver.API.Settings.Domain.Services.Communication;

namespace ZenDriver.API.Settings.Domain.Services;

 public interface IMessageService
 {
     Task<IEnumerable<Message>> GetMessagesAsync();

     Task<MessageResponse> AddMessageAsync(Message message);

     Task<IEnumerable<Message>> GetLastMessageRecruiter(int id);

     Task<IEnumerable<Message>> GetLastMessageDriver(int id);
}

