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
/// A pre-aggregation filter: only events whose <c>property</c> matches feed the metric's
/// aggregation. Distinct from a segmentation dimension (which splits pricing). Multiple
/// filters are ANDed.
/// </summary>
public sealed partial record MetricFilter
{
    /// <summary>The <c>op</c> property.</summary>
    [JsonPropertyName("op")]
    public required MetricFilterOperator Op { get; init; }

    /// <summary>The <c>property</c> property.</summary>
    [JsonPropertyName("property")]
    public required string Property { get; init; }

    /// <summary>The <c>values</c> property.</summary>
    [JsonPropertyName("values")]
    public required IReadOnlyList<string> Values { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(MetricFilter? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Op, other.Op)
        && global::Meteroid.Equality.Equal(Property, other.Property)
        && global::Meteroid.Equality.Equal(Values, other.Values)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Op));
        hash.Add(global::Meteroid.Equality.Hash(Property));
        hash.Add(global::Meteroid.Equality.Hash(Values));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
