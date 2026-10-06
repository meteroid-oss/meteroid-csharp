// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class ProductFamiliesTests
{
    [Fact]
    public async Task List()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"id\":\"product_family_id_9\",\"name\":\"sample\"}],\"pagination_meta\":{\"page\":-123456789,\"per_page\":-123456789,\"total_items\":-9007199254740993,\"total_pages\":123456789}}"
        );
        await mock.Client.ProductFamilies.ListAsync();
        Assert.Equal(new[] { "GET /api/v1/product_families" }, mock.Requests);
    }

    [Fact]
    public async Task Create()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"id\":\"product_family_id_35\",\"name\":\"sample\"}"
        );
        await mock.Client.ProductFamilies.CreateAsync(
            PerseidMock.Decode<global::Meteroid.Models.ProductFamilyCreateRequest>("{\"name\":\"sample\"}")
        );
        Assert.Equal(new[] { "POST /api/v1/product_families" }, mock.Requests);
    }

    [Fact]
    public async Task Retrieve()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"id\":\"product_family_id_35\",\"name\":\"sample\"}"
        );
        await mock.Client.ProductFamilies.RetrieveAsync("id_or_alias");
        Assert.Equal(new[] { "GET /api/v1/product_families/id_or_alias" }, mock.Requests);
    }
}
