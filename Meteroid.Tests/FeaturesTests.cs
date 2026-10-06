// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class FeaturesTests
{
    [Fact]
    public async Task List()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"code\":\"sample\",\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"feature_type\":{\"type\":\"BOOLEAN\"},\"id\":\"feature_id_0\",\"name\":\"sample\",\"status\":\"DISABLED\"}],\"pagination_meta\":{\"page\":-123456789,\"per_page\":-123456789,\"total_items\":-9007199254740993,\"total_pages\":123456789}}"
        );
        await mock.Client.Features.ListAsync();
        Assert.Equal(new[] { "GET /api/v1/features" }, mock.Requests);
    }

    [Fact]
    public async Task Create()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"code\":\"sample\",\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"feature_type\":{\"type\":\"BOOLEAN\"},\"id\":\"feature_id_90\",\"name\":\"sample\",\"status\":\"ARCHIVED\"}"
        );
        await mock.Client.Features.CreateAsync(
            PerseidMock.Decode<global::Meteroid.Models.CreateFeatureRequest>(
                "{\"code\":\"sample\",\"feature_type\":{\"type\":\"BOOLEAN\"},\"name\":\"sample\"}"
            )
        );
        Assert.Equal(new[] { "POST /api/v1/features" }, mock.Requests);
    }

    [Fact]
    public async Task Retrieve()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"code\":\"sample\",\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"feature_type\":{\"type\":\"BOOLEAN\"},\"id\":\"feature_id_90\",\"name\":\"sample\",\"status\":\"ARCHIVED\"}"
        );
        await mock.Client.Features.RetrieveAsync("id_or_code");
        Assert.Equal(new[] { "GET /api/v1/features/id_or_code" }, mock.Requests);
    }

    [Fact]
    public async Task Update()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"code\":\"sample\",\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"feature_type\":{\"type\":\"BOOLEAN\"},\"id\":\"feature_id_90\",\"name\":\"sample\",\"status\":\"ARCHIVED\"}"
        );
        await mock.Client.Features.UpdateAsync(
            "id_or_code",
            PerseidMock.Decode<global::Meteroid.Models.UpdateFeatureRequest>("{}")
        );
        Assert.Equal(new[] { "PATCH /api/v1/features/id_or_code" }, mock.Requests);
    }

    [Fact]
    public async Task Archive()
    {
        using var mock = new PerseidMock(204, null, "");
        await mock.Client.Features.ArchiveAsync("id_or_code");
        Assert.Equal(new[] { "POST /api/v1/features/id_or_code/archive" }, mock.Requests);
    }

    [Fact]
    public async Task Unarchive()
    {
        using var mock = new PerseidMock(204, null, "");
        await mock.Client.Features.UnarchiveAsync("id_or_code");
        Assert.Equal(new[] { "POST /api/v1/features/id_or_code/unarchive" }, mock.Requests);
    }
}
