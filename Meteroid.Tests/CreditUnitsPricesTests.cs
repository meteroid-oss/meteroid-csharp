// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class CreditUnitsPricesTests
{
    [Fact]
    public async Task List()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"currency\":\"sample\",\"id\":\"sample\",\"unit_price\":\"sample\"}]}"
        );
        await mock.Client.CreditUnits.Prices.ListAsync("id");
        Assert.Equal(new[] { "GET /api/v1/credit-units/id/prices" }, mock.Requests);
    }

    [Fact]
    public async Task Update()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"currency\":\"sample\",\"id\":\"sample\",\"unit_price\":\"sample\"}"
        );
        await mock.Client.CreditUnits.Prices.UpdateAsync(
            "id",
            "currency",
            PerseidMock.Decode<global::Meteroid.Models.CreditUnitPriceSetRequest>("{\"unit_price\":\"sample\"}")
        );
        Assert.Equal(new[] { "PUT /api/v1/credit-units/id/prices/currency" }, mock.Requests);
    }

    [Fact]
    public async Task Archive()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"currency\":\"sample\",\"id\":\"sample\",\"unit_price\":\"sample\"}"
        );
        await mock.Client.CreditUnits.Prices.ArchiveAsync("id", "currency");
        Assert.Equal(new[] { "DELETE /api/v1/credit-units/id/prices/currency" }, mock.Requests);
    }
}
