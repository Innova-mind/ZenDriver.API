using System.Runtime.InteropServices;
using ZenDriver.API.Shared.Persistence.Contexts;
using ZenDriver.API.Shared.Persistence.Repositories;

using Microsoft.EntityFrameworkCore;
using ZenDriver.API.Settings.Domain.Models;
using ZenDriver.API.Settings.Domain.Repositories;

namespace ZenDriver.API.Settings.Persistence.Repositories;

public class PostRepository : BaseRepository, IPostRepository
{
    public PostRepository(AppDbContext context) : base(context)
    {
    }
    
    public async Task<IEnumerable<Post>> ListAsync()
    {
        return await _context.Posts
            .Include(post => post.Recruiter)
            .ToListAsync();
    }

    public async Task AddAsync(Post post)
    {
        await _context.Posts.AddAsync(post);
    }

    public async Task<Post> FindByIdAsync(int id)
    {
        return await _context.Posts
            .Include(post => post.Recruiter)
            .FirstOrDefaultAsync(post => post.Id == id);
    }

    public void Update(Post post)
    {
        _context.Posts.Update(post);
    }

    public void Remove(Post post)
    {
        _context.Posts.Remove(post);
    }
}