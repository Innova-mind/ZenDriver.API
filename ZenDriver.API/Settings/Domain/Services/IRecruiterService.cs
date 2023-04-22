using ZenDriver.API.Settings.Domain.Models;
using ZenDriver.API.Settings.Domain.Services.Communication;

namespace ZenDriver.API.Settings.Domain.Services;

public interface IRecruiterService
{
    Task<IEnumerable<Recruiter>> ListAsync();
    Task<RecruiterResponse> SaveAsync(Recruiter recruiter);
    Task<RecruiterResponse> UpdateAsync(int id, Recruiter recruiter);
    Task<RecruiterResponse> DeleteAsync(int id);
}