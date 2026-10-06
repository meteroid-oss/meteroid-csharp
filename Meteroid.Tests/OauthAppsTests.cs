// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class OauthAppsTests
{
    [Fact]
    public async Task List()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"client_id\":\"sample\",\"client_secret_hint\":\"sample\",\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"id\":\"o_auth_app_id_90\",\"is_active\":false,\"name\":\"sample\",\"organization_id\":\"organization_id_78\",\"redirect_uris\":[\"sample\"],\"scopes\":[\"sample\"]}]}"
        );
        await mock.Client.OauthApps.ListAsync();
        Assert.Equal(new[] { "GET /api/v1/oauth-apps" }, mock.Requests);
    }

    [Fact]
    public async Task Create()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"app\":{\"client_id\":\"sample\",\"client_secret_hint\":\"sample\",\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"id\":\"o_auth_app_id_90\",\"is_active\":false,\"name\":\"sample\",\"organization_id\":\"organization_id_78\",\"redirect_uris\":[\"sample\"],\"scopes\":[\"sample\"]},\"client_secret\":\"sample\"}"
        );
        await mock.Client.OauthApps.CreateAsync(
            PerseidMock.Decode<global::Meteroid.Models.CreateOAuthAppRequest>(
                "{\"name\":\"sample\",\"redirect_uris\":[\"sample\"]}"
            )
        );
        Assert.Equal(new[] { "POST /api/v1/oauth-apps" }, mock.Requests);
    }

    [Fact]
    public async Task Retrieve()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"client_id\":\"sample\",\"client_secret_hint\":\"sample\",\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"id\":\"o_auth_app_id_44\",\"is_active\":false,\"name\":\"sample\",\"organization_id\":\"organization_id_13\",\"redirect_uris\":[\"sample\"],\"scopes\":[\"sample\"]}"
        );
        await mock.Client.OauthApps.RetrieveAsync("id");
        Assert.Equal(new[] { "GET /api/v1/oauth-apps/id" }, mock.Requests);
    }

    [Fact]
    public async Task Delete()
    {
        using var mock = new PerseidMock(204, null, "");
        await mock.Client.OauthApps.DeleteAsync("id");
        Assert.Equal(new[] { "DELETE /api/v1/oauth-apps/id" }, mock.Requests);
    }

    [Fact]
    public async Task Rotate()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"client_secret\":\"sample\",\"client_secret_hint\":\"sample\"}"
        );
        await mock.Client.OauthApps.RotateAsync("id");
        Assert.Equal(new[] { "POST /api/v1/oauth-apps/id/rotate" }, mock.Requests);
    }
}
