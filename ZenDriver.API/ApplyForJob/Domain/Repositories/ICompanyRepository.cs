using ZenDriver.API.ApplyForJob.Domain.Models;

namespace ZenDriver.API.ApplyForJob.Domain.Repositories;

public interface ICompanyRepository
{
    Task<IEnumerable<Company>> ListAsync();
    Task AddAsync(Company company);
    Task<Company> FindByIdAsync(int id);
    void Update(Company company);
    void Remove(Company company);
}