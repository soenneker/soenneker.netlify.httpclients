using Soenneker.Netlify.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Netlify.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class NetlifyOpenApiHttpClientTests : HostedUnitTest
{
    private readonly INetlifyOpenApiHttpClient _httpclient;

    public NetlifyOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<INetlifyOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
