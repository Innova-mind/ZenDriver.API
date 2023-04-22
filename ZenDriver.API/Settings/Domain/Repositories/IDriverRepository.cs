using ZenDriver.API.Settings.Domain.Models;

namespace ZenDriver.API.Settings.Domain.Repositories;
public interface IDriverRepository
{
    Task<IEnumerable<Driver>> ListAsync();
    Task AddAsync(Driver driver);
    Task<Driver> FindByIdAsync(int id);
    Driver FindById(int id);
    void Update(Driver driver);
    void Remove(Driver driver);
    Task<Driver> FindByUserIdAsync(int UserId);
}
