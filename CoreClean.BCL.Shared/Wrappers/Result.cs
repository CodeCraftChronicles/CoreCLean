using CoreClean.BCL.Shared.Interfaces;

namespace CoreClean.BCL.Shared.Wrappers;
public class ResponseMessage : IDetailedMessage
{
    public ResponseMessage()
    {
        Message = string.Empty;
        Link = default;
    }
    public ResponseMessage(string message, string? link = null)
    {
        Message = message;
        Link = link;
    }

    public string Message { get; set; }
    public string? Link { get; set; } = null;
}
public class Result : IResult
{
    public Result()
    {
    }

    public List<IDetailedMessage> Messages { get; set; } = new();

    public bool Succeeded { get; set; }

    public static IResult Fail()
    {
        return new Result { Succeeded = false };
    }

    public static IResult Fail(string message)
    {
        return new Result { Succeeded = false, Messages = new() { new ResponseMessage(message) } };
    }
    public static IResult Fail(string message, string url)
    {
        return new Result { Succeeded = false, Messages = new() { new ResponseMessage(message, url) } };
    }
    public static IResult Fail(List<string> messages)
    {
        return new Result { Succeeded = false, Messages = new List<IDetailedMessage>(messages.Select(message => new ResponseMessage(message))) };
    }
    public static IResult Fail(List<IDetailedMessage> messages)
    {
        return new Result { Succeeded = false, Messages = messages };
    }

    public static Task<IResult> FailAsync()
    {
        return Task.FromResult(Fail());
    }

    public static Task<IResult> FailAsync(string message)
    {
        return Task.FromResult(Fail(message));
    }
    public static Task<IResult> FailAsync(string message, string url)
    {
        return Task.FromResult(Fail(message, url));
    }
    public static Task<IResult> FailAsync(List<string> messages)
    {
        return Task.FromResult(Fail(messages));
    }
    public static Task<IResult> FailAsync(List<IDetailedMessage> messages)
    {
        return Task.FromResult(Fail(messages));
    }

    public static IResult Success()
    {
        return new Result { Succeeded = true };
    }

    public static IResult Success(string message)
    {
        return new Result { Succeeded = true, Messages = new () {new ResponseMessage(message) } };
    }

    public static Task<IResult> SuccessAsync()
    {
        return Task.FromResult(Success());
    }

    public static Task<IResult> SuccessAsync(string message)
    {
        return Task.FromResult(Success(message));
    }

}

public class Result<T> : Result, IResult<T>
{
    public Result()
    {
    }

    public T Data { get; set; }

    public new static Result<T> Fail()
    {
        return new Result<T> { Succeeded = false };
    }

    public new static Result<T> Fail(string message)
    {
        return new Result<T> { Succeeded = false, Messages = new() { new ResponseMessage(message) } };
    }

    public new static Result<T> Fail(List<string> messages)
    {
      
        return new Result<T> { Succeeded = false, Messages = new List<IDetailedMessage>(messages.Select(message => new ResponseMessage(message)))};
    }

    public new static Task<Result<T>> FailAsync()
    {
        return Task.FromResult(Fail());
    }

    public new static Task<Result<T>> FailAsync(string message)
    {
        return Task.FromResult(Fail(message));
    }

    public new static Task<Result<T>> FailAsync(List<string> messages)
    {
        return Task.FromResult(Fail(messages));
    }

    public new static Result<T> Success()
    {
        return new Result<T> { Succeeded = true };
    }

    public new static Result<T> Success(string message)
    {
        return new Result<T> { Succeeded = true, Messages = new List<IDetailedMessage> { new ResponseMessage(message) } };
    }

    public static Result<T> Success(T data)
    {
        return new Result<T> { Succeeded = true, Data = data };
    }

    public static Result<T> Success(T data, string message)
    {
        return new Result<T> { Succeeded = true, Data = data,Messages= new List<IDetailedMessage> { new ResponseMessage(message) } };
    }

    public static Result<T> Success(T data, List<string> messages)
    {
        return new Result<T> { Succeeded = true, Data = data, Messages = new List<IDetailedMessage>(messages.Select(message => new ResponseMessage(message))) };
    }

    public new static Task<Result<T>> SuccessAsync()
    {
        return Task.FromResult(Success());
    }

    public new static Task<Result<T>> SuccessAsync(string message)
    {
        return Task.FromResult(Success(message));
    }

    public static Task<Result<T>> SuccessAsync(T data)
    {
        return Task.FromResult(Success(data));
    }

    public static Task<Result<T>> SuccessAsync(T data, string message)
    {
        return Task.FromResult(Success(data, message));
    }
}