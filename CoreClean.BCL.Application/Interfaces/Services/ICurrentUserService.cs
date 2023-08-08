using CoreClean.BCL.Application.Interfaces.Common;

namespace CoreClean.BCL.Application.Interfaces.Services;

public interface ICurrentUserService : IService
{
    string UserId { get; }
}