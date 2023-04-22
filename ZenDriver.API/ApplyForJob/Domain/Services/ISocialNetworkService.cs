using ZenDriver.API.ApplyForJob.Domain.Models;
using ZenDriver.API.ApplyForJob.Domain.Services.Communication;

namespace ZenDriver.API.ApplyForJob.Domain.Services;
public interface ISocialNetworkService
{
    Task<IEnumerable<SocialNetwork>> ListAsync();
    Task<SocialNetworkResponse> SaveAsync(SocialNetwork socialNetwork);
    Task<SocialNetworkResponse> UpdateAsync(int id, SocialNetwork socialNetwork);
    Task<SocialNetworkResponse> DeleteAsync(int id);
}
