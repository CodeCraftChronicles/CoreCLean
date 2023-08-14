using CoreClean.BCL.Shared.Constants.Storage;
using CoreClean.BCL.Shared.Interfaces;

using System.Net.Http.Headers;

namespace CoreClean.Client.Infrastructure.Authentication;

public class AuthenticationHeaderHandler : DelegatingHandler
{
    private readonly IClientSideStringStorageService localStorage;

    public AuthenticationHeaderHandler(IClientSideStringStorageService localStorage)
        => this.localStorage = localStorage;

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        if (request.Headers.Authorization?.Scheme != "Bearer")
        {
            var savedToken = await this.localStorage.GetItemAsync(StorageConstants.Local.AuthToken);

            if (!string.IsNullOrWhiteSpace(savedToken))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", savedToken);
            }
        }

        return await base.SendAsync(request, cancellationToken);
    }
}
