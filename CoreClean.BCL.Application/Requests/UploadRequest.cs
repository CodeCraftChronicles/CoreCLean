using CoreClean.BCL.Shared.Enums;

namespace CoreClean.BCL.Application.Requests;

public class UploadRequest
{
    public string FileName { get; set; } = string.Empty;
    public string Extension { get; set; } = string.Empty;
    public UploadType UploadType { get; set; }
    public byte[] Data { get; set; } =new byte[0];
}