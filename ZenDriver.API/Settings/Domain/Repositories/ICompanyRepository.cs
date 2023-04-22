using ZenDriver.API.Settings.Domain.Models;

namespace ZenDriver.API.Settings.Domain.Repositories;

public interface ICompanyRepository
{
    Task<IEnumerable<Company>> ListAsync();
    Task AddAsync(Company company);
    Task<Company> FindByIdAsync(int id);
    void Update(Company company);
    void Remove(Company company);
}