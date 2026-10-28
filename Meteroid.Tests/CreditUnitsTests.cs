// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class CreditUnitsTests
{
    [Fact]
    public async Task List()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"archived\":false,\"code\":\"sample\",\"id\":\"sample\",\"name\":\"sample\",\"plural_name\":\"sample\",\"precision\":123456789,\"prices\":[{\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"currency\":\"sample\",\"id\":\"sample\",\"unit_price\":\"sample\"}]}]}"
        );
        await mock.Client.CreditUnits.ListAsync();
        Assert.Equal(new[] { "GET /api/v1/credit-units" }, mock.Requests);
    }

    [Fact]
    public async Task Create()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"archived\":false,\"code\":\"sample\",\"id\":\"sample\",\"name\":\"sample\",\"plural_name\":\"sample\",\"precision\":2147483647,\"prices\":[{\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"currency\":\"sample\",\"id\":\"sample\",\"unit_price\":\"sample\"}]}"
        );
        await mock.Client.CreditUnits.CreateAsync(
            PerseidMock.Decode<global::Meteroid.Models.CreditUnitCreateRequest>(
                "{\"code\":\"sample\",\"name\":\"sample\",\"plural_name\":\"sample\",\"precision\":123456789}"
            )
        );
        Assert.Equal(new[] { "POST /api/v1/credit-units" }, mock.Requests);
    }

    [Fact]
    public async Task Retrieve()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"archived\":false,\"code\":\"sample\",\"id\":\"sample\",\"name\":\"sample\",\"plural_name\":\"sample\",\"precision\":2147483647,\"prices\":[{\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"currency\":\"sample\",\"id\":\"sample\",\"unit_price\":\"sample\"}]}"
        );
        await mock.Client.CreditUnits.RetrieveAsync("id");
        Assert.Equal(new[] { "GET /api/v1/credit-units/id" }, mock.Requests);
    }

    [Fact]
    public async Task Update()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"archived\":false,\"code\":\"sample\",\"id\":\"sample\",\"name\":\"sample\",\"plural_name\":\"sample\",\"precision\":2147483647,\"prices\":[{\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"currency\":\"sample\",\"id\":\"sample\",\"unit_price\":\"sample\"}]}"
        );
        await mock.Client.CreditUnits.UpdateAsync(
            "id",
            PerseidMock.Decode<global::Meteroid.Models.CreditUnitUpdateRequest>("{}")
        );
        Assert.Equal(new[] { "PATCH /api/v1/credit-units/id" }, mock.Requests);
    }
}
