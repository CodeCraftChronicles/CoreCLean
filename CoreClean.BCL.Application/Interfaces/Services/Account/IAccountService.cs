using CoreClean.BCL.Application.Interfaces.Common;
using CoreClean.BCL.Application.Requests.Identity;
using CoreClean.BCL.Shared.Interfaces;

namespace CoreClean.BCL.Application.Interfaces.Services.Account
{
    public interface IAccountService : IService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}