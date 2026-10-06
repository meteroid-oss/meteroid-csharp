// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class CouponsTests
{
    [Fact]
    public async Task List()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"code\":\"sample\",\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"disabled\":false,\"discount\":{\"type\":\"PERCENTAGE\",\"percentage\":\"sample\"},\"id\":\"coupon_id_25\",\"plan_ids\":[\"plan_id_47\"],\"redemption_count\":-2147483648,\"reusable\":false}],\"pagination_meta\":{\"page\":-123456789,\"per_page\":-123456789,\"total_items\":-9007199254740993,\"total_pages\":123456789}}"
        );
        await mock.Client.Coupons.ListAsync();
        Assert.Equal(new[] { "GET /api/v1/coupons" }, mock.Requests);
    }

    [Fact]
    public async Task Create()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"code\":\"sample\",\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"disabled\":false,\"discount\":{\"type\":\"PERCENTAGE\",\"percentage\":\"sample\"},\"id\":\"coupon_id_40\",\"plan_ids\":[\"plan_id_99\"],\"redemption_count\":-123456789,\"reusable\":false}"
        );
        await mock.Client.Coupons.CreateAsync(
            PerseidMock.Decode<global::Meteroid.Models.CreateCouponRequest>(
                "{\"code\":\"sample\",\"discount\":{\"type\":\"PERCENTAGE\",\"percentage\":\"sample\"}}"
            )
        );
        Assert.Equal(new[] { "POST /api/v1/coupons" }, mock.Requests);
    }

    [Fact]
    public async Task Retrieve()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"code\":\"sample\",\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"disabled\":false,\"discount\":{\"type\":\"PERCENTAGE\",\"percentage\":\"sample\"},\"id\":\"coupon_id_40\",\"plan_ids\":[\"plan_id_99\"],\"redemption_count\":-123456789,\"reusable\":false}"
        );
        await mock.Client.Coupons.RetrieveAsync("coupon_id");
        Assert.Equal(new[] { "GET /api/v1/coupons/coupon_id" }, mock.Requests);
    }

    [Fact]
    public async Task Update()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"code\":\"sample\",\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"disabled\":false,\"discount\":{\"type\":\"PERCENTAGE\",\"percentage\":\"sample\"},\"id\":\"coupon_id_40\",\"plan_ids\":[\"plan_id_99\"],\"redemption_count\":-123456789,\"reusable\":false}"
        );
        await mock.Client.Coupons.UpdateAsync(
            "coupon_id",
            PerseidMock.Decode<global::Meteroid.Models.UpdateCouponRequest>("{}")
        );
        Assert.Equal(new[] { "PATCH /api/v1/coupons/coupon_id" }, mock.Requests);
    }

    [Fact]
    public async Task Archive()
    {
        using var mock = new PerseidMock(204, null, "");
        await mock.Client.Coupons.ArchiveAsync("coupon_id");
        Assert.Equal(new[] { "POST /api/v1/coupons/coupon_id/archive" }, mock.Requests);
    }

    [Fact]
    public async Task Disable()
    {
        using var mock = new PerseidMock(204, null, "");
        await mock.Client.Coupons.DisableAsync("coupon_id");
        Assert.Equal(new[] { "POST /api/v1/coupons/coupon_id/disable" }, mock.Requests);
    }

    [Fact]
    public async Task Enable()
    {
        using var mock = new PerseidMock(204, null, "");
        await mock.Client.Coupons.EnableAsync("coupon_id");
        Assert.Equal(new[] { "POST /api/v1/coupons/coupon_id/enable" }, mock.Requests);
    }

    [Fact]
    public async Task Unarchive()
    {
        using var mock = new PerseidMock(204, null, "");
        await mock.Client.Coupons.UnarchiveAsync("coupon_id");
        Assert.Equal(new[] { "POST /api/v1/coupons/coupon_id/unarchive" }, mock.Requests);
    }
}
