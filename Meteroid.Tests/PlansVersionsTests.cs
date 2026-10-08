// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class PlansVersionsTests
{
    [Fact]
    public async Task UpdateMinimum()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"amount\":\"sample\",\"scope\":{\"type\":\"all_components\"}}"
        );
        await mock.Client.Plans.Versions.UpdateMinimumAsync(
            "plan_version_id",
            PerseidMock.Decode<global::Meteroid.Models.MinimumCommitment>(
                "{\"amount\":\"sample\",\"scope\":{\"type\":\"all_components\"}}"
            )
        );
        Assert.Equal(new[] { "PUT /api/v1/plans/versions/plan_version_id/minimum" }, mock.Requests);
    }

    [Fact]
    public async Task DeleteMinimum()
    {
        using var mock = new PerseidMock(204, null, "");
        await mock.Client.Plans.Versions.DeleteMinimumAsync("plan_version_id");
        Assert.Equal(new[] { "DELETE /api/v1/plans/versions/plan_version_id/minimum" }, mock.Requests);
    }

    [Fact]
    public async Task List()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"currency\":\"sample\",\"id\":\"plan_version_id_2\",\"is_draft\":true,\"version\":-2147483648}],\"pagination_meta\":{\"page\":-123456789,\"per_page\":-123456789,\"total_items\":-9007199254740993,\"total_pages\":123456789}}"
        );
        await mock.Client.Plans.Versions.ListAsync("plan_id");
        Assert.Equal(new[] { "GET /api/v1/plans/plan_id/versions" }, mock.Requests);
    }
}
