using ZenDriver.API.Settings.Domain.Models;

namespace ZenDriver.API.Settings.Domain.Repositories;
public interface IDriverprofileRepository
{
    Task<IEnumerable<Driverprofile>> ListAsync();
    Task AddAsync(Driverprofile driverprofile);
    Task<Driverprofile> FindByIdAsync(int id);
    void Update(Driverprofile driverprofile);
    void Remove(Driverprofile driverprofile);
    Task<Driverprofile> FindByDriverIdAsync(int DriverId);
}
