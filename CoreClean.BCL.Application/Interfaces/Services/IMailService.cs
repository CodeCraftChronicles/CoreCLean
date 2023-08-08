

using CoreClean.BCL.Application.Requests.Mail;

namespace CoreClean.BCL.Application.Interfaces.Services;

public interface IMailService
{
    Task SendAsync(MailRequest request);
}