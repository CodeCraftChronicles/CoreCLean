namespace CoreClean.Client.Infrastructure.Services;

public interface IRefreshService
{
    event Action RefreshRequested;
    void CallRequestRefresh();
}

public class RefreshService : IRefreshService
{

    public RefreshService()
    {

    }
    public string currentUserNif { get; set; } = string.Empty;
    public bool IsContribuable()
    {
        return currentUserNif != string.Empty;
    }
    private static RefreshService refreshservice;
    public event Action RefreshRequested;
    public async void CallRequestRefresh()
    {
        RefreshRequested?.Invoke();
    }
    
    public static RefreshService Instance()
    {
        if (refreshservice == null)
        {
            refreshservice = new RefreshService();
        }
        return refreshservice;

    }
}
