// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class CreditsTests
{
    [Fact]
    public async Task ListCustomerCreditLedger()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"amount\":-9007199254740993,\"applies_to\":\"USAGE\",\"balance_after\":9007199254740993,\"credit_grant_id\":\"sample\",\"effective_at\":\"2023-12-31T23:59:59.999-05:30\",\"id\":\"sample\",\"reason\":\"sample\",\"recorded_at\":\"2023-12-31T23:59:59.999-05:30\",\"sequence\":9007199254740993,\"type\":\"CREDIT\"}],\"pagination_meta\":{\"page\":-123456789,\"per_page\":-123456789,\"total_items\":-9007199254740993,\"total_pages\":123456789}}"
        );
        await mock.Client.Credits.ListCustomerCreditLedgerAsync("id_or_alias");
        Assert.Equal(new[] { "GET /api/v1/customers/id_or_alias/credit-ledger" }, mock.Requests);
    }
}
