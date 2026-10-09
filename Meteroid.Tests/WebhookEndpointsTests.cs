// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class WebhookEndpointsTests
{
    [Fact]
    public async Task ResendWebhookDelivery()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"attempt_count\":-2147483648,\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"endpoint_id\":\"webhook_endpoint_id_44\",\"event_type\":\"sample\",\"id\":\"webhook_delivery_id_90\",\"manual\":false,\"message_id\":\"event_id_90\",\"status\":\"IN_FLIGHT\"}"
        );
        await mock.Client.WebhookEndpoints.ResendWebhookDeliveryAsync("delivery_id");
        Assert.Equal(new[] { "POST /api/v1/webhooks/deliveries/delivery_id/resend" }, mock.Requests);
    }
}
