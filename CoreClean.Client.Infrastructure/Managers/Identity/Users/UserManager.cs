using BlazorHero.Application.Requests.Identity;
using BlazorHero.CleanArchitecture.Application.Requests.Identity;
using BlazorHero.CleanArchitecture.Application.Responses.Identity;
using BlazorHero.CleanArchitecture.Client.Infrastructure.Extensions;
using BlazorHero.CleanArchitecture.Shared.Wrapper;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorHero.CleanArchitecture.Client.Infrastructure.Managers.Identity.Users
{
    public class UserManager : IUserManager
    {
        private readonly HttpClient _httpClient;

        public UserManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult<List<UserResponse>>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync(Routes.UserEndpoints.GetAll);
            return await response.ToResult<List<UserResponse>>();
        }
        public async Task<IResult<List<UserResponse>>> GetAllFromNifAsync(string Nif)
        {
            var response = await _httpClient.GetAsync(Routes.UserEndpoints.GetAllFromNif(Nif));
            return await response.ToResult<List<UserResponse>>();
        }
        public async Task<IResult<UserResponse>> GetAsync(string userId)
        {
            var response = await _httpClient.GetAsync(Routes.UserEndpoints.Get(userId));
            return await response.ToResult<UserResponse>();
        }

        public async Task<IResult> RegisterUserAsync(RegisterRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.UserEndpoints.Register, request);
            return await response.ToResult();
        }        
        public async Task<IResult> ResendEmailNotification(ResendMailRequest resendMail)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.UserEndpoints.notification,resendMail);
            return await response.ToResult();
        }

        public async Task<IResult> ToggleUserStatusAsync(ToggleUserStatusRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.UserEndpoints.ToggleUserStatus, request);
            return await response.ToResult();
        }

        public async Task<IResult<UserRolesResponse>> GetRolesAsync(string userId)
        {
            var response = await _httpClient.GetAsync(Routes.UserEndpoints.GetUserRoles(userId));
            return await response.ToResult<UserRolesResponse>();
        }

        public async Task<IResult> UpdateRolesAsync(UpdateUserRolesRequest request)
        {
            var response = await _httpClient.PutAsJsonAsync(Routes.UserEndpoints.GetUserRoles(request.UserId), request);
            return await response.ToResult<UserRolesResponse>();
        }

        public async Task<IResult> ForgotPasswordAsync(ForgotPasswordRequest model)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.UserEndpoints.ForgotPassword, model);
            return await response.ToResult();
        }

        public async Task<IResult> ResetPasswordAsync(ResetPasswordRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.UserEndpoints.ResetPassword, request);
            return await response.ToResult();
        }

        public async Task<string> ExportToExcelAsync(string searchString = "")
        {
            var response = await _httpClient.GetAsync(string.IsNullOrWhiteSpace(searchString)
                ? Routes.UserEndpoints.Export
                : Routes.UserEndpoints.ExportFiltered(searchString));
            var data = await response.Content.ReadAsStringAsync();
            return data;
        }

        public async Task<IResult<string>> ConfirmAccount(string userId, string code)
        {
            var response = await _httpClient.GetAsync(Routes.UserEndpoints.ConfirmEmail(userId, code));

            return await response.ToResult<string>();

        }

        public async Task<IResult> DeleteUser(string userId)
        {
            var response = await _httpClient.DeleteAsync(Routes.UserEndpoints.DeleteUser(userId));
            return await response.ToResult();
        }
        public async Task<IResult<bool>> CheckNifUsers(string nif)
        {
            var response = await _httpClient.GetAsync(Routes.UserEndpoints.checkIfNifHasActiveUser(nif));
            return await response.ToResult<bool>();
        }

        public async Task<IResult<List<UserResponse>>> GetAllDemandeAsync()
        {
            var response = await _httpClient.GetAsync(Routes.UserEndpoints.GetAllDemandes);
            return await response.ToResult<List<UserResponse>>();
        }

        public async Task<IResult> CreatePrestataireVisaIntern(CreatePrestataireVisaInternRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.UserEndpoints.RegisterIntervisaProvider, request);
            return await response.ToResult();
        }

        public async Task<IResult> ValidatePrestataireVisaIntern(ValidatePrestataireVisaInternRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.UserEndpoints.ActivateInternalVisaProvider, request);
            return await response.ToResult();
        }
    }
}