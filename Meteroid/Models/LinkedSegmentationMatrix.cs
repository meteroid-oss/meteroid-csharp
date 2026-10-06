// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>LinkedSegmentationMatrix</c> object.</summary>
public sealed partial record LinkedSegmentationMatrix
{
    /// <summary>The <c>dimension1_key</c> property.</summary>
    [JsonPropertyName("dimension1_key")]
    public required string Dimension1Key { get; init; }

    /// <summary>The <c>dimension2_key</c> property.</summary>
    [JsonPropertyName("dimension2_key")]
    public required string Dimension2Key { get; init; }

    /// <summary>The <c>values</c> property.</summary>
    [JsonPropertyName("values")]
    public required IReadOnlyDictionary<string, IReadOnlyList<string>> Values { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(LinkedSegmentationMatrix? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Dimension1Key, other.Dimension1Key)
        && global::Meteroid.Equality.Equal(Dimension2Key, other.Dimension2Key)
        && global::Meteroid.Equality.Equal(Values, other.Values)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Dimension1Key));
        hash.Add(global::Meteroid.Equality.Hash(Dimension2Key));
        hash.Add(global::Meteroid.Equality.Hash(Values));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
