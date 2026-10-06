// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>CreateConnectedAccountRequest</c> object.</summary>
public sealed partial record CreateConnectedAccountRequest
{
    /// <summary>The <c>connected_organization_id</c> property.</summary>
    [JsonPropertyName("connected_organization_id")]
    public required Guid ConnectedOrganizationId { get; init; }

    /// <summary>The <c>connection_type</c> property.</summary>
    [JsonPropertyName("connection_type")]
    public ConnectionType? ConnectionType { get; init; }

    /// <summary>The <c>metadata</c> property.</summary>
    [JsonPropertyName("metadata")]
    public JsonNode? Metadata { get; init; }

    /// <summary>The <c>platform_customer_id</c> property.</summary>
    [JsonPropertyName("platform_customer_id")]
    public string? PlatformCustomerId { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(CreateConnectedAccountRequest? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(ConnectedOrganizationId, other.ConnectedOrganizationId)
        && global::Meteroid.Equality.Equal(ConnectionType, other.ConnectionType)
        && global::Meteroid.Equality.Equal(Metadata, other.Metadata)
        && global::Meteroid.Equality.Equal(PlatformCustomerId, other.PlatformCustomerId)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(ConnectedOrganizationId));
        hash.Add(global::Meteroid.Equality.Hash(ConnectionType));
        hash.Add(global::Meteroid.Equality.Hash(Metadata));
        hash.Add(global::Meteroid.Equality.Hash(PlatformCustomerId));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
