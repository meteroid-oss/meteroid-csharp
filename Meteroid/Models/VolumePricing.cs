// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>VolumePricing</c> object.</summary>
public sealed partial record VolumePricing
{
    /// <summary>The <c>block_size</c> property.</summary>
    [JsonPropertyName("block_size")]
    public long? BlockSize { get; init; }

    /// <summary>The <c>tiers</c> property.</summary>
    [JsonPropertyName("tiers")]
    public required IReadOnlyList<TierRow> Tiers { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(VolumePricing? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(BlockSize, other.BlockSize)
        && global::Meteroid.Equality.Equal(Tiers, other.Tiers)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(BlockSize));
        hash.Add(global::Meteroid.Equality.Hash(Tiers));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
