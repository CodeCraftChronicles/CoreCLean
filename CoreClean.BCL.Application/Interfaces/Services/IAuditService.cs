using CoreClean.BCL.Application.Responses.Audit;
using CoreClean.BCL.Shared.Interfaces;

namespace CoreClean.BCL.Application.Interfaces.Services;

public interface IAuditService
{
    Task<IResult<IEnumerable<AuditResponse>>> GetCurrentUserTrailsAsync(string userId);

    Task<IResult<string>> ExportToExcelAsync(string userId, string searchString = "", bool searchInOldValues = false, bool searchInNewValues = false);
}