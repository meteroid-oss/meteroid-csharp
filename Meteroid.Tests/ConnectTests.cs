// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class ConnectTests
{
    [Fact]
    public async Task ListConnectedAccounts()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"connection_type\":\"standard\",\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"id\":\"connected_account_id_67\",\"onboarding_mode\":\"full\",\"platform_organization_id\":\"organization_id_23\",\"status\":\"active\"}]}"
        );
        await mock.Client.Connect.ListConnectedAccountsAsync();
        Assert.Equal(new[] { "GET /api/v1/connected-accounts" }, mock.Requests);
    }

    [Fact]
    public async Task CreateConnectedAccount()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"connection_type\":\"express\",\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"id\":\"connected_account_id_47\",\"onboarding_mode\":\"express\",\"platform_organization_id\":\"organization_id_83\",\"status\":\"active\"}"
        );
        await mock.Client.Connect.CreateConnectedAccountAsync(
            PerseidMock.Decode<global::Meteroid.Models.CreateConnectedAccountRequest>(
                "{\"connected_organization_id\":\"00000000-0000-0000-0000-000000000000\"}"
            )
        );
        Assert.Equal(new[] { "POST /api/v1/connected-accounts" }, mock.Requests);
    }

    [Fact]
    public async Task RetrieveConnectedAccount()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"connection_type\":\"express\",\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"id\":\"connected_account_id_47\",\"onboarding_mode\":\"express\",\"platform_organization_id\":\"organization_id_83\",\"status\":\"active\"}"
        );
        await mock.Client.Connect.RetrieveConnectedAccountAsync("id");
        Assert.Equal(new[] { "GET /api/v1/connected-accounts/id" }, mock.Requests);
    }

    [Fact]
    public async Task DisconnectAccount()
    {
        using var mock = new PerseidMock(204, null, "");
        await mock.Client.Connect.DisconnectAccountAsync("id");
        Assert.Equal(new[] { "DELETE /api/v1/connected-accounts/id" }, mock.Requests);
    }

    [Fact]
    public async Task CreateOnboardingLink()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"expires_at\":\"2023-12-31T23:59:59.999-05:30\",\"url\":\"sample\"}"
        );
        await mock.Client.Connect.CreateOnboardingLinkAsync(
            "id",
            PerseidMock.Decode<global::Meteroid.Models.CreateOnboardingLinkRequest>("{\"redirect_url\":\"sample\"}")
        );
        Assert.Equal(new[] { "POST /api/v1/connected-accounts/id/onboarding" }, mock.Requests);
    }
}
