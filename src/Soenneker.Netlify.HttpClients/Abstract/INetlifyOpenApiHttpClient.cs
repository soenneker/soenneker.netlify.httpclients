using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.Netlify.HttpClients.Abstract;

/// <summary>
/// Provides a cached, authenticated HTTP client for the Netlify API.
/// </summary>
public interface INetlifyOpenApiHttpClient : IDisposable, IAsyncDisposable
{
    /// <summary>
    /// Gets the configured Netlify HTTP client.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The cached client.</returns>
    ValueTask<HttpClient> Get(CancellationToken cancellationToken = default);
}
