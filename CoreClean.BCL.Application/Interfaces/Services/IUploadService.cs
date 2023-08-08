using CoreClean.BCL.Application.Requests;

namespace CoreClean.BCL.Application.Interfaces.Services;

public interface IUploadService
{
    string UploadAsync(UploadRequest request);
}