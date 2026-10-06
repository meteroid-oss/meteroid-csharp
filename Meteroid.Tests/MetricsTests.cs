// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class MetricsTests
{
    [Fact]
    public async Task List()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"aggregation_type\":\"COUNT\",\"code\":\"sample\",\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"id\":\"billable_metric_id_78\",\"name\":\"sample\"}],\"pagination_meta\":{\"page\":-123456789,\"per_page\":-123456789,\"total_items\":-9007199254740993,\"total_pages\":123456789}}"
        );
        await mock.Client.Metrics.ListAsync();
        Assert.Equal(new[] { "GET /api/v1/metrics" }, mock.Requests);
    }

    [Fact]
    public async Task Create()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"aggregation_type\":\"LATEST\",\"code\":\"sample\",\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"id\":\"billable_metric_id_40\",\"name\":\"sample\",\"product_family_id\":\"product_family_id_90\"}"
        );
        await mock.Client.Metrics.CreateAsync(
            PerseidMock.Decode<global::Meteroid.Models.CreateMetricRequest>(
                "{\"aggregation_type\":\"LATEST\",\"code\":\"sample\",\"name\":\"sample\",\"product_family_id\":\"product_family_id_13\"}"
            )
        );
        Assert.Equal(new[] { "POST /api/v1/metrics" }, mock.Requests);
    }

    [Fact]
    public async Task Retrieve()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"aggregation_type\":\"LATEST\",\"code\":\"sample\",\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"id\":\"billable_metric_id_40\",\"name\":\"sample\",\"product_family_id\":\"product_family_id_90\"}"
        );
        await mock.Client.Metrics.RetrieveAsync("metric_id");
        Assert.Equal(new[] { "GET /api/v1/metrics/metric_id" }, mock.Requests);
    }

    [Fact]
    public async Task Update()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"aggregation_type\":\"LATEST\",\"code\":\"sample\",\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"id\":\"billable_metric_id_40\",\"name\":\"sample\",\"product_family_id\":\"product_family_id_90\"}"
        );
        await mock.Client.Metrics.UpdateAsync(
            "metric_id",
            PerseidMock.Decode<global::Meteroid.Models.UpdateMetricRequest>("{}")
        );
        Assert.Equal(new[] { "PATCH /api/v1/metrics/metric_id" }, mock.Requests);
    }

    [Fact]
    public async Task Archive()
    {
        using var mock = new PerseidMock(204, null, "");
        await mock.Client.Metrics.ArchiveAsync("metric_id");
        Assert.Equal(new[] { "POST /api/v1/metrics/metric_id/archive" }, mock.Requests);
    }

    [Fact]
    public async Task Unarchive()
    {
        using var mock = new PerseidMock(204, null, "");
        await mock.Client.Metrics.UnarchiveAsync("metric_id");
        Assert.Equal(new[] { "POST /api/v1/metrics/metric_id/unarchive" }, mock.Requests);
    }
}
