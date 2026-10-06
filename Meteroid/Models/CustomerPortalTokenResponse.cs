// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>CustomerPortalTokenResponse</c> object.</summary>
public sealed partial record CustomerPortalTokenResponse
{
    /// <summary>
    /// Base URL of the public REST API
    /// </summary>
    [JsonPropertyName("api_url")]
    public required string ApiUrl { get; init; }

    /// <summary>
    /// When the token expires (RFC 3339)
    /// </summary>
    [JsonPropertyName("expires_at")]
    public required DateTimeOffset ExpiresAt { get; init; }

    /// <summary>
    /// Hosted customer portal URL, token included
    /// </summary>
    [JsonPropertyName("portal_link")]
    public required string PortalLink { get; init; }

    /// <summary>
    /// Base URL of the customer portal
    /// </summary>
    [JsonPropertyName("portal_url")]
    public required string PortalUrl { get; init; }

    /// <summary>
    /// JWT token for portal access
    /// </summary>
    [JsonPropertyName("token")]
    public required string Token { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(CustomerPortalTokenResponse? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(ApiUrl, other.ApiUrl)
        && global::Meteroid.Equality.Equal(ExpiresAt, other.ExpiresAt)
        && global::Meteroid.Equality.Equal(PortalLink, other.PortalLink)
        && global::Meteroid.Equality.Equal(PortalUrl, other.PortalUrl)
        && global::Meteroid.Equality.Equal(Token, other.Token)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(ApiUrl));
        hash.Add(global::Meteroid.Equality.Hash(ExpiresAt));
        hash.Add(global::Meteroid.Equality.Hash(PortalLink));
        hash.Add(global::Meteroid.Equality.Hash(PortalUrl));
        hash.Add(global::Meteroid.Equality.Hash(Token));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
