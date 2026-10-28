// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>MeteredResolvedEntitlementValue</c> object.</summary>
public sealed partial record MeteredResolvedEntitlementValue
{
    /// <summary>The <c>enabled</c> property.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; init; }

    /// <summary>
    /// <c>BLOCK</c> only: usage allowed beyond the limit before it is refused, in percent of it.
    /// </summary>
    [JsonPropertyName("grace_pct")]
    public int? GracePct { get; init; }

    /// <summary>
    /// Event property the limit applies to separately; usage is then the largest value's.
    /// </summary>
    [JsonPropertyName("group_by")]
    public string? GroupBy { get; init; }

    /// <summary>The <c>limit</c> property.</summary>
    [JsonPropertyName("limit")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public decimal? Limit { get; init; }

    /// <summary>The <c>metric_id</c> property.</summary>
    [JsonPropertyName("metric_id")]
    public required string MetricId { get; init; }

    /// <summary>The <c>overage_behavior</c> property.</summary>
    [JsonPropertyName("overage_behavior")]
    public EntitlementOverageBehavior? OverageBehavior { get; init; }

    /// <summary>The <c>reset_period</c> property.</summary>
    [JsonPropertyName("reset_period")]
    public required ResetPeriod ResetPeriod { get; init; }

    /// <summary>
    /// Percents of the limit at which an alert is sent, ascending.
    /// </summary>
    [JsonPropertyName("thresholds")]
    public IReadOnlyList<int>? Thresholds { get; init; }

    /// <summary>The <c>type</c> property.</summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "METERED";

    /// <summary>
    /// Deprecated: the lowest of <c>thresholds</c>.
    /// </summary>
    [JsonPropertyName("warning_threshold_pct")]
    public int? WarningThresholdPct { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(MeteredResolvedEntitlementValue? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Enabled, other.Enabled)
        && global::Meteroid.Equality.Equal(GracePct, other.GracePct)
        && global::Meteroid.Equality.Equal(GroupBy, other.GroupBy)
        && global::Meteroid.Equality.Equal(Limit, other.Limit)
        && global::Meteroid.Equality.Equal(MetricId, other.MetricId)
        && global::Meteroid.Equality.Equal(OverageBehavior, other.OverageBehavior)
        && global::Meteroid.Equality.Equal(ResetPeriod, other.ResetPeriod)
        && global::Meteroid.Equality.Equal(Thresholds, other.Thresholds)
        && global::Meteroid.Equality.Equal(Type, other.Type)
        && global::Meteroid.Equality.Equal(WarningThresholdPct, other.WarningThresholdPct)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Enabled));
        hash.Add(global::Meteroid.Equality.Hash(GracePct));
        hash.Add(global::Meteroid.Equality.Hash(GroupBy));
        hash.Add(global::Meteroid.Equality.Hash(Limit));
        hash.Add(global::Meteroid.Equality.Hash(MetricId));
        hash.Add(global::Meteroid.Equality.Hash(OverageBehavior));
        hash.Add(global::Meteroid.Equality.Hash(ResetPeriod));
        hash.Add(global::Meteroid.Equality.Hash(Thresholds));
        hash.Add(global::Meteroid.Equality.Hash(Type));
        hash.Add(global::Meteroid.Equality.Hash(WarningThresholdPct));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
