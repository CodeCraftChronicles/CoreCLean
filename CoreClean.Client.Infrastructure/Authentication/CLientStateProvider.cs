using CoreClean.BCL.Shared.Interfaces;

namespace CoreClean.Client.Infrastructure.Authentication;

public class CLientStateProvider
{
    private readonly HttpClient _httpClient;
    private readonly IClientSideStringStorageService _stoageService;
    public CLientStateProvider(HttpClient httpClient, IClientSideStringStorageService storageService)
    {
        _httpClient = httpClient;
        _stoageService = storageService;
    }

}
