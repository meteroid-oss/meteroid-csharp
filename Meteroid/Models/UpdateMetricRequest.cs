// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>UpdateMetricRequest</c> object.</summary>
public sealed partial record UpdateMetricRequest
{
    /// <summary>The <c>description</c> property.</summary>
    [JsonPropertyName("description")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<string?>))]
    public MaybeUnset<string?> Description { get; init; }

    /// <summary>
    /// Absent = leave filters untouched; present (even empty) = replace them.
    /// </summary>
    [JsonPropertyName("filters")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<IReadOnlyList<MetricFilter>?>))]
    public MaybeUnset<IReadOnlyList<MetricFilter>?> Filters { get; init; }

    /// <summary>The <c>name</c> property.</summary>
    [JsonPropertyName("name")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<string?>))]
    public MaybeUnset<string?> Name { get; init; }

    /// <summary>The <c>segmentation_matrix</c> property.</summary>
    [JsonPropertyName("segmentation_matrix")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<MetricSegmentationMatrix?>))]
    public MaybeUnset<MetricSegmentationMatrix?> SegmentationMatrix { get; init; }

    /// <summary>The <c>unit_conversion</c> property.</summary>
    [JsonPropertyName("unit_conversion")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<UnitConversion?>))]
    public MaybeUnset<UnitConversion?> UnitConversion { get; init; }

    /// <summary>
    /// What several units of the metric are called, e.g. <c>tokens</c>. See <c>unit_singular</c>.
    /// </summary>
    [JsonPropertyName("unit_plural")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<string?>))]
    public MaybeUnset<string?> UnitPlural { get; init; }

    /// <summary>
    /// What one unit of the metric is called, e.g. <c>token</c>. Send <c>unit_singular</c> and
    /// <c>unit_plural</c> together; omit both to leave the label unchanged, or send both as empty
    /// strings to remove it. Trimmed; at most 32 characters.
    /// </summary>
    [JsonPropertyName("unit_singular")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<string?>))]
    public MaybeUnset<string?> UnitSingular { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(UpdateMetricRequest? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Description, other.Description)
        && global::Meteroid.Equality.Equal(Filters, other.Filters)
        && global::Meteroid.Equality.Equal(Name, other.Name)
        && global::Meteroid.Equality.Equal(SegmentationMatrix, other.SegmentationMatrix)
        && global::Meteroid.Equality.Equal(UnitConversion, other.UnitConversion)
        && global::Meteroid.Equality.Equal(UnitPlural, other.UnitPlural)
        && global::Meteroid.Equality.Equal(UnitSingular, other.UnitSingular)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Description));
        hash.Add(global::Meteroid.Equality.Hash(Filters));
        hash.Add(global::Meteroid.Equality.Hash(Name));
        hash.Add(global::Meteroid.Equality.Hash(SegmentationMatrix));
        hash.Add(global::Meteroid.Equality.Hash(UnitConversion));
        hash.Add(global::Meteroid.Equality.Hash(UnitPlural));
        hash.Add(global::Meteroid.Equality.Hash(UnitSingular));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
