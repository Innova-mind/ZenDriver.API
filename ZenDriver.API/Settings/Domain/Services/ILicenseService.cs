using ZenDriver.API.Settings.Domain.Models;
using ZenDriver.API.Settings.Domain.Services.Communication;

namespace ZenDriver.API.Settings.Domain.Services;
public interface ILicenseService
{
    Task<IEnumerable<License>> ListAsync();
    Task<License> GetByIdAsync(int id);
    Task<LicenseResponse> SaveAsync(License License);
    Task<LicenseResponse> UpdateAsync(int userId, License License);
    Task<LicenseResponse> DeleteAsync(int userId);
}
