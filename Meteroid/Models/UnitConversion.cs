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
/// Converts the aggregated usage into the unit prices are set in, e.g. tokens priced per 1M.
/// The usage is divided by <c>factor</c>, then rounded. Rounding applies to each priced group's
/// total for the billing period: each group of a segmented or grouped metric, and each matrix
/// cell, is rounded on its own, never each event.
/// </summary>
public sealed partial record UnitConversion
{
    /// <summary>
    /// Raw units per priced unit, e.g. <c>1000000</c> to price per 1M.
    /// </summary>
    [JsonPropertyName("factor")]
    public required int Factor { get; init; }

    /// <summary>The <c>rounding</c> property.</summary>
    [JsonPropertyName("rounding")]
    public required UnitConversionRoundingEnum Rounding { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(UnitConversion? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Factor, other.Factor)
        && global::Meteroid.Equality.Equal(Rounding, other.Rounding)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Factor));
        hash.Add(global::Meteroid.Equality.Hash(Rounding));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
