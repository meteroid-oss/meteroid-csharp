// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>TierRow</c> object.</summary>
public sealed partial record TierRow
{
    /// <summary>The <c>first_unit</c> property.</summary>
    [JsonPropertyName("first_unit")]
    public required long FirstUnit { get; init; }

    /// <summary>The <c>flat_cap</c> property.</summary>
    [JsonPropertyName("flat_cap")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public decimal? FlatCap { get; init; }

    /// <summary>The <c>flat_fee</c> property.</summary>
    [JsonPropertyName("flat_fee")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public decimal? FlatFee { get; init; }

    /// <summary>The <c>rate</c> property.</summary>
    [JsonPropertyName("rate")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public required decimal Rate { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(TierRow? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(FirstUnit, other.FirstUnit)
        && global::Meteroid.Equality.Equal(FlatCap, other.FlatCap)
        && global::Meteroid.Equality.Equal(FlatFee, other.FlatFee)
        && global::Meteroid.Equality.Equal(Rate, other.Rate)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(FirstUnit));
        hash.Add(global::Meteroid.Equality.Hash(FlatCap));
        hash.Add(global::Meteroid.Equality.Hash(FlatFee));
        hash.Add(global::Meteroid.Equality.Hash(Rate));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
