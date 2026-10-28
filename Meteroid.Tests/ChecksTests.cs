// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class ChecksTests
{
    [Fact]
    public async Task CheckEntitlement()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"as_of\":\"2023-12-31T23:59:59.999-05:30\",\"exact\":true,\"feature\":{\"code\":\"sample\",\"id\":\"feature_id_19\"},\"has_access\":true,\"in_overage\":false,\"lag_ms\":9007199254740993,\"limits\":[{\"behavior\":\"HARD\",\"has_access\":false,\"limit\":\"-0.000123\",\"remaining\":\"12345.6789\",\"usage_limit_id\":\"usage_limit_id_23\",\"used\":\"12345.6789\"}],\"near_limit\":false,\"reason\":\"INSUFFICIENT_BALANCE\"}"
        );
        await mock.Client.Checks.CheckEntitlementAsync("id_or_alias", "feature_id_or_code");
        Assert.Equal(
            new[] { "GET /api/v1/customers/id_or_alias/entitlements/feature_id_or_code/check" },
            mock.Requests
        );
    }
}
