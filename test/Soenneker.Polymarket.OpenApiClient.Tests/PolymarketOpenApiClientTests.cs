using Soenneker.Tests.HostedUnit;

namespace Soenneker.Polymarket.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class PolymarketOpenApiClientTests : HostedUnitTest
{
    public PolymarketOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
