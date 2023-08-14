using BlazorHero.CleanArchitecture.Application.Requests.Identity;
using BlazorHero.CleanArchitecture.Application.Responses.Identity;
using BlazorHero.CleanArchitecture.Shared.Wrapper;

using CoreClean.Client.Infrastructure.Managers;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorHero.CleanArchitecture.Client.Infrastructure.Managers.Identity.Users
{
    public interface IUserManager : IManager
    {
        Task<IResult<List<UserResponse>>> GetAllAsync();
        Task<IResult<List<UserResponse>>> GetAllDemandeAsync();
        Task<IResult<List<UserResponse>>> GetAllFromNifAsync(string Nif);

        Task<IResult> ForgotPasswordAsync(ForgotPasswordRequest request);

        Task<IResult> ResetPasswordAsync(ResetPasswordRequest request);

        Task<IResult<UserResponse>> GetAsync(string userId);

        Task<IResult<UserRolesResponse>> GetRolesAsync(string userId);

        Task<IResult> RegisterUserAsync(RegisterRequest request);
        Task<IResult> ResendEmailNotification(ResendMailRequest email);
        Task<IResult> CreatePrestataireVisaIntern(CreatePrestataireVisaInternRequest request);
        Task<IResult> ValidatePrestataireVisaIntern(ValidatePrestataireVisaInternRequest request);
        Task<IResult> DeleteUser(string userId);

        Task<IResult> ToggleUserStatusAsync(ToggleUserStatusRequest request);

        Task<IResult> UpdateRolesAsync(UpdateUserRolesRequest request);

        Task<IResult<string>> ConfirmAccount(string userId, string code);

        Task<string> ExportToExcelAsync(string searchString = "");
        Task<IResult<bool>> CheckNifUsers(string nif);
    }
}