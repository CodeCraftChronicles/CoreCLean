using CoreClean.BCL.Application.Requests.Identity;
using CoreClean.BCL.Shared.Interfaces;

namespace CoreClean.Client.Infrastructure.Managers.Identity.Account
{
    public interface IAccountManager : IManager
    {
        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model);
        Task<IResult> ChangeUserPasswordAsync(ChangeUserPasswordRequest model);

        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}