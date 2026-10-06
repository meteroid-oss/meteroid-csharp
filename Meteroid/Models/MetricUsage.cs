// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>MetricUsage</c> object.</summary>
public sealed partial record MetricUsage
{
    /// <summary>The <c>grouped_usage</c> property.</summary>
    [JsonPropertyName("grouped_usage")]
    public required IReadOnlyList<GroupedUsage> GroupedUsage { get; init; }

    /// <summary>The <c>metric_code</c> property.</summary>
    [JsonPropertyName("metric_code")]
    public required string MetricCode { get; init; }

    /// <summary>The <c>metric_id</c> property.</summary>
    [JsonPropertyName("metric_id")]
    public required string MetricId { get; init; }

    /// <summary>The <c>metric_name</c> property.</summary>
    [JsonPropertyName("metric_name")]
    public required string MetricName { get; init; }

    /// <summary>The <c>total_value</c> property.</summary>
    [JsonPropertyName("total_value")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public required decimal TotalValue { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(MetricUsage? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(GroupedUsage, other.GroupedUsage)
        && global::Meteroid.Equality.Equal(MetricCode, other.MetricCode)
        && global::Meteroid.Equality.Equal(MetricId, other.MetricId)
        && global::Meteroid.Equality.Equal(MetricName, other.MetricName)
        && global::Meteroid.Equality.Equal(TotalValue, other.TotalValue)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(GroupedUsage));
        hash.Add(global::Meteroid.Equality.Hash(MetricCode));
        hash.Add(global::Meteroid.Equality.Hash(MetricId));
        hash.Add(global::Meteroid.Equality.Hash(MetricName));
        hash.Add(global::Meteroid.Equality.Hash(TotalValue));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
