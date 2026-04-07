using Soenneker.Netlify.HttpClients.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Netlify.HttpClients.Tests;

[Collection("Collection")]
public sealed class NetlifyOpenApiHttpClientTests : FixturedUnitTest
{
    private readonly INetlifyOpenApiHttpClient _httpclient;

    public NetlifyOpenApiHttpClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _httpclient = Resolve<INetlifyOpenApiHttpClient>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
