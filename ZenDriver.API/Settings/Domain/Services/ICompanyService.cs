using ZenDriver.API.Settings.Domain.Models;
using ZenDriver.API.Settings.Domain.Services.Communication;

namespace ZenDriver.API.Settings.Domain.Services;

public interface ICompanyService
{
    Task<IEnumerable<Company>> ListAsync();
    Task<Company> FindByIdAsync(int id);
    Task<CompanyResponse> SaveAsync(Company company);
    Task<CompanyResponse> UpdateAsync(int id, Company company);
    Task<CompanyResponse> DeleteAsync(int id);
}