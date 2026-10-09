// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class CustomersTests
{
    [Fact]
    public async Task List()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"currency\":\"BHD\",\"custom_properties\":{\"key\":\"value\",\"count\":3,\"ratio\":0.5,\"flags\":[true,false],\"nested\":{\"ok\":true}},\"custom_taxes\":[{\"name\":\"sample\",\"rate\":\"sample\",\"tax_code\":\"sample\"}],\"id\":\"customer_id_39\",\"invoicing_emails\":[\"sample\"],\"invoicing_entity_id\":\"invoicing_entity_id_23\",\"name\":\"sample\",\"preferred_locales\":[\"sample\"]}],\"pagination_meta\":{\"page\":-123456789,\"per_page\":-123456789,\"total_items\":-9007199254740993,\"total_pages\":123456789}}"
        );
        await mock.Client.Customers.ListAsync();
        Assert.Equal(new[] { "GET /api/v1/customers" }, mock.Requests);
    }

    [Fact]
    public async Task Create()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"currency\":\"ERN\",\"custom_properties\":{\"key\":\"value\",\"count\":3,\"ratio\":0.5,\"flags\":[true,false],\"nested\":{\"ok\":true}},\"custom_taxes\":[{\"name\":\"sample\",\"rate\":\"sample\",\"tax_code\":\"sample\"}],\"id\":\"customer_id_1\",\"invoicing_emails\":[\"sample\"],\"invoicing_entity_id\":\"invoicing_entity_id_83\",\"name\":\"sample\",\"preferred_locales\":[\"sample\"]}"
        );
        await mock.Client.Customers.CreateAsync(
            PerseidMock.Decode<global::Meteroid.Models.CustomerCreateRequest>("{\"currency\":\"ERN\"}")
        );
        Assert.Equal(new[] { "POST /api/v1/customers" }, mock.Requests);
    }

    [Fact]
    public async Task Retrieve()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"currency\":\"ERN\",\"custom_properties\":{\"key\":\"value\",\"count\":3,\"ratio\":0.5,\"flags\":[true,false],\"nested\":{\"ok\":true}},\"custom_taxes\":[{\"name\":\"sample\",\"rate\":\"sample\",\"tax_code\":\"sample\"}],\"id\":\"customer_id_1\",\"invoicing_emails\":[\"sample\"],\"invoicing_entity_id\":\"invoicing_entity_id_83\",\"name\":\"sample\",\"preferred_locales\":[\"sample\"]}"
        );
        await mock.Client.Customers.RetrieveAsync("id_or_alias");
        Assert.Equal(new[] { "GET /api/v1/customers/id_or_alias" }, mock.Requests);
    }

    [Fact]
    public async Task Replace()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"currency\":\"ERN\",\"custom_properties\":{\"key\":\"value\",\"count\":3,\"ratio\":0.5,\"flags\":[true,false],\"nested\":{\"ok\":true}},\"custom_taxes\":[{\"name\":\"sample\",\"rate\":\"sample\",\"tax_code\":\"sample\"}],\"id\":\"customer_id_1\",\"invoicing_emails\":[\"sample\"],\"invoicing_entity_id\":\"invoicing_entity_id_83\",\"name\":\"sample\",\"preferred_locales\":[\"sample\"]}"
        );
        await mock.Client.Customers.ReplaceAsync(
            "id_or_alias",
            PerseidMock.Decode<global::Meteroid.Models.CustomerUpdateRequest>(
                "{\"currency\":\"MMK\",\"custom_taxes\":[{\"name\":\"sample\",\"rate\":\"sample\",\"tax_code\":\"sample\"}],\"invoicing_emails\":[\"sample\"],\"invoicing_entity_id\":\"invoicing_entity_id_26\"}"
            )
        );
        Assert.Equal(new[] { "PUT /api/v1/customers/id_or_alias" }, mock.Requests);
    }

    [Fact]
    public async Task Archive()
    {
        using var mock = new PerseidMock(204, null, "");
        await mock.Client.Customers.ArchiveAsync("id_or_alias");
        Assert.Equal(new[] { "DELETE /api/v1/customers/id_or_alias" }, mock.Requests);
    }

    [Fact]
    public async Task Update()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"currency\":\"ERN\",\"custom_properties\":{\"key\":\"value\",\"count\":3,\"ratio\":0.5,\"flags\":[true,false],\"nested\":{\"ok\":true}},\"custom_taxes\":[{\"name\":\"sample\",\"rate\":\"sample\",\"tax_code\":\"sample\"}],\"id\":\"customer_id_1\",\"invoicing_emails\":[\"sample\"],\"invoicing_entity_id\":\"invoicing_entity_id_83\",\"name\":\"sample\",\"preferred_locales\":[\"sample\"]}"
        );
        await mock.Client.Customers.UpdateAsync(
            "id_or_alias",
            PerseidMock.Decode<global::Meteroid.Models.CustomerPatchRequest>("{}")
        );
        Assert.Equal(new[] { "PATCH /api/v1/customers/id_or_alias" }, mock.Requests);
    }

    [Fact]
    public async Task ListEntitlements()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"feature\":{\"code\":\"sample\",\"id\":\"feature_id_53\",\"name\":\"sample\"},\"value\":{\"type\":\"BOOLEAN\",\"enabled\":false}}]}"
        );
        await mock.Client.Customers.ListEntitlementsAsync("id_or_alias");
        Assert.Equal(new[] { "GET /api/v1/customers/id_or_alias/entitlements" }, mock.Requests);
    }

    [Fact]
    public async Task CreatePortalToken()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"api_url\":\"sample\",\"expires_at\":\"2024-03-15T10:30:45.123+02:00\",\"portal_link\":\"sample\",\"portal_url\":\"sample\",\"token\":\"sample\"}"
        );
        await mock.Client.Customers.CreatePortalTokenAsync(
            "id_or_alias",
            PerseidMock.Decode<global::Meteroid.Models.CustomerPortalTokenRequest>("{}")
        );
        Assert.Equal(new[] { "POST /api/v1/customers/id_or_alias/portal-token" }, mock.Requests);
    }

    [Fact]
    public async Task Unarchive()
    {
        using var mock = new PerseidMock(204, null, "");
        await mock.Client.Customers.UnarchiveAsync("id_or_alias");
        Assert.Equal(new[] { "POST /api/v1/customers/id_or_alias/unarchive" }, mock.Requests);
    }
}
