using ZenDriver.API.Settings.Domain.Models;
using ZenDriver.API.Settings.Domain.Services.Communication;

namespace ZenDriver.API.Settings.Domain.Services;

public interface IPostService
{
    Task<IEnumerable<Post>> ListAsync();
    Task<PostResponse> SaveAsync(Post post);
    Task<PostResponse> UpdateAsync(int id, Post post);
    Task<PostResponse> DeleteAsync(int id);
}