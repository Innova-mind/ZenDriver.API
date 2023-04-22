using ZenDriver.API.Settings.Domain.Models;
using ZenDriver.API.Settings.Domain.Services.Communication;

namespace ZenDriver.API.Settings.Domain.Services;
public interface ISocialNetworkService
{
    Task<IEnumerable<SocialNetwork>> ListAsync();
    Task<SocialNetworkResponse> SaveAsync(SocialNetwork socialNetwork);
    Task<SocialNetworkResponse> UpdateAsync(int id, SocialNetwork socialNetwork);
    Task<SocialNetworkResponse> DeleteAsync(int id);
}
