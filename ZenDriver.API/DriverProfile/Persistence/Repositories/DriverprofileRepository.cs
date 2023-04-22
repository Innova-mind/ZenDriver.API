using ZenDriver.API.DriverProfile.Domain.Repositories;
using ZenDriver.API.Shared.Persistence.Contexts;
using ZenDriver.API.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using ZenDriver.API.DriverProfile.Domain.Communication.Models;

namespace ZenDriver.API.DriverProfile.Persistence.Repositories;
public class DriverprofileRepository : BaseRepository, IDriverprofileRepository
{
    public DriverprofileRepository(AppDbContext context) : base(context)
    {

    }
    
    public async Task<IEnumerable<Driverprofile>> ListAsync()
    {
        return await _context.Driverprofiles
            .Include(p => p.Driver)
            .Include(p => p.License)
            .ToListAsync();
    }

    public async Task AddAsync(Driverprofile Driverprofile)
    {
        await _context.Driverprofiles.AddAsync(Driverprofile);
    }

    public async Task<Driverprofile> FindByIdAsync(int DriverprofileId)
    {
        return await _context.Driverprofiles
            .Include(p => p.Driver)
            .Include(p => p.License)
            .FirstOrDefaultAsync(p => p.Id == DriverprofileId);
    }
    
    public void Update(Driverprofile Driverprofile)
    {
        _context.Driverprofiles.Update(Driverprofile);
    }

    public void Remove(Driverprofile Driverprofile)
    {
        _context.Driverprofiles.Remove(Driverprofile);
    }
}
