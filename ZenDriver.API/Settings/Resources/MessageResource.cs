using ZenDriver.API.Security.Domain.Models;

namespace ZenDriver.API.Settings.Resources
{
    public class MessageResource
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public User Emitter { get; set; }
        public User Receiver { get; set; }
    }
}
