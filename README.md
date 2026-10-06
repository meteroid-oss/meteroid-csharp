# Meteroid .NET SDK

Meteroid API client

## Install

```sh
dotnet add package Meteroid
```

Targets .NET 8, trimming and native AOT safe. Every method of the API is listed in
[api.md](api.md).

## Usage

```csharp
using Meteroid;

using var client = new MeteroidClient("your-api-key", new MeteroidClientOptions { BaseUrl = "https://api.example.com" });

var addOn = await client.AddOns.RetrieveAsync("addon_id");
Console.WriteLine(addOn);
```

`new MeteroidClient()` reads the key from `METEROID_API_KEY`, and `METEROID_BASE_URL`
overrides the base URL; what you pass, in the constructor or in `MeteroidClientOptions`, wins.
When the API declares no default base URL, set `BaseUrl` or `METEROID_BASE_URL`: the constructor
throws a `MeteroidException` otherwise.
Create one client and reuse it: it is thread-safe and pools connections. To send requests through
your own `HttpClient`, pass it first: `new MeteroidClient(httpClient, "your-api-key")`.

Resources hang off the client as properties. Every method is async and takes an optional
`RequestOptions` (headers, timeout, retries, idempotency key) and a `CancellationToken`. Models
are records with `init` properties, compared by value:

```csharp
using Meteroid.Models;

var onboardingLinkResponse = await client.Connect.CreateOnboardingLinkAsync("id", new CreateOnboardingLinkRequest { RedirectUrl = "redirect_url" });
```

Properties this SDK version does not know are kept in `AdditionalProperties` and sent back.
Unions are abstract records to match on, and enums keep unknown values too (`IsKnown`); `switch`
on `status.Value` with the `Status.Values` constants.

## Errors

Everything the SDK throws derives from `MeteroidException`:

```csharp
try
{
    await client.AddOns.RetrieveAsync("addon_id");
}
catch (NotFoundException e)
{
    Console.WriteLine($"{e.StatusCode} {e.RequestId}: {e.Error}");
}
catch (ApiTimeoutException) { /* no response in time, after the retries */ }
catch (ApiConnectionException) { /* the API could not be reached */ }
```

Error responses are `ApiException`s, as a subclass per status (`BadRequestException`,
`UnauthorizedException`, `NotFoundException`, `RateLimitException`, `ServerErrorException`...),
with the raw `Body`, the `Headers`, and `Error`: the body parsed as the error model the operation
declares for the status, else a `JsonElement`. `GetError<T>()` parses it as any model. A
successful response the SDK cannot read throws an `ApiDecodeException`.

## Retries and timeouts

Connection errors, timeouts, 408, 429 and 5xx responses are retried twice with jittered backoff
(0.5s, then 1s), honoring `Retry-After` and `retry-after-ms` up to a minute (the backoff
otherwise), when the request is idempotent or carries an `Idempotency-Key` (POST requests get one). Each attempt times out after 60 seconds.

```csharp
var client = new MeteroidClient(options: new() { BaseUrl = "https://api.example.com", MaxRetries = 5, Timeout = TimeSpan.FromSeconds(20) });
await client.AddOns.RetrieveAsync("addon_id", requestOptions: new RequestOptions { MaxRetries = 0, Timeout = TimeSpan.FromSeconds(5) });
```

## Raw responses

`WithRawResponse` returns the status and headers with the decoded body:

```csharp
var response = await client.AddOns.WithRawResponse.RetrieveAsync("addon_id");
Console.WriteLine($"{response.StatusCode} {response.RequestId}");
```

## Tests and dependency injection

`IMeteroidClient` and an interface per resource let you substitute a fake. Each call is an
`Activity` of the `Meteroid` `ActivitySource`, for OpenTelemetry. With
`dependency_injection = true` under `[csharp.context]` in `perseid.toml`, the package registers an
`IHttpClientFactory` typed client:

```csharp
builder.Services.AddMeteroidClient(options => options.Token = builder.Configuration["Meteroid:ApiKey"]);
```
