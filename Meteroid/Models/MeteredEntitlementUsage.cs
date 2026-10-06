// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>MeteredEntitlementUsage</c> object.</summary>
public sealed partial record MeteredEntitlementUsage
{
    /// <summary>The <c>consumed</c> property.</summary>
    [JsonPropertyName("consumed")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public decimal? Consumed { get; init; }

    /// <summary>The <c>remaining</c> property.</summary>
    [JsonPropertyName("remaining")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public decimal? Remaining { get; init; }

    /// <summary>The <c>reset_at</c> property.</summary>
    [JsonPropertyName("reset_at")]
    public DateTimeOffset? ResetAt { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(MeteredEntitlementUsage? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Consumed, other.Consumed)
        && global::Meteroid.Equality.Equal(Remaining, other.Remaining)
        && global::Meteroid.Equality.Equal(ResetAt, other.ResetAt)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Consumed));
        hash.Add(global::Meteroid.Equality.Hash(Remaining));
        hash.Add(global::Meteroid.Equality.Hash(ResetAt));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
