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
}
