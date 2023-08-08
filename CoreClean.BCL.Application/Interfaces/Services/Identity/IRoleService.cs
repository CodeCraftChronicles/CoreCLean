using CoreClean.BCL.Application.Interfaces.Common;
using CoreClean.BCL.Application.Requests.Identity;
using CoreClean.BCL.Application.Responses.Identity;
using CoreClean.BCL.Shared.Wrappers;

namespace CoreClean.BCL.Application.Interfaces.Services.Identity
{
    public interface IRoleService : IService
    {
        Task<Result<List<RoleResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleResponse>> GetByIdAsync(string id);

        Task<Result<string>> SaveAsync(RoleRequest request);

        Task<Result<string>> DeleteAsync(string id);

        Task<Result<PermissionResponse>> GetAllPermissionsAsync(string roleId);

        Task<Result<string>> UpdatePermissionsAsync(PermissionRequest request);
    }
}