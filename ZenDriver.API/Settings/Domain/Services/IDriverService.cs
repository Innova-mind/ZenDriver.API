using ZenDriver.API.Settings.Domain.Models;
using ZenDriver.API.Settings.Domain.Services.Communication;

namespace ZenDriver.API.Settings.Domain.Services;
public interface IDriverService
{
    Task<IEnumerable<Driver>> ListAsync();
    Task<Driver> GetByIdAsync(int id);
    Task<DriverResponse> SaveAsync(Driver Driver);
    Task<DriverResponse> UpdateAsync(int id, Driver Driver);
    Task<DriverResponse> DeleteAsync(int id);
    Task<Driver> GetByUseridAsync(int userid);
}
