// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class UsageTests
{
    [Fact]
    public async Task RetrieveSubscription()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"period_end\":\"2024-02-29\",\"period_start\":\"1999-12-31\",\"usage\":[{\"grouped_usage\":[{\"dimensions\":{\"alpha\":\"sample\"},\"value\":\"-0.000123\"}],\"metric_code\":\"sample\",\"metric_id\":\"billable_metric_id_52\",\"metric_name\":\"sample\",\"total_value\":\"12345.6789\"}]}"
        );
        await mock.Client.Usage.RetrieveSubscriptionAsync("subscription_id");
        Assert.Equal(new[] { "GET /api/v1/usage/subscription/subscription_id" }, mock.Requests);
    }
}
