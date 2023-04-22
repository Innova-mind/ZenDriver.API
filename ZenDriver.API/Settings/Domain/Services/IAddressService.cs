using ZenDriver.API.Settings.Domain.Models;
using ZenDriver.API.Settings.Domain.Services.Communication;

namespace ZenDriver.API.Settings.Domain.Services;
public interface IAddressService
{
    Task<IEnumerable<Address>> ListAsync();
    Task<IEnumerable<Address>> ListByUserIdAsync(int userId);
    Task<AddressResponse> SaveAsync(Address address);
    Task<AddressResponse> UpdateAsync(int userId, Address address);
    Task<AddressResponse> DeleteAsync(int userId);
}
