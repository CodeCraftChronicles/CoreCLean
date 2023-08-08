using CoreClean.BCL.Application.Interfaces.Common;
using CoreClean.BCL.Application.Requests.Identity;
using CoreClean.BCL.Application.Responses.Identity;
using CoreClean.BCL.Shared.Wrappers;

namespace CoreClean.BCL.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}