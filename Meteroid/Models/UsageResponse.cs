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
    /// <summary>The <c>period_end</c> property.</summary>
    [JsonPropertyName("period_end")]
    public required DateOnly PeriodEnd { get; init; }

    /// <summary>The <c>period_start</c> property.</summary>
    [JsonPropertyName("period_start")]
    public required DateOnly PeriodStart { get; init; }

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
        && global::Meteroid.Equality.Equal(PeriodEnd, other.PeriodEnd)
        && global::Meteroid.Equality.Equal(PeriodStart, other.PeriodStart)
        && global::Meteroid.Equality.Equal(Usage, other.Usage)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(PeriodEnd));
        hash.Add(global::Meteroid.Equality.Hash(PeriodStart));
        hash.Add(global::Meteroid.Equality.Hash(Usage));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
