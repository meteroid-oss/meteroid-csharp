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
/// Whether a customer may consume more of a feature now.
/// </summary>
public sealed partial record EntitlementCheck
{
    /// <summary>
    /// When the usage behind the answer was measured.
    /// </summary>
    [JsonPropertyName("as_of")]
    public required DateTimeOffset AsOf { get; init; }

    /// <summary>
    /// Always false: the answer reflects usage up to <c>as_of</c>.
    /// </summary>
    [JsonPropertyName("exact")]
    public required bool Exact { get; init; }

    /// <summary>The <c>feature</c> property.</summary>
    [JsonPropertyName("feature")]
    public required EntitlementCheckFeature Feature { get; init; }

    /// <summary>The <c>has_access</c> property.</summary>
    [JsonPropertyName("has_access")]
    public required bool HasAccess { get; init; }

    /// <summary>
    /// The entitlement allows overage (<c>ALLOW</c>) and the requested units go beyond its limit:
    /// access is granted, and the overage is billed.
    /// </summary>
    [JsonPropertyName("in_overage")]
    public required bool InOverage { get; init; }

    /// <summary>
    /// Age of that usage, in milliseconds.
    /// </summary>
    [JsonPropertyName("lag_ms")]
    public required long LagMs { get; init; }

    /// <summary>The <c>limit</c> property.</summary>
    [JsonPropertyName("limit")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public decimal? Limit { get; init; }

    /// <summary>
    /// Deprecated: always empty. Customer-specific limits are entitlement overrides, reported in
    /// <c>used</c>, <c>limit</c> and <c>remaining</c>.
    /// </summary>
    [JsonPropertyName("limits")]
    public required IReadOnlyList<EntitlementCheckLimit> Limits { get; init; }

    /// <summary>
    /// True when a hard limit is within 5% of being reached, reached, or refuses the request.
    /// While true, check before every request with its actual <c>requested</c>, and do not cache an
    /// answer that grants access.
    /// </summary>
    [JsonPropertyName("near_limit")]
    public required bool NearLimit { get; init; }

    /// <summary>The <c>period</c> property.</summary>
    [JsonPropertyName("period")]
    public EntitlementCheckPeriod? Period { get; init; }

    /// <summary>The <c>reason</c> property.</summary>
    [JsonPropertyName("reason")]
    public required EntitlementCheckReason Reason { get; init; }

    /// <summary>
    /// Units left before the limit, grace excluded: 0 while <c>has_access</c> is true when usage is
    /// within the grace allowance.
    /// </summary>
    [JsonPropertyName("remaining")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public decimal? Remaining { get; init; }

    /// <summary>
    /// When to check again, in milliseconds. After a refusal by a limit whose period ends within
    /// 24 hours: the time until it ends (a smaller <c>requested</c> may still be allowed sooner);
    /// absent after a refusal by a sliding window, whose usage leaves it gradually. While
    /// <c>near_limit</c> is true and access is granted: 1000.
    /// </summary>
    [JsonPropertyName("retry_after_ms")]
    public long? RetryAfterMs { get; init; }

    /// <summary>
    /// <c>used</c>, <c>limit</c>, <c>remaining</c> and <c>period</c> report the entitlement's limit. Absent when the
    /// entitlement has no limit.
    /// </summary>
    [JsonPropertyName("used")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public decimal? Used { get; init; }

    /// <summary>The <c>value</c> property.</summary>
    [JsonPropertyName("value")]
    public ConfigValue? Value { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(EntitlementCheck? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(AsOf, other.AsOf)
        && global::Meteroid.Equality.Equal(Exact, other.Exact)
        && global::Meteroid.Equality.Equal(Feature, other.Feature)
        && global::Meteroid.Equality.Equal(HasAccess, other.HasAccess)
        && global::Meteroid.Equality.Equal(InOverage, other.InOverage)
        && global::Meteroid.Equality.Equal(LagMs, other.LagMs)
        && global::Meteroid.Equality.Equal(Limit, other.Limit)
        && global::Meteroid.Equality.Equal(Limits, other.Limits)
        && global::Meteroid.Equality.Equal(NearLimit, other.NearLimit)
        && global::Meteroid.Equality.Equal(Period, other.Period)
        && global::Meteroid.Equality.Equal(Reason, other.Reason)
        && global::Meteroid.Equality.Equal(Remaining, other.Remaining)
        && global::Meteroid.Equality.Equal(RetryAfterMs, other.RetryAfterMs)
        && global::Meteroid.Equality.Equal(Used, other.Used)
        && global::Meteroid.Equality.Equal(Value, other.Value)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(AsOf));
        hash.Add(global::Meteroid.Equality.Hash(Exact));
        hash.Add(global::Meteroid.Equality.Hash(Feature));
        hash.Add(global::Meteroid.Equality.Hash(HasAccess));
        hash.Add(global::Meteroid.Equality.Hash(InOverage));
        hash.Add(global::Meteroid.Equality.Hash(LagMs));
        hash.Add(global::Meteroid.Equality.Hash(Limit));
        hash.Add(global::Meteroid.Equality.Hash(Limits));
        hash.Add(global::Meteroid.Equality.Hash(NearLimit));
        hash.Add(global::Meteroid.Equality.Hash(Period));
        hash.Add(global::Meteroid.Equality.Hash(Reason));
        hash.Add(global::Meteroid.Equality.Hash(Remaining));
        hash.Add(global::Meteroid.Equality.Hash(RetryAfterMs));
        hash.Add(global::Meteroid.Equality.Hash(Used));
        hash.Add(global::Meteroid.Equality.Hash(Value));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
