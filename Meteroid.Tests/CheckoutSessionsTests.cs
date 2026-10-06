// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class CheckoutSessionsTests
{
    [Fact]
    public async Task List()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"sessions\":[{\"checkout_type\":\"PLAN_CHANGE\",\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"customer_id\":\"customer_id_47\",\"id\":\"checkout_session_id_39\",\"plan_version_id\":\"plan_version_id_67\",\"status\":\"AWAITING_PAYMENT\"}]}"
        );
        await mock.Client.CheckoutSessions.ListAsync();
        Assert.Equal(new[] { "GET /api/v1/checkout-sessions" }, mock.Requests);
    }

    [Fact]
    public async Task Create()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"session\":{\"checkout_type\":\"PLAN_CHANGE\",\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"customer_id\":\"customer_id_47\",\"id\":\"checkout_session_id_39\",\"plan_version_id\":\"plan_version_id_67\",\"status\":\"AWAITING_PAYMENT\"}}"
        );
        await mock.Client.CheckoutSessions.CreateAsync(
            PerseidMock.Decode<global::Meteroid.Models.CreateCheckoutSessionRequest>(
                "{\"customer_id\":\"sample\",\"plan_version_id\":\"plan_version_id_2\"}"
            )
        );
        Assert.Equal(new[] { "POST /api/v1/checkout-sessions" }, mock.Requests);
    }

    [Fact]
    public async Task Retrieve()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"session\":{\"checkout_type\":\"PLAN_CHANGE\",\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"customer_id\":\"customer_id_47\",\"id\":\"checkout_session_id_39\",\"plan_version_id\":\"plan_version_id_67\",\"status\":\"AWAITING_PAYMENT\"}}"
        );
        await mock.Client.CheckoutSessions.RetrieveAsync("id");
        Assert.Equal(new[] { "GET /api/v1/checkout-sessions/id" }, mock.Requests);
    }

    [Fact]
    public async Task Cancel()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"session\":{\"checkout_type\":\"PLAN_CHANGE\",\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"customer_id\":\"customer_id_47\",\"id\":\"checkout_session_id_39\",\"plan_version_id\":\"plan_version_id_67\",\"status\":\"AWAITING_PAYMENT\"}}"
        );
        await mock.Client.CheckoutSessions.CancelAsync("id");
        Assert.Equal(new[] { "POST /api/v1/checkout-sessions/id/cancel" }, mock.Requests);
    }
}
