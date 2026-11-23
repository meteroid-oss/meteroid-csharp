// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class EventsTests
{
    [Fact]
    public async Task Ingest()
    {
        using var mock = new PerseidMock(200, "application/json", "{}");
        await mock.Client.Events.IngestAsync(
            PerseidMock.Decode<global::Meteroid.Models.IngestEventsRequest>(
                "{\"events\":[{\"code\":\"sample\",\"customer_id\":\"sample\",\"event_id\":\"sample\"}]}"
            )
        );
        Assert.Equal(new[] { "POST /api/v1/events/ingest" }, mock.Requests);
    }

    [Fact]
    public async Task Amend()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"ingested_at\":\"2023-12-31T23:59:59.999-05:30\"}"
        );
        await mock.Client.Events.AmendAsync(
            "event_id",
            PerseidMock.Decode<global::Meteroid.Models.AmendEventRequest>(
                "{\"properties\":{\"alpha\":\"sample\"},\"timestamp\":\"2023-12-31T23:59:59.999-05:30\"}"
            )
        );
        Assert.Equal(new[] { "POST /api/v1/events/event_id/amend" }, mock.Requests);
    }

    [Fact]
    public async Task Void()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"ingested_at\":\"2023-12-31T23:59:59.999-05:30\"}"
        );
        await mock.Client.Events.VoidAsync(
            "event_id",
            PerseidMock.Decode<global::Meteroid.Models.VoidEventRequest>("{}")
        );
        Assert.Equal(new[] { "POST /api/v1/events/event_id/void" }, mock.Requests);
    }
}
