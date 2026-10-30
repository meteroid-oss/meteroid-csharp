// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// The public endpoints your installations talk to.
/// </summary>
public sealed partial record LicensingEndpoints
{
    /// <summary>The <c>activate_url</c> property.</summary>
    [JsonPropertyName("activate_url")]
    public required string ActivateUrl { get; init; }

    /// <summary>The <c>events_url</c> property.</summary>
    [JsonPropertyName("events_url")]
    public required string EventsUrl { get; init; }

    /// <summary>The <c>jwks_url</c> property.</summary>
    [JsonPropertyName("jwks_url")]
    public required string JwksUrl { get; init; }

    /// <summary>The <c>refresh_url</c> property.</summary>
    [JsonPropertyName("refresh_url")]
    public required string RefreshUrl { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(LicensingEndpoints? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(ActivateUrl, other.ActivateUrl)
        && global::Meteroid.Equality.Equal(EventsUrl, other.EventsUrl)
        && global::Meteroid.Equality.Equal(JwksUrl, other.JwksUrl)
        && global::Meteroid.Equality.Equal(RefreshUrl, other.RefreshUrl)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(ActivateUrl));
        hash.Add(global::Meteroid.Equality.Hash(EventsUrl));
        hash.Add(global::Meteroid.Equality.Hash(JwksUrl));
        hash.Add(global::Meteroid.Equality.Hash(RefreshUrl));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
