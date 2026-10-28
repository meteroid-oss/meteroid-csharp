// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>UsageCostRow</c> object.</summary>
public sealed partial record UsageCostRow
{
    /// <summary>The <c>bucket_start</c> property.</summary>
    [JsonPropertyName("bucket_start")]
    public required DateTimeOffset BucketStart { get; init; }

    /// <summary>The <c>cost</c> property.</summary>
    [JsonPropertyName("cost")]
    public UsageCost? Cost { get; init; }

    /// <summary>
    /// False when the price depends on the whole period's usage (tiered, volume, package,
    /// capacity): the cost is then what the bucket adds to the period's price so far. A period's
    /// rows still add up to its invoiced amount.
    /// </summary>
    [JsonPropertyName("exact")]
    public required bool Exact { get; init; }

    /// <summary>
    /// The value of <c>group_by</c> for the row. Absent when the request is not grouped, or the usage
    /// has no value for the property.
    /// </summary>
    [JsonPropertyName("group")]
    public string? Group { get; init; }

    /// <summary>The <c>quantity</c> property.</summary>
    [JsonPropertyName("quantity")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public required decimal Quantity { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(UsageCostRow? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(BucketStart, other.BucketStart)
        && global::Meteroid.Equality.Equal(Cost, other.Cost)
        && global::Meteroid.Equality.Equal(Exact, other.Exact)
        && global::Meteroid.Equality.Equal(Group, other.Group)
        && global::Meteroid.Equality.Equal(Quantity, other.Quantity)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(BucketStart));
        hash.Add(global::Meteroid.Equality.Hash(Cost));
        hash.Add(global::Meteroid.Equality.Hash(Exact));
        hash.Add(global::Meteroid.Equality.Hash(Group));
        hash.Add(global::Meteroid.Equality.Hash(Quantity));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
