using CoreClean.BCL.Application.Requests.Identity;
using CoreClean.BCL.Application.Responses.Identity;
using CoreClean.BCL.Shared.Interfaces;
using CoreClean.Client.Infrastructure.Managers;

namespace BlazorHero.CleanArchitecture.Client.Infrastructure.Managers.Identity.RoleClaims
{
    public interface IRoleClaimManager : IManager
    {
        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsAsync();

        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsByRoleIdAsync(string roleId);

        Task<IResult<string>> SaveAsync(RoleClaimRequest role);

        Task<IResult<string>> DeleteAsync(string id);
    }
}