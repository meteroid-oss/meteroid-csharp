// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>CustomerPortalTokenRequest</c> object.</summary>
public sealed partial record CustomerPortalTokenRequest
{
    /// <summary>
    /// Token lifetime in seconds. Defaults to 86400 (24 hours).
    /// Must be between 60 and 2592000 (30 days).
    /// </summary>
    [JsonPropertyName("expires_in_seconds")]
    public int? ExpiresInSeconds { get; init; }

    /// <summary>
    /// Scopes granted to the token. Defaults to <c>["read", "manage"]</c>.
    /// Use <c>["read"]</c> for tokens that only read billing state, e.g. to gate features in a browser.
    /// </summary>
    [JsonPropertyName("scopes")]
    public IReadOnlyList<CustomerPortalScope>? Scopes { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(CustomerPortalTokenRequest? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(ExpiresInSeconds, other.ExpiresInSeconds)
        && global::Meteroid.Equality.Equal(Scopes, other.Scopes)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(ExpiresInSeconds));
        hash.Add(global::Meteroid.Equality.Hash(Scopes));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
