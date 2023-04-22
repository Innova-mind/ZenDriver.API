using ZenDriver.API.Settings.Domain.Models;

namespace ZenDriver.API.Settings.Domain.Repositories;
public interface ILicenseRepository
{
    Task<IEnumerable<License>> ListAsync();
    Task AddAsync(License license);
    Task<License> FindByIdAsync(int id);

    void Update(License license);
    void Remove(License license);
}
