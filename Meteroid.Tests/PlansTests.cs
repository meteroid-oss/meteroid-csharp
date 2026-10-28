// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class PlansTests
{
    [Fact]
    public async Task ListPlanVersionEntitlements()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"feature\":{\"code\":\"sample\",\"id\":\"feature_id_53\",\"name\":\"sample\"},\"value\":{\"type\":\"BOOLEAN\",\"enabled\":false}}]}"
        );
        await mock.Client.Plans.ListPlanVersionEntitlementsAsync("plan_version_id");
        Assert.Equal(new[] { "GET /api/v1/plan-versions/plan_version_id/entitlements" }, mock.Requests);
    }

    [Fact]
    public async Task CreatePlanVersionEntitlement()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"feature_id\":\"feature_id_39\",\"id\":\"entitlement_id_2\",\"updated_at\":\"2024-03-15T10:30:45.123+02:00\",\"value\":{\"type\":\"BOOLEAN\",\"enabled\":false}}]}"
        );
        await mock.Client.Plans.CreatePlanVersionEntitlementAsync(
            "plan_version_id",
            PerseidMock.Decode<global::Meteroid.Models.CreateEntitlementsRequest>(
                "{\"entitlements\":[{\"feature_id\":\"feature_id_9\",\"value\":{\"type\":\"BOOLEAN\",\"enabled\":false}}]}"
            )
        );
        Assert.Equal(new[] { "POST /api/v1/plan-versions/plan_version_id/entitlements" }, mock.Requests);
    }

    [Fact]
    public async Task List()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"available_parameters\":{},\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"currency\":\"TMT\",\"id\":\"plan_id_25\",\"name\":\"sample\",\"net_terms\":-2147483648,\"plan_type\":\"CUSTOM\",\"price_components\":[{\"id\":\"price_component_id_8\",\"name\":\"sample\"}],\"product_family\":{\"id\":\"product_family_id_2\",\"name\":\"sample\"},\"status\":\"DRAFT\",\"tax_inclusive\":false,\"version\":123456789,\"version_id\":\"plan_version_id_3\"}],\"pagination_meta\":{\"page\":-123456789,\"per_page\":-123456789,\"total_items\":-9007199254740993,\"total_pages\":123456789}}"
        );
        await mock.Client.Plans.ListAsync();
        Assert.Equal(new[] { "GET /api/v1/plans" }, mock.Requests);
    }

    [Fact]
    public async Task Create()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"available_parameters\":{},\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"currency\":\"MMK\",\"id\":\"plan_id_40\",\"name\":\"sample\",\"net_terms\":-123456789,\"plan_type\":\"STANDARD\",\"price_components\":[{\"id\":\"price_component_id_88\",\"name\":\"sample\"}],\"product_family\":{\"id\":\"product_family_id_15\",\"name\":\"sample\"},\"status\":\"ACTIVE\",\"tax_inclusive\":true,\"version\":123456789,\"version_id\":\"plan_version_id_79\"}"
        );
        await mock.Client.Plans.CreateAsync(
            PerseidMock.Decode<global::Meteroid.Models.CreatePlanRequest>(
                "{\"components\":[{\"fee\":{\"type\":\"RATE\",\"rates\":[{\"price\":\"-0.000123\",\"term\":\"ANNUAL\"}]},\"name\":\"sample\"}],\"currency\":\"sample\",\"name\":\"sample\",\"plan_type\":\"CUSTOM\",\"product_family_id\":\"product_family_id_90\",\"status\":\"INACTIVE\"}"
            )
        );
        Assert.Equal(new[] { "POST /api/v1/plans" }, mock.Requests);
    }

    [Fact]
    public async Task Retrieve()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"available_parameters\":{},\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"currency\":\"MMK\",\"id\":\"plan_id_40\",\"name\":\"sample\",\"net_terms\":-123456789,\"plan_type\":\"STANDARD\",\"price_components\":[{\"id\":\"price_component_id_88\",\"name\":\"sample\"}],\"product_family\":{\"id\":\"product_family_id_15\",\"name\":\"sample\"},\"status\":\"ACTIVE\",\"tax_inclusive\":true,\"version\":123456789,\"version_id\":\"plan_version_id_79\"}"
        );
        await mock.Client.Plans.RetrieveAsync("plan_id");
        Assert.Equal(new[] { "GET /api/v1/plans/plan_id" }, mock.Requests);
    }

    [Fact]
    public async Task Replace()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"available_parameters\":{},\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"currency\":\"MMK\",\"id\":\"plan_id_40\",\"name\":\"sample\",\"net_terms\":-123456789,\"plan_type\":\"STANDARD\",\"price_components\":[{\"id\":\"price_component_id_88\",\"name\":\"sample\"}],\"product_family\":{\"id\":\"product_family_id_15\",\"name\":\"sample\"},\"status\":\"ACTIVE\",\"tax_inclusive\":true,\"version\":123456789,\"version_id\":\"plan_version_id_79\"}"
        );
        await mock.Client.Plans.ReplaceAsync(
            "plan_id",
            PerseidMock.Decode<global::Meteroid.Models.ReplacePlanRequest>(
                "{\"components\":[{\"fee\":{\"type\":\"RATE\",\"rates\":[{\"price\":\"-0.000123\",\"term\":\"ANNUAL\"}]},\"name\":\"sample\"}],\"currency\":\"sample\",\"name\":\"sample\"}"
            )
        );
        Assert.Equal(new[] { "PUT /api/v1/plans/plan_id" }, mock.Requests);
    }

    [Fact]
    public async Task Update()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"available_parameters\":{},\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"currency\":\"MMK\",\"id\":\"plan_id_40\",\"name\":\"sample\",\"net_terms\":-123456789,\"plan_type\":\"STANDARD\",\"price_components\":[{\"id\":\"price_component_id_88\",\"name\":\"sample\"}],\"product_family\":{\"id\":\"product_family_id_15\",\"name\":\"sample\"},\"status\":\"ACTIVE\",\"tax_inclusive\":true,\"version\":123456789,\"version_id\":\"plan_version_id_79\"}"
        );
        await mock.Client.Plans.UpdateAsync(
            "plan_id",
            PerseidMock.Decode<global::Meteroid.Models.PatchPlanRequest>("{}")
        );
        Assert.Equal(new[] { "PATCH /api/v1/plans/plan_id" }, mock.Requests);
    }

    [Fact]
    public async Task Archive()
    {
        using var mock = new PerseidMock(204, null, "");
        await mock.Client.Plans.ArchiveAsync("plan_id");
        Assert.Equal(new[] { "POST /api/v1/plans/plan_id/archive" }, mock.Requests);
    }

    [Fact]
    public async Task Publish()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"available_parameters\":{},\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"currency\":\"MMK\",\"id\":\"plan_id_40\",\"name\":\"sample\",\"net_terms\":-123456789,\"plan_type\":\"STANDARD\",\"price_components\":[{\"id\":\"price_component_id_88\",\"name\":\"sample\"}],\"product_family\":{\"id\":\"product_family_id_15\",\"name\":\"sample\"},\"status\":\"ACTIVE\",\"tax_inclusive\":true,\"version\":123456789,\"version_id\":\"plan_version_id_79\"}"
        );
        await mock.Client.Plans.PublishAsync("plan_id");
        Assert.Equal(new[] { "POST /api/v1/plans/plan_id/publish" }, mock.Requests);
    }

    [Fact]
    public async Task Unarchive()
    {
        using var mock = new PerseidMock(204, null, "");
        await mock.Client.Plans.UnarchiveAsync("plan_id");
        Assert.Equal(new[] { "POST /api/v1/plans/plan_id/unarchive" }, mock.Requests);
    }
}
