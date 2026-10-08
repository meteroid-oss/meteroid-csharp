// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class ProductsTests
{
    [Fact]
    public async Task List()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"catalog\":false,\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"fee_structure\":{\"type\":\"RATE\"},\"fee_type\":\"CAPACITY\",\"id\":\"product_id_78\",\"name\":\"sample\",\"product_family_id\":\"product_family_id_47\"}],\"pagination_meta\":{\"page\":-123456789,\"per_page\":-123456789,\"total_items\":-9007199254740993,\"total_pages\":123456789}}"
        );
        await mock.Client.Products.ListAsync();
        Assert.Equal(new[] { "GET /api/v1/products" }, mock.Requests);
    }

    [Fact]
    public async Task Create()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"catalog\":true,\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"fee_structure\":{\"type\":\"RATE\"},\"fee_type\":\"RATE\",\"id\":\"product_id_13\",\"name\":\"sample\",\"product_family_id\":\"product_family_id_99\"}"
        );
        await mock.Client.Products.CreateAsync(
            PerseidMock.Decode<global::Meteroid.Models.CreateProductRequest>(
                "{\"fee_structure\":{\"type\":\"RATE\"},\"name\":\"sample\",\"product_family_id\":\"product_family_id_47\"}"
            )
        );
        Assert.Equal(new[] { "POST /api/v1/products" }, mock.Requests);
    }

    [Fact]
    public async Task Retrieve()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"catalog\":true,\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"fee_structure\":{\"type\":\"RATE\"},\"fee_type\":\"RATE\",\"id\":\"product_id_13\",\"name\":\"sample\",\"product_family_id\":\"product_family_id_99\"}"
        );
        await mock.Client.Products.RetrieveAsync("product_id");
        Assert.Equal(new[] { "GET /api/v1/products/product_id" }, mock.Requests);
    }

    [Fact]
    public async Task Update()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"catalog\":true,\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"fee_structure\":{\"type\":\"RATE\"},\"fee_type\":\"RATE\",\"id\":\"product_id_13\",\"name\":\"sample\",\"product_family_id\":\"product_family_id_99\"}"
        );
        await mock.Client.Products.UpdateAsync(
            "product_id",
            PerseidMock.Decode<global::Meteroid.Models.UpdateProductRequest>("{}")
        );
        Assert.Equal(new[] { "PATCH /api/v1/products/product_id" }, mock.Requests);
    }

    [Fact]
    public async Task Archive()
    {
        using var mock = new PerseidMock(204, null, "");
        await mock.Client.Products.ArchiveAsync("product_id");
        Assert.Equal(new[] { "POST /api/v1/products/product_id/archive" }, mock.Requests);
    }

    [Fact]
    public async Task Unarchive()
    {
        using var mock = new PerseidMock(204, null, "");
        await mock.Client.Products.UnarchiveAsync("product_id");
        Assert.Equal(new[] { "POST /api/v1/products/product_id/unarchive" }, mock.Requests);
    }
}
