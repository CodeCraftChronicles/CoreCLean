using CoreClean.BCL.Application.Interfaces.Common;
using CoreClean.BCL.Application.Requests.Identity;
using CoreClean.BCL.Application.Responses.Identity;
using CoreClean.BCL.Shared.Wrappers;

namespace CoreClean.BCL.Application.Interfaces.Services.Identity;

public interface IRoleClaimService : IService
{
    Task<Result<List<RoleClaimResponse>>> GetAllAsync();

    Task<int> GetCountAsync();

    Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

    Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

    Task<Result<string>> SaveAsync(RoleClaimRequest request);

    Task<Result<string>> DeleteAsync(int id);
}