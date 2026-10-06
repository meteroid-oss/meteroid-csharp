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
/// Type-specific configuration. Only the fields relevant to <c>property_type</c> are interpreted.
/// </summary>
public sealed partial record PropertyConfig
{
    /// <summary>The <c>max</c> property.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; init; }

    /// <summary>
    /// Maximum length for <c>TEXT</c>.
    /// </summary>
    [JsonPropertyName("max_length")]
    public int? MaxLength { get; init; }

    /// <summary>
    /// Inclusive numeric bounds for <c>NUMBER</c>.
    /// </summary>
    [JsonPropertyName("min")]
    public double? Min { get; init; }

    /// <summary>
    /// Allowed choices for <c>SINGLE_SELECT</c> / <c>MULTI_SELECT</c>.
    /// </summary>
    [JsonPropertyName("options")]
    public IReadOnlyList<SelectOption>? Options { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(PropertyConfig? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Max, other.Max)
        && global::Meteroid.Equality.Equal(MaxLength, other.MaxLength)
        && global::Meteroid.Equality.Equal(Min, other.Min)
        && global::Meteroid.Equality.Equal(Options, other.Options)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Max));
        hash.Add(global::Meteroid.Equality.Hash(MaxLength));
        hash.Add(global::Meteroid.Equality.Hash(Min));
        hash.Add(global::Meteroid.Equality.Hash(Options));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
