using ZenDriver.API.Settings.Domain.Models;

namespace ZenDriver.API.Settings.Domain.Repositories;

public interface IPostRepository
{
    Task<IEnumerable<Post>> ListAsync();
    Task AddAsync(Post post);
    Task<Post> FindByIdAsync(int id);
    void Update(Post post);
    void Remove(Post post);
}