namespace CoreClean.BCL.Shared.Interfaces;

public interface IDetailedMessage
{
    
    string Message { get; set; } 
    string? Link { get; set; }
}

public interface IResult
{
    List<IDetailedMessage> Messages { get; set; }

    bool Succeeded { get; set; }
}

public interface IResult<out T> : IResult
{
    T Data { get; }
}


