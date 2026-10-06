// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class OauthTests
{
    [Fact]
    public async Task Introspect()
    {
        using var mock = new PerseidMock(200, "application/json", "{\"active\":false}");
        await mock.Client.Oauth.IntrospectAsync(
            PerseidMock.Decode<global::Meteroid.Models.IntrospectionRequest>("{\"token\":\"sample\"}")
        );
        Assert.Equal(new[] { "POST /api/v1/oauth/introspect" }, mock.Requests);
    }

    [Fact]
    public async Task Revoke()
    {
        using var mock = new PerseidMock(204, null, "");
        await mock.Client.Oauth.RevokeAsync(
            PerseidMock.Decode<global::Meteroid.Models.RevocationRequest>("{\"token\":\"sample\"}")
        );
        Assert.Equal(new[] { "POST /api/v1/oauth/revoke" }, mock.Requests);
    }

    [Fact]
    public async Task Token()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"access_token\":\"sample\",\"expires_in\":9007199254740993,\"token_type\":\"sample\"}"
        );
        await mock.Client.Oauth.TokenAsync(
            PerseidMock.Decode<global::Meteroid.Models.TokenRequest>("{\"grant_type\":\"sample\"}")
        );
        Assert.Equal(new[] { "POST /api/v1/oauth/token" }, mock.Requests);
    }
}
