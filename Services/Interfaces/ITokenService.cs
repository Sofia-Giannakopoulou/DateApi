using DateApi.Entities;

namespace DateApi.Services.Interfaces;

public interface ITokenService
{
    Task<string> CreateToken(AppUser user);
}
