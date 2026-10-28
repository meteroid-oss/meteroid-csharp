// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class BudgetsTests
{
    [Fact]
    public async Task List()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"amount\":-9007199254740993,\"behavior\":\"SOFT\",\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"created_by\":\"TENANT\",\"exact\":false,\"id\":\"sample\",\"thresholds\":[-123456789],\"updated_at\":\"2024-03-15T10:30:45.123+02:00\",\"version\":123456789}],\"pagination_meta\":{\"page\":-123456789,\"per_page\":-123456789,\"total_items\":-9007199254740993,\"total_pages\":123456789}}"
        );
        await mock.Client.Budgets.ListAsync("id_or_alias");
        Assert.Equal(new[] { "GET /api/v1/customers/id_or_alias/budgets" }, mock.Requests);
    }
}
