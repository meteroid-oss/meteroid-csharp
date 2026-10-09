// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class WebhookEndpointsEndpointsTests
{
    [Fact]
    public async Task List()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"consecutive_failures\":-123456789,\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"disabled\":true,\"event_types\":[\"sample\"],\"headers\":[{\"name\":\"sample\",\"sensitive\":false,\"set\":true}],\"id\":\"webhook_endpoint_id_25\",\"max_in_flight\":-2147483648,\"needs_setup\":false,\"url\":\"sample\"}]}"
        );
        await mock.Client.WebhookEndpoints.Endpoints.ListAsync();
        Assert.Equal(new[] { "GET /api/v1/webhooks/endpoints" }, mock.Requests);
    }

    [Fact]
    public async Task Create()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"consecutive_failures\":-2147483648,\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"disabled\":true,\"event_types\":[\"sample\"],\"headers\":[{\"name\":\"sample\",\"sensitive\":true,\"set\":true}],\"id\":\"webhook_endpoint_id_40\",\"max_in_flight\":-123456789,\"needs_setup\":true,\"url\":\"sample\",\"secret\":\"sample\"}"
        );
        await mock.Client.WebhookEndpoints.Endpoints.CreateAsync(
            PerseidMock.Decode<global::Meteroid.Models.CreateWebhookEndpointRequest>("{\"url\":\"sample\"}")
        );
        Assert.Equal(new[] { "POST /api/v1/webhooks/endpoints" }, mock.Requests);
    }

    [Fact]
    public async Task Retrieve()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"consecutive_failures\":-2147483648,\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"disabled\":true,\"event_types\":[\"sample\"],\"headers\":[{\"name\":\"sample\",\"sensitive\":true,\"set\":true}],\"id\":\"webhook_endpoint_id_40\",\"max_in_flight\":-123456789,\"needs_setup\":true,\"url\":\"sample\"}"
        );
        await mock.Client.WebhookEndpoints.Endpoints.RetrieveAsync("endpoint_id");
        Assert.Equal(new[] { "GET /api/v1/webhooks/endpoints/endpoint_id" }, mock.Requests);
    }

    [Fact]
    public async Task Delete()
    {
        using var mock = new PerseidMock(204, null, "");
        await mock.Client.WebhookEndpoints.Endpoints.DeleteAsync("endpoint_id");
        Assert.Equal(new[] { "DELETE /api/v1/webhooks/endpoints/endpoint_id" }, mock.Requests);
    }

    [Fact]
    public async Task Update()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"consecutive_failures\":-2147483648,\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"disabled\":true,\"event_types\":[\"sample\"],\"headers\":[{\"name\":\"sample\",\"sensitive\":true,\"set\":true}],\"id\":\"webhook_endpoint_id_40\",\"max_in_flight\":-123456789,\"needs_setup\":true,\"url\":\"sample\"}"
        );
        await mock.Client.WebhookEndpoints.Endpoints.UpdateAsync(
            "endpoint_id",
            PerseidMock.Decode<global::Meteroid.Models.UpdateWebhookEndpointRequest>("{}")
        );
        Assert.Equal(new[] { "PATCH /api/v1/webhooks/endpoints/endpoint_id" }, mock.Requests);
    }

    [Fact]
    public async Task ListDeliveries()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"attempt_count\":-123456789,\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"endpoint_id\":\"webhook_endpoint_id_90\",\"event_type\":\"sample\",\"id\":\"webhook_delivery_id_0\",\"manual\":false,\"message_id\":\"event_id_67\",\"status\":\"SUCCEEDED\"}],\"pagination_meta\":{\"page\":-123456789,\"per_page\":-123456789,\"total_items\":-9007199254740993,\"total_pages\":123456789}}"
        );
        await mock.Client.WebhookEndpoints.Endpoints.ListDeliveriesAsync("endpoint_id");
        Assert.Equal(new[] { "GET /api/v1/webhooks/endpoints/endpoint_id/deliveries" }, mock.Requests);
    }

    [Fact]
    public async Task RotateSecret()
    {
        using var mock = new PerseidMock(200, "application/json", "{\"secret\":\"sample\"}");
        await mock.Client.WebhookEndpoints.Endpoints.RotateSecretAsync("endpoint_id");
        Assert.Equal(new[] { "POST /api/v1/webhooks/endpoints/endpoint_id/rotate-secret" }, mock.Requests);
    }

    [Fact]
    public async Task RetrieveSecret()
    {
        using var mock = new PerseidMock(200, "application/json", "{\"secret\":\"sample\"}");
        await mock.Client.WebhookEndpoints.Endpoints.RetrieveSecretAsync("endpoint_id");
        Assert.Equal(new[] { "GET /api/v1/webhooks/endpoints/endpoint_id/secret" }, mock.Requests);
    }
}
