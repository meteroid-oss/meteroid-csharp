// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class LicensesTests
{
    [Fact]
    public async Task List()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"auto_issued\":false,\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"customer_id\":\"customer_id_2\",\"customer_name\":\"sample\",\"has_activation_code\":false,\"id\":\"license_id_0\",\"offline\":false,\"revoked_immediately\":false,\"status\":\"REVOKED\",\"validity_days\":-123456789}]}"
        );
        await mock.Client.Licenses.ListAsync();
        Assert.Equal(new[] { "GET /api/v1/licenses" }, mock.Requests);
    }

    [Fact]
    public async Task Create()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"license\":{\"auto_issued\":false,\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"customer_id\":\"customer_id_37\",\"customer_name\":\"sample\",\"has_activation_code\":true,\"id\":\"license_id_40\",\"offline\":true,\"revoked_immediately\":true,\"status\":\"PENDING\",\"validity_days\":123456789}}"
        );
        await mock.Client.Licenses.CreateAsync(
            PerseidMock.Decode<global::Meteroid.Models.IssueLicenseRequest>("{\"customer_id\":\"sample\"}")
        );
        Assert.Equal(new[] { "POST /api/v1/licenses" }, mock.Requests);
    }

    [Fact]
    public async Task Retrieve()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"auto_issued\":false,\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"customer_id\":\"customer_id_79\",\"customer_name\":\"sample\",\"has_activation_code\":false,\"id\":\"license_id_90\",\"offline\":false,\"revoked_immediately\":true,\"status\":\"PENDING\",\"validity_days\":-123456789}"
        );
        await mock.Client.Licenses.RetrieveAsync("license_id");
        Assert.Equal(new[] { "GET /api/v1/licenses/license_id" }, mock.Requests);
    }

    [Fact]
    public async Task RetrieveActivationCode()
    {
        using var mock = new PerseidMock(200, "application/json", "{\"activation_code\":\"sample\"}");
        await mock.Client.Licenses.RetrieveActivationCodeAsync("license_id");
        Assert.Equal(new[] { "GET /api/v1/licenses/license_id/activation-code" }, mock.Requests);
    }

    [Fact]
    public async Task Offline()
    {
        using var mock = new PerseidMock(200, "application/json", "{\"license\":\"sample\"}");
        await mock.Client.Licenses.OfflineAsync(
            "license_id",
            PerseidMock.Decode<global::Meteroid.Models.IssueOfflineLicenseRequest>("{\"valid_days\":123456789}")
        );
        Assert.Equal(new[] { "POST /api/v1/licenses/license_id/offline" }, mock.Requests);
    }

    [Fact]
    public async Task Revoke()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"auto_issued\":false,\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"customer_id\":\"customer_id_79\",\"customer_name\":\"sample\",\"has_activation_code\":false,\"id\":\"license_id_90\",\"offline\":false,\"revoked_immediately\":true,\"status\":\"PENDING\",\"validity_days\":-123456789}"
        );
        await mock.Client.Licenses.RevokeAsync(
            "license_id",
            PerseidMock.Decode<global::Meteroid.Models.RevokeLicenseRequest>("{}")
        );
        Assert.Equal(new[] { "POST /api/v1/licenses/license_id/revoke" }, mock.Requests);
    }

    [Fact]
    public async Task ListLicensingSigningKeys()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"endpoints\":{\"activate_url\":\"sample\",\"events_url\":\"sample\",\"jwks_url\":\"sample\",\"refresh_url\":\"sample\"},\"keys\":[{\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"kid\":\"sample\",\"public_key_pem\":\"sample\",\"status\":\"ACTIVE\"}]}"
        );
        await mock.Client.Licenses.ListLicensingSigningKeysAsync();
        Assert.Equal(new[] { "GET /api/v1/licensing/signing-keys" }, mock.Requests);
    }
}
