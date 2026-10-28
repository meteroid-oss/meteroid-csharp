// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class CreditsWalletsTests
{
    [Fact]
    public async Task List()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"credit_on_account\":9007199254740993,\"credit_on_account_usage_only\":-9007199254740993,\"low_balance_thresholds\":[-9007199254740993],\"pauses_at_zero\":false,\"subscription_credit\":[{\"credit_on_account\":-9007199254740993,\"subscription_id\":\"sample\"}],\"upcoming_credit\":9007199254740993,\"usage_at_zero\":\"FOLLOW_PLAN\"}]}"
        );
        await mock.Client.Credits.Wallets.ListAsync("id_or_alias");
        Assert.Equal(new[] { "GET /api/v1/customers/id_or_alias/wallets" }, mock.Requests);
    }

    [Fact]
    public async Task Check()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"as_of\":\"2023-12-31T23:59:59.999-05:30\",\"balance\":9007199254740993,\"exact\":true,\"exhausted\":false,\"has_access\":true,\"lag_ms\":-9007199254740993,\"pauses_at_zero\":true}"
        );
        await mock.Client.Credits.Wallets.CheckAsync("id_or_alias");
        Assert.Equal(new[] { "GET /api/v1/customers/id_or_alias/wallets/check" }, mock.Requests);
    }
}
