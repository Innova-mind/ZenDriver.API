using ZenDriver.API.Settings.Domain.Models;

namespace ZenDriver.API.Settings.Domain.Repositories;

public interface IRecruiterRepository
{
    Task<IEnumerable<Recruiter>> ListAsync();
    Task AddAsync(Recruiter recruiter);
    Task<Recruiter> FindByIdAsync(int id);
    void Update(Recruiter recruiter);
    void Remove(Recruiter recruiter);
}