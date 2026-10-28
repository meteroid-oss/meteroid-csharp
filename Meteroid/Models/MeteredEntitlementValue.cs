// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>MeteredEntitlementValue</c> object.</summary>
public sealed partial record MeteredEntitlementValue
{
    /// <summary>
    /// Per-entitlement kill switch. <c>false</c> means disabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; init; }

    /// <summary>
    /// <c>BLOCK</c> only: usage allowed beyond the limit before it is refused, in percent of the
    /// limit (1 to 1000).
    /// </summary>
    [JsonPropertyName("grace_pct")]
    public int? GracePct { get; init; }

    /// <summary>
    /// Event property the limit applies to separately, one limit per value (e.g. <c>user_id</c>).
    /// </summary>
    [JsonPropertyName("group_by")]
    public string? GroupBy { get; init; }

    /// <summary>
    /// Cap on usage. Null means unlimited.
    /// </summary>
    [JsonPropertyName("limit")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public decimal? Limit { get; init; }

    /// <summary>The <c>overage_behavior</c> property.</summary>
    [JsonPropertyName("overage_behavior")]
    public EntitlementOverageBehavior? OverageBehavior { get; init; }

    /// <summary>The <c>reset_period</c> property.</summary>
    [JsonPropertyName("reset_period")]
    public ResetPeriod? ResetPeriod { get; init; }

    /// <summary>
    /// Percents of the limit (1 to 100, at most 10) at which an alert is sent, once per period:
    /// <c>entitlement.usage_threshold_reached</c>, or <c>entitlement.limit_reached</c> at 100. Requires a
    /// limit and a window that is not sliding.
    /// </summary>
    [JsonPropertyName("thresholds")]
    public IReadOnlyList<int>? Thresholds { get; init; }

    /// <summary>The <c>type</c> property.</summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "METERED";

    /// <summary>
    /// Deprecated: use <c>thresholds</c>. A single alert threshold, read only when <c>thresholds</c> is
    /// omitted; returned as the lowest of <c>thresholds</c>.
    /// </summary>
    [JsonPropertyName("warning_threshold_pct")]
    public int? WarningThresholdPct { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(MeteredEntitlementValue? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Enabled, other.Enabled)
        && global::Meteroid.Equality.Equal(GracePct, other.GracePct)
        && global::Meteroid.Equality.Equal(GroupBy, other.GroupBy)
        && global::Meteroid.Equality.Equal(Limit, other.Limit)
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
        hash.Add(global::Meteroid.Equality.Hash(OverageBehavior));
        hash.Add(global::Meteroid.Equality.Hash(ResetPeriod));
        hash.Add(global::Meteroid.Equality.Hash(Thresholds));
        hash.Add(global::Meteroid.Equality.Hash(Type));
        hash.Add(global::Meteroid.Equality.Hash(WarningThresholdPct));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
