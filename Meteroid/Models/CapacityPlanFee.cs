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
/// Capacity-based fee with included committed usage and overage
/// </summary>
public sealed partial record CapacityPlanFee
{
    /// <summary>The <c>cadence</c> property.</summary>
    [JsonPropertyName("cadence")]
    public required BillingPeriodEnum Cadence { get; init; }

    /// <summary>The <c>metric_id</c> property.</summary>
    [JsonPropertyName("metric_id")]
    public required string MetricId { get; init; }

    /// <summary>The <c>thresholds</c> property.</summary>
    [JsonPropertyName("thresholds")]
    public required IReadOnlyList<CapacityThreshold> Thresholds { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(CapacityPlanFee? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Cadence, other.Cadence)
        && global::Meteroid.Equality.Equal(MetricId, other.MetricId)
        && global::Meteroid.Equality.Equal(Thresholds, other.Thresholds)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Cadence));
        hash.Add(global::Meteroid.Equality.Hash(MetricId));
        hash.Add(global::Meteroid.Equality.Hash(Thresholds));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
