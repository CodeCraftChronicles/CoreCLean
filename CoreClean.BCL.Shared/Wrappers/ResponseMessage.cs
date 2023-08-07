using CoreClean.BCL.Shared.Interfaces;

namespace CoreClean.BCL.Shared.Wrappers;

public class ResponseMessage : IDetailedMessage
{
    public ResponseMessage()
    {
        Message = string.Empty;
        Link = default;
    }
    public ResponseMessage(string message)
    {
        Message = message;
        Link = null;
    }
    public ResponseMessage(string message, string link)
    {
        Message = message;
        Link = link;
    }

    public string Message { get; set; }
    public string? Link { get; set; } = null;
}