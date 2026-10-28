// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class UsageCustomerTests
{
    [Fact]
    public async Task RetrieveUnattributed()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"period_end\":\"1999-12-31\",\"period_start\":\"2024-02-29\",\"usage\":[{\"from\":\"2024-03-15T10:30:45.123+02:00\",\"metric_code\":\"sample\",\"metric_id\":\"billable_metric_id_44\",\"metric_name\":\"sample\",\"total_value\":\"12345.6789\",\"until\":\"2023-12-31T23:59:59.999-05:30\"}]}"
        );
        await mock.Client.Usage.Customer.RetrieveUnattributedAsync("customer_id");
        Assert.Equal(new[] { "GET /api/v1/usage/customer/customer_id/unattributed" }, mock.Requests);
    }
}
