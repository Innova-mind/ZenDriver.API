using ZenDriver.API.Settings.Domain.Models;

namespace ZenDriver.API.Settings.Domain.Repositories;
public interface ISocialNetworkRepository
{
    Task<IEnumerable<SocialNetwork>> ListAsync();
    Task AddAsync(SocialNetwork socialNetowork);
    Task<SocialNetwork> FindByIdAsync(int id);
    void Update(SocialNetwork socialNetowork);
    void Remove(SocialNetwork socialNetowork);
}
