using ZenDriver.API.DriverProfile.Domain.Communication.Models;

namespace ZenDriver.API.DriverProfile.Domain.Repositories;
public interface IDriverprofileRepository
{
    Task<IEnumerable<Driverprofile>> ListAsync();
    Task AddAsync(Driverprofile driverprofile);
    Task<Driverprofile> FindByIdAsync(int id);
    void Update(Driverprofile driverprofile);
    void Remove(Driverprofile driverprofile);
}
