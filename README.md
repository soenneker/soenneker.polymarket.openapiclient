[![](https://img.shields.io/nuget/v/soenneker.polymarket.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.polymarket.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.polymarket.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.polymarket.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.polymarket.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.polymarket.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.polymarket.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.polymarket.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Polymarket.OpenApiClient

Generated request builders and models for Polymarket's Gamma, Data, CLOB, Bridge, Perpetuals, RFQ, and Relayer APIs.

## Installation

```bash
dotnet add package Soenneker.Polymarket.OpenApiClient
```

## Usage

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Polymarket.OpenApiClient;

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider());
var client = new PolymarketOpenApiClient(adapter);

var events = await client.Gamma.Events
    .WithUrl("https://gamma-api.polymarket.com/events?limit=5")
    .GetAsync(cancellationToken: cancellationToken);
```

Polymarket exposes these APIs on different hosts. Because the combined schema namespaces paths by source API, direct use of this generated package should select the actual host with `WithUrl`. `Soenneker.Polymarket.OpenApiClientUtil` provides automatic host routing for the fluent `Gamma`, `Data`, `Clob`, `Bridge`, `Perps`, `CombosRfq`, and `Relayer` builders.

Public market-data endpoints require no credentials. Private trading and relayer operations require Polymarket-specific headers and request signatures supplied by the caller.
