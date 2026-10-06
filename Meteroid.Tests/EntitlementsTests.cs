// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class EntitlementsTests
{
    [Fact]
    public async Task Retrieve()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"feature_id\":\"feature_id_0\",\"id\":\"entitlement_id_79\",\"updated_at\":\"2024-03-15T10:30:45.123+02:00\",\"value\":{\"type\":\"BOOLEAN\",\"enabled\":true}}"
        );
        await mock.Client.Entitlements.RetrieveAsync("entitlement_id");
        Assert.Equal(new[] { "GET /api/v1/entitlements/entitlement_id" }, mock.Requests);
    }

    [Fact]
    public async Task Delete()
    {
        using var mock = new PerseidMock(204, null, "");
        await mock.Client.Entitlements.DeleteAsync("entitlement_id");
        Assert.Equal(new[] { "DELETE /api/v1/entitlements/entitlement_id" }, mock.Requests);
    }

    [Fact]
    public async Task Update()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"feature_id\":\"feature_id_0\",\"id\":\"entitlement_id_79\",\"updated_at\":\"2024-03-15T10:30:45.123+02:00\",\"value\":{\"type\":\"BOOLEAN\",\"enabled\":true}}"
        );
        await mock.Client.Entitlements.UpdateAsync(
            "entitlement_id",
            PerseidMock.Decode<global::Meteroid.Models.UpdateEntitlementRequest>("{}")
        );
        Assert.Equal(new[] { "PATCH /api/v1/entitlements/entitlement_id" }, mock.Requests);
    }
}
