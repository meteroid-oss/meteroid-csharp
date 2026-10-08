// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class AddOnsTests
{
    [Fact]
    public async Task List()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"id\":\"add_on_id_0\",\"name\":\"sample\",\"price_id\":\"price_id_47\",\"product_id\":\"product_id_67\",\"self_serviceable\":false}],\"pagination_meta\":{\"page\":-123456789,\"per_page\":-123456789,\"total_items\":-9007199254740993,\"total_pages\":123456789}}"
        );
        await mock.Client.AddOns.ListAsync();
        Assert.Equal(new[] { "GET /api/v1/addons" }, mock.Requests);
    }

    [Fact]
    public async Task Create()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"id\":\"add_on_id_90\",\"name\":\"sample\",\"price_id\":\"price_id_99\",\"product_id\":\"product_id_90\",\"self_serviceable\":false}"
        );
        await mock.Client.AddOns.CreateAsync(
            PerseidMock.Decode<global::Meteroid.Models.CreateAddOnRequest>(
                "{\"name\":\"sample\",\"price_id\":\"price_id_44\",\"product_id\":\"product_id_47\"}"
            )
        );
        Assert.Equal(new[] { "POST /api/v1/addons" }, mock.Requests);
    }

    [Fact]
    public async Task Retrieve()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"id\":\"add_on_id_90\",\"name\":\"sample\",\"price_id\":\"price_id_99\",\"product_id\":\"product_id_90\",\"self_serviceable\":false}"
        );
        await mock.Client.AddOns.RetrieveAsync("addon_id");
        Assert.Equal(new[] { "GET /api/v1/addons/addon_id" }, mock.Requests);
    }

    [Fact]
    public async Task Update()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"id\":\"add_on_id_90\",\"name\":\"sample\",\"price_id\":\"price_id_99\",\"product_id\":\"product_id_90\",\"self_serviceable\":false}"
        );
        await mock.Client.AddOns.UpdateAsync(
            "addon_id",
            PerseidMock.Decode<global::Meteroid.Models.UpdateAddOnRequest>("{}")
        );
        Assert.Equal(new[] { "PATCH /api/v1/addons/addon_id" }, mock.Requests);
    }

    [Fact]
    public async Task Archive()
    {
        using var mock = new PerseidMock(204, null, "");
        await mock.Client.AddOns.ArchiveAsync("addon_id");
        Assert.Equal(new[] { "POST /api/v1/addons/addon_id/archive" }, mock.Requests);
    }

    [Fact]
    public async Task Unarchive()
    {
        using var mock = new PerseidMock(204, null, "");
        await mock.Client.AddOns.UnarchiveAsync("addon_id");
        Assert.Equal(new[] { "POST /api/v1/addons/addon_id/unarchive" }, mock.Requests);
    }
}
