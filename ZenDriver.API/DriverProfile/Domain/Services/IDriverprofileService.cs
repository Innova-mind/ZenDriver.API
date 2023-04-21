using ZenDriver.API.DriverProfile.Domain.Communication.Models;
using ZenDriver.API.DriverProfile.Domain.Services.Communication;

namespace ZenDriver.API.DriverProfile.Domain.Services;
public interface IDriverprofileService
{
    Task<IEnumerable<Driverprofile>> ListAsync();
    
    Task<DriverprofileResponse> SaveAsync(Driverprofile Driverprofile);
    Task<DriverprofileResponse> UpdateAsync(int userId, Driverprofile Driverprofile);
    Task<DriverprofileResponse> DeleteAsync(int userId);
}
