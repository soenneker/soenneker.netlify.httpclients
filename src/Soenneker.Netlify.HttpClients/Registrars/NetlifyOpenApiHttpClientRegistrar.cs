using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Netlify.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.Netlify.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class NetlifyOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="NetlifyOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddNetlifyOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<INetlifyOpenApiHttpClient, NetlifyOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="NetlifyOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddNetlifyOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<INetlifyOpenApiHttpClient, NetlifyOpenApiHttpClient>();

        return services;
    }
}
