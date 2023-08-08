using CoreClean.BCL.Application.Interfaces.Chat;
using CoreClean.BCL.Application.Models.Chat;
using CoreClean.BCL.Application.Responses.Identity;
using CoreClean.BCL.Shared.Interfaces;
using CoreClean.BCL.Shared.Wrappers;

namespace CoreClean.BCL.Application.Interfaces.Services;

public interface IChatService
{
    Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

    Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> message);

    Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
}