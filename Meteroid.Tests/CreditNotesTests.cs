// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class CreditNotesTests
{
    [Fact]
    public async Task List()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"credit_note_number\":\"sample\",\"credit_type\":\"DEBT_CANCELLATION\",\"credited_amount_cents\":9007199254740993,\"currency\":\"TMT\",\"custom_properties\":{\"key\":\"value\",\"count\":3,\"ratio\":0.5,\"flags\":[true,false],\"nested\":{\"ok\":true}},\"customer_id\":\"customer_id_78\",\"id\":\"credit_note_id_47\",\"invoice_id\":\"invoice_id_67\",\"invoice_number\":\"sample\",\"line_items\":[{\"amount_total\":-9007199254740993,\"end_date\":\"2024-02-29\",\"name\":\"sample\",\"start_date\":\"2024-02-29\",\"sub_line_items\":[{\"id\":\"sample\",\"name\":\"sample\",\"quantity\":\"12345.6789\",\"total\":9007199254740993,\"unit_price\":\"12345.6789\"}],\"tax_rate\":\"12345.6789\"}],\"refunded_amount_cents\":9007199254740993,\"status\":\"DRAFT\",\"subtotal\":-9007199254740993,\"tax_amount\":9007199254740993,\"tax_breakdown\":[{\"name\":\"sample\",\"tax_amount\":-9007199254740993,\"tax_rate\":\"-0.000123\",\"taxable_amount\":-9007199254740993}],\"total\":-9007199254740993}],\"pagination_meta\":{\"page\":-123456789,\"per_page\":-123456789,\"total_items\":-9007199254740993,\"total_pages\":123456789}}"
        );
        await mock.Client.CreditNotes.ListAsync();
        Assert.Equal(new[] { "GET /api/v1/credit-notes" }, mock.Requests);
    }

    [Fact]
    public async Task Retrieve()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"credit_note_number\":\"sample\",\"credit_type\":\"REFUND\",\"credited_amount_cents\":9007199254740993,\"currency\":\"MMK\",\"custom_properties\":{\"key\":\"value\",\"count\":3,\"ratio\":0.5,\"flags\":[true,false],\"nested\":{\"ok\":true}},\"customer_id\":\"customer_id_13\",\"id\":\"credit_note_id_99\",\"invoice_id\":\"invoice_id_90\",\"invoice_number\":\"sample\",\"line_items\":[{\"amount_total\":-9007199254740993,\"end_date\":\"2024-02-29\",\"name\":\"sample\",\"start_date\":\"1999-12-31\",\"sub_line_items\":[{\"id\":\"sample\",\"name\":\"sample\",\"quantity\":\"12345.6789\",\"total\":9007199254740993,\"unit_price\":\"-0.000123\"}],\"tax_rate\":\"12345.6789\"}],\"refunded_amount_cents\":-9007199254740993,\"status\":\"DRAFT\",\"subtotal\":9007199254740993,\"tax_amount\":9007199254740993,\"tax_breakdown\":[{\"name\":\"sample\",\"tax_amount\":9007199254740993,\"tax_rate\":\"12345.6789\",\"taxable_amount\":9007199254740993}],\"total\":-9007199254740993}"
        );
        await mock.Client.CreditNotes.RetrieveAsync("credit_note_id");
        Assert.Equal(new[] { "GET /api/v1/credit-notes/credit_note_id" }, mock.Requests);
    }

    [Fact]
    public async Task UpdateCustomProperties()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"credit_note_number\":\"sample\",\"credit_type\":\"REFUND\",\"credited_amount_cents\":9007199254740993,\"currency\":\"MMK\",\"custom_properties\":{\"key\":\"value\",\"count\":3,\"ratio\":0.5,\"flags\":[true,false],\"nested\":{\"ok\":true}},\"customer_id\":\"customer_id_13\",\"id\":\"credit_note_id_99\",\"invoice_id\":\"invoice_id_90\",\"invoice_number\":\"sample\",\"line_items\":[{\"amount_total\":-9007199254740993,\"end_date\":\"2024-02-29\",\"name\":\"sample\",\"start_date\":\"1999-12-31\",\"sub_line_items\":[{\"id\":\"sample\",\"name\":\"sample\",\"quantity\":\"12345.6789\",\"total\":9007199254740993,\"unit_price\":\"-0.000123\"}],\"tax_rate\":\"12345.6789\"}],\"refunded_amount_cents\":-9007199254740993,\"status\":\"DRAFT\",\"subtotal\":9007199254740993,\"tax_amount\":9007199254740993,\"tax_breakdown\":[{\"name\":\"sample\",\"tax_amount\":9007199254740993,\"tax_rate\":\"12345.6789\",\"taxable_amount\":9007199254740993}],\"total\":-9007199254740993}"
        );
        await mock.Client.CreditNotes.UpdateCustomPropertiesAsync(
            "credit_note_id",
            PerseidMock.Decode<global::Meteroid.Models.CreditNoteCustomPropertiesRequest>(
                "{\"custom_properties\":{\"key\":\"value\",\"count\":3,\"ratio\":0.5,\"flags\":[true,false],\"nested\":{\"ok\":true}}}"
            )
        );
        Assert.Equal(new[] { "PATCH /api/v1/credit-notes/credit_note_id/custom-properties" }, mock.Requests);
    }

    [Fact]
    public async Task Download()
    {
        using var mock = new PerseidMock(200, "application/octet-stream", "sample");
        await mock.Client.CreditNotes.DownloadAsync("credit_note_id");
        Assert.Equal(new[] { "GET /api/v1/credit-notes/credit_note_id/download" }, mock.Requests);
    }

    [Fact]
    public async Task DownloadXml()
    {
        using var mock = new PerseidMock(200, "application/octet-stream", "sample");
        await mock.Client.CreditNotes.DownloadXmlAsync("credit_note_id");
        Assert.Equal(new[] { "GET /api/v1/credit-notes/credit_note_id/xml" }, mock.Requests);
    }
}
