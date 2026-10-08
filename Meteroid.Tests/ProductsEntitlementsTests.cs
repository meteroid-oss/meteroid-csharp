// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class ProductsEntitlementsTests
{
    [Fact]
    public async Task List()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"feature\":{\"code\":\"sample\",\"id\":\"feature_id_53\",\"name\":\"sample\"},\"value\":{\"type\":\"BOOLEAN\",\"enabled\":false}}]}"
        );
        await mock.Client.Products.Entitlements.ListAsync("product_id");
        Assert.Equal(new[] { "GET /api/v1/products/product_id/entitlements" }, mock.Requests);
    }

    [Fact]
    public async Task Create()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"feature_id\":\"feature_id_39\",\"id\":\"entitlement_id_2\",\"updated_at\":\"2024-03-15T10:30:45.123+02:00\",\"value\":{\"type\":\"BOOLEAN\",\"enabled\":false}}]}"
        );
        await mock.Client.Products.Entitlements.CreateAsync(
            "product_id",
            PerseidMock.Decode<global::Meteroid.Models.CreateEntitlementsRequest>(
                "{\"entitlements\":[{\"feature_id\":\"feature_id_9\",\"value\":{\"type\":\"BOOLEAN\",\"enabled\":false}}]}"
            )
        );
        Assert.Equal(new[] { "POST /api/v1/products/product_id/entitlements" }, mock.Requests);
    }
}
