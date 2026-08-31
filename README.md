[![](https://img.shields.io/nuget/v/soenneker.netlify.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.netlify.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.netlify.httpclients/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.netlify.httpclients/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.netlify.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.netlify.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.netlify.httpclients/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.netlify.httpclients/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Netlify.HttpClients

Provides a cached, authenticated `HttpClient` for the Netlify API.

## Installation

```bash
dotnet add package Soenneker.Netlify.HttpClients
```

## Configuration

```json
{
  "Netlify": {
    "ApiKey": "your-access-token"
  }
}
```

`Netlify:ClientBaseUrl` can override the default `https://api.netlify.com/api/v1` endpoint. `Netlify:AuthHeaderName` and `Netlify:AuthHeaderValueTemplate` can override the default bearer header.

## Usage

```csharp
using Soenneker.Netlify.HttpClients.Abstract;
using Soenneker.Netlify.HttpClients.Registrars;

services.AddNetlifyOpenApiHttpClientAsSingleton();

INetlifyOpenApiHttpClient netlify = serviceProvider
    .GetRequiredService<INetlifyOpenApiHttpClient>();

HttpClient client = await netlify.Get(cancellationToken);
```

Do not dispose the returned `HttpClient`; the registered provider owns it and removes it from the cache when disposed.
