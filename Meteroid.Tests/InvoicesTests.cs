// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class InvoicesTests
{
    [Fact]
    public async Task List()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"amount_due\":-9007199254740993,\"applied_credits\":-9007199254740993,\"coupons\":[{\"coupon_id\":\"sample\",\"name\":\"sample\",\"total\":-9007199254740993}],\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"currency\":\"CNY\",\"custom_properties\":{\"key\":\"value\",\"count\":3,\"ratio\":0.5,\"flags\":[true,false],\"nested\":{\"ok\":true}},\"customer_details\":{\"id\":\"customer_id_39\",\"name\":\"sample\",\"snapshot_at\":\"2023-12-31T23:59:59.999-05:30\"},\"customer_id\":\"customer_id_67\",\"id\":\"invoice_id_67\",\"invoice_date\":\"1999-12-31\",\"invoice_number\":\"sample\",\"invoice_type\":\"RECURRING\",\"line_items\":[{\"amount_total\":9007199254740993,\"end_date\":\"2024-02-29\",\"name\":\"sample\",\"start_date\":\"2024-02-29\",\"sub_line_items\":[{\"id\":\"sample\",\"name\":\"sample\",\"quantity\":\"-0.000123\",\"total\":9007199254740993,\"unit_price\":\"12345.6789\"}],\"tax_rate\":\"12345.6789\"}],\"net_terms\":-2147483648,\"payment_status\":\"PARTIALLY_PAID\",\"status\":\"FINALIZED\",\"subtotal\":-9007199254740993,\"subtotal_recurring\":9007199254740993,\"tax_amount\":9007199254740993,\"tax_breakdown\":[{\"name\":\"sample\",\"tax_amount\":-9007199254740993,\"tax_rate\":\"12345.6789\",\"taxable_amount\":9007199254740993}],\"tax_inclusive\":false,\"total\":-9007199254740993,\"transactions\":[{\"amount\":9007199254740993,\"amount_refunded\":9007199254740993,\"amount_reversed\":-9007199254740993,\"currency\":\"sample\",\"id\":\"payment_transaction_id_94\",\"payment_type\":\"PAYMENT\",\"status\":\"READY\"}]}],\"pagination_meta\":{\"page\":-123456789,\"per_page\":-123456789,\"total_items\":-9007199254740993,\"total_pages\":123456789}}"
        );
        await mock.Client.Invoices.ListAsync();
        Assert.Equal(new[] { "GET /api/v1/invoices" }, mock.Requests);
    }

    [Fact]
    public async Task Retrieve()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"amount_due\":-9007199254740993,\"applied_credits\":9007199254740993,\"coupons\":[{\"coupon_id\":\"sample\",\"name\":\"sample\",\"total\":-9007199254740993}],\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"currency\":\"NAD\",\"custom_properties\":{\"key\":\"value\",\"count\":3,\"ratio\":0.5,\"flags\":[true,false],\"nested\":{\"ok\":true}},\"customer_details\":{\"id\":\"customer_id_62\",\"name\":\"sample\",\"snapshot_at\":\"2024-03-15T10:30:45.123+02:00\"},\"customer_id\":\"customer_id_90\",\"id\":\"invoice_id_31\",\"invoice_date\":\"1999-12-31\",\"invoice_number\":\"sample\",\"invoice_type\":\"ONE_OFF\",\"line_items\":[{\"amount_total\":9007199254740993,\"end_date\":\"1999-12-31\",\"name\":\"sample\",\"start_date\":\"2024-02-29\",\"sub_line_items\":[{\"id\":\"sample\",\"name\":\"sample\",\"quantity\":\"12345.6789\",\"total\":-9007199254740993,\"unit_price\":\"12345.6789\"}],\"tax_rate\":\"-0.000123\"}],\"net_terms\":-2147483648,\"payment_status\":\"UNPAID\",\"status\":\"DRAFT\",\"subtotal\":9007199254740993,\"subtotal_recurring\":9007199254740993,\"tax_amount\":-9007199254740993,\"tax_breakdown\":[{\"name\":\"sample\",\"tax_amount\":9007199254740993,\"tax_rate\":\"-0.000123\",\"taxable_amount\":9007199254740993}],\"tax_inclusive\":true,\"total\":-9007199254740993,\"transactions\":[{\"amount\":-9007199254740993,\"amount_refunded\":9007199254740993,\"amount_reversed\":-9007199254740993,\"currency\":\"sample\",\"id\":\"payment_transaction_id_7\",\"payment_type\":\"PAYMENT\",\"status\":\"CANCELLED\"}]}"
        );
        await mock.Client.Invoices.RetrieveAsync("invoice_id");
        Assert.Equal(new[] { "GET /api/v1/invoices/invoice_id" }, mock.Requests);
    }

    [Fact]
    public async Task UpdateCustomProperties()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"amount_due\":-9007199254740993,\"applied_credits\":9007199254740993,\"coupons\":[{\"coupon_id\":\"sample\",\"name\":\"sample\",\"total\":-9007199254740993}],\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"currency\":\"NAD\",\"custom_properties\":{\"key\":\"value\",\"count\":3,\"ratio\":0.5,\"flags\":[true,false],\"nested\":{\"ok\":true}},\"customer_details\":{\"id\":\"customer_id_62\",\"name\":\"sample\",\"snapshot_at\":\"2024-03-15T10:30:45.123+02:00\"},\"customer_id\":\"customer_id_90\",\"id\":\"invoice_id_31\",\"invoice_date\":\"1999-12-31\",\"invoice_number\":\"sample\",\"invoice_type\":\"ONE_OFF\",\"line_items\":[{\"amount_total\":9007199254740993,\"end_date\":\"1999-12-31\",\"name\":\"sample\",\"start_date\":\"2024-02-29\",\"sub_line_items\":[{\"id\":\"sample\",\"name\":\"sample\",\"quantity\":\"12345.6789\",\"total\":-9007199254740993,\"unit_price\":\"12345.6789\"}],\"tax_rate\":\"-0.000123\"}],\"net_terms\":-2147483648,\"payment_status\":\"UNPAID\",\"status\":\"DRAFT\",\"subtotal\":9007199254740993,\"subtotal_recurring\":9007199254740993,\"tax_amount\":-9007199254740993,\"tax_breakdown\":[{\"name\":\"sample\",\"tax_amount\":9007199254740993,\"tax_rate\":\"-0.000123\",\"taxable_amount\":9007199254740993}],\"tax_inclusive\":true,\"total\":-9007199254740993,\"transactions\":[{\"amount\":-9007199254740993,\"amount_refunded\":9007199254740993,\"amount_reversed\":-9007199254740993,\"currency\":\"sample\",\"id\":\"payment_transaction_id_7\",\"payment_type\":\"PAYMENT\",\"status\":\"CANCELLED\"}]}"
        );
        await mock.Client.Invoices.UpdateCustomPropertiesAsync(
            "invoice_id",
            PerseidMock.Decode<global::Meteroid.Models.InvoiceCustomPropertiesRequest>(
                "{\"custom_properties\":{\"key\":\"value\",\"count\":3,\"ratio\":0.5,\"flags\":[true,false],\"nested\":{\"ok\":true}}}"
            )
        );
        Assert.Equal(new[] { "PATCH /api/v1/invoices/invoice_id/custom-properties" }, mock.Requests);
    }

    [Fact]
    public async Task Download()
    {
        using var mock = new PerseidMock(200, "application/octet-stream", "sample");
        await mock.Client.Invoices.DownloadAsync("invoice_id");
        Assert.Equal(new[] { "GET /api/v1/invoices/invoice_id/download" }, mock.Requests);
    }

    [Fact]
    public async Task Refresh()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"amount_due\":-9007199254740993,\"applied_credits\":9007199254740993,\"coupons\":[{\"coupon_id\":\"sample\",\"name\":\"sample\",\"total\":-9007199254740993}],\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"currency\":\"NAD\",\"custom_properties\":{\"key\":\"value\",\"count\":3,\"ratio\":0.5,\"flags\":[true,false],\"nested\":{\"ok\":true}},\"customer_details\":{\"id\":\"customer_id_62\",\"name\":\"sample\",\"snapshot_at\":\"2024-03-15T10:30:45.123+02:00\"},\"customer_id\":\"customer_id_90\",\"id\":\"invoice_id_31\",\"invoice_date\":\"1999-12-31\",\"invoice_number\":\"sample\",\"invoice_type\":\"ONE_OFF\",\"line_items\":[{\"amount_total\":9007199254740993,\"end_date\":\"1999-12-31\",\"name\":\"sample\",\"start_date\":\"2024-02-29\",\"sub_line_items\":[{\"id\":\"sample\",\"name\":\"sample\",\"quantity\":\"12345.6789\",\"total\":-9007199254740993,\"unit_price\":\"12345.6789\"}],\"tax_rate\":\"-0.000123\"}],\"net_terms\":-2147483648,\"payment_status\":\"UNPAID\",\"status\":\"DRAFT\",\"subtotal\":9007199254740993,\"subtotal_recurring\":9007199254740993,\"tax_amount\":-9007199254740993,\"tax_breakdown\":[{\"name\":\"sample\",\"tax_amount\":9007199254740993,\"tax_rate\":\"-0.000123\",\"taxable_amount\":9007199254740993}],\"tax_inclusive\":true,\"total\":-9007199254740993,\"transactions\":[{\"amount\":-9007199254740993,\"amount_refunded\":9007199254740993,\"amount_reversed\":-9007199254740993,\"currency\":\"sample\",\"id\":\"payment_transaction_id_7\",\"payment_type\":\"PAYMENT\",\"status\":\"CANCELLED\"}]}"
        );
        await mock.Client.Invoices.RefreshAsync("invoice_id");
        Assert.Equal(new[] { "POST /api/v1/invoices/invoice_id/refresh" }, mock.Requests);
    }

    [Fact]
    public async Task DownloadXml()
    {
        using var mock = new PerseidMock(200, "application/octet-stream", "sample");
        await mock.Client.Invoices.DownloadXmlAsync("invoice_id");
        Assert.Equal(new[] { "GET /api/v1/invoices/invoice_id/xml" }, mock.Requests);
    }
}
