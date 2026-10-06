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
/// A static, typed configuration value. No metric — resolved synchronously.
/// </summary>
public sealed partial record ConfigFeatureType
{
    /// <summary>
    /// Allowed values when <c>value_type = SELECT</c>. Empty otherwise.
    /// </summary>
    [JsonPropertyName("options")]
    public IReadOnlyList<string>? Options { get; init; }

    /// <summary>
    /// The feature's value type, fixed at creation.
    /// </summary>
    [JsonPropertyName("value_type")]
    public required ConfigValueType ValueType { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(ConfigFeatureType? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Options, other.Options)
        && global::Meteroid.Equality.Equal(ValueType, other.ValueType)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Options));
        hash.Add(global::Meteroid.Equality.Hash(ValueType));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
