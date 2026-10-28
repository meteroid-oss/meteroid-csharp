// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>UsageResponse</c> object.</summary>
public sealed partial record UsageResponse
{
    /// <summary>
    /// Beta: when <c>totals</c> and the metrics' <c>costs</c> were computed. These are present only when a
    /// subscription's current billing period is read (no <c>start_date</c> nor <c>end_date</c>) and its
    /// usage could be priced.
    /// </summary>
    [JsonPropertyName("computed_at")]
    public DateTimeOffset? ComputedAt { get; init; }

    /// <summary>The <c>period_end</c> property.</summary>
    [JsonPropertyName("period_end")]
    public required DateOnly PeriodEnd { get; init; }

    /// <summary>The <c>period_start</c> property.</summary>
    [JsonPropertyName("period_start")]
    public required DateOnly PeriodStart { get; init; }

    /// <summary>
    /// Beta: the sum of the metrics' <c>costs</c>, per currency or credit unit.
    /// </summary>
    [JsonPropertyName("totals")]
    public IReadOnlyList<UsageCost>? Totals { get; init; }

    /// <summary>The <c>usage</c> property.</summary>
    [JsonPropertyName("usage")]
    public required IReadOnlyList<MetricUsage> Usage { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(UsageResponse? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(ComputedAt, other.ComputedAt)
        && global::Meteroid.Equality.Equal(PeriodEnd, other.PeriodEnd)
        && global::Meteroid.Equality.Equal(PeriodStart, other.PeriodStart)
        && global::Meteroid.Equality.Equal(Totals, other.Totals)
        && global::Meteroid.Equality.Equal(Usage, other.Usage)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(ComputedAt));
        hash.Add(global::Meteroid.Equality.Hash(PeriodEnd));
        hash.Add(global::Meteroid.Equality.Hash(PeriodStart));
        hash.Add(global::Meteroid.Equality.Hash(Totals));
        hash.Add(global::Meteroid.Equality.Hash(Usage));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
