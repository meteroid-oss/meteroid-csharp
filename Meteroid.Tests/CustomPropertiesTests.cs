// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class CustomPropertiesTests
{
    [Fact]
    public async Task ListCustomPropertyDefinitions()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"archived\":false,\"config\":{},\"display_order\":-2147483648,\"entity_type\":\"CUSTOMER\",\"id\":\"custom_property_definition_id_78\",\"key\":\"sample\",\"name\":\"sample\",\"property_type\":\"JSON\",\"required\":false}],\"pagination_meta\":{\"page\":-123456789,\"per_page\":-123456789,\"total_items\":-9007199254740993,\"total_pages\":123456789}}"
        );
        await mock.Client.CustomProperties.ListCustomPropertyDefinitionsAsync();
        Assert.Equal(new[] { "GET /api/v1/custom-property-definitions" }, mock.Requests);
    }

    [Fact]
    public async Task CreateCustomPropertyDefinition()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"archived\":false,\"config\":{},\"display_order\":-2147483648,\"entity_type\":\"CUSTOMER\",\"id\":\"custom_property_definition_id_13\",\"key\":\"sample\",\"name\":\"sample\",\"property_type\":\"TEXT\",\"required\":false}"
        );
        await mock.Client.CustomProperties.CreateCustomPropertyDefinitionAsync(
            PerseidMock.Decode<global::Meteroid.Models.CustomPropertyDefinitionCreateRequest>(
                "{\"entity_type\":\"INVOICE\",\"key\":\"sample\",\"name\":\"sample\",\"property_type\":\"TEXT\"}"
            )
        );
        Assert.Equal(new[] { "POST /api/v1/custom-property-definitions" }, mock.Requests);
    }

    [Fact]
    public async Task RetrieveCustomPropertyDefinition()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"archived\":false,\"config\":{},\"display_order\":-2147483648,\"entity_type\":\"CUSTOMER\",\"id\":\"custom_property_definition_id_13\",\"key\":\"sample\",\"name\":\"sample\",\"property_type\":\"TEXT\",\"required\":false}"
        );
        await mock.Client.CustomProperties.RetrieveCustomPropertyDefinitionAsync("id");
        Assert.Equal(new[] { "GET /api/v1/custom-property-definitions/id" }, mock.Requests);
    }

    [Fact]
    public async Task UpdateCustomPropertyDefinition()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"archived\":false,\"config\":{},\"display_order\":-2147483648,\"entity_type\":\"CUSTOMER\",\"id\":\"custom_property_definition_id_13\",\"key\":\"sample\",\"name\":\"sample\",\"property_type\":\"TEXT\",\"required\":false}"
        );
        await mock.Client.CustomProperties.UpdateCustomPropertyDefinitionAsync(
            "id",
            PerseidMock.Decode<global::Meteroid.Models.CustomPropertyDefinitionUpdateRequest>("{}")
        );
        Assert.Equal(new[] { "PUT /api/v1/custom-property-definitions/id" }, mock.Requests);
    }

    [Fact]
    public async Task ArchiveDefinition()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"archived\":false,\"config\":{},\"display_order\":-2147483648,\"entity_type\":\"CUSTOMER\",\"id\":\"custom_property_definition_id_13\",\"key\":\"sample\",\"name\":\"sample\",\"property_type\":\"TEXT\",\"required\":false}"
        );
        await mock.Client.CustomProperties.ArchiveDefinitionAsync("id");
        Assert.Equal(new[] { "DELETE /api/v1/custom-property-definitions/id" }, mock.Requests);
    }
}
