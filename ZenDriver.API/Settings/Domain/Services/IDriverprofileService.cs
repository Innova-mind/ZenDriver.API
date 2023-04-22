using ZenDriver.API.Settings.Domain.Models;
using ZenDriver.API.Settings.Domain.Services.Communication;

namespace ZenDriver.API.Settings.Domain.Services;
public interface IDriverprofileService
{
    Task<IEnumerable<Driverprofile>> ListAsync();
    
    Task<DriverprofileResponse> SaveAsync(Driverprofile Driverprofile);
    Task<DriverprofileResponse> UpdateAsync(int userId, Driverprofile Driverprofile);
    Task<DriverprofileResponse> DeleteAsync(int userId);
    Task<Driverprofile> GetByDriveridAsync(int driverid);
}
