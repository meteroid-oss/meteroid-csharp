// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>MeteredEntitlementSpec</c> object.</summary>
public sealed partial record MeteredEntitlementSpec
{
    /// <summary>The <c>enabled</c> property.</summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; init; }

    /// <summary>The <c>limit</c> property.</summary>
    [JsonPropertyName("limit")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public decimal? Limit { get; init; }

    /// <summary>The <c>metric_id</c> property.</summary>
    [JsonPropertyName("metric_id")]
    public required string MetricId { get; init; }

    /// <summary>The <c>reset_period</c> property.</summary>
    [JsonPropertyName("reset_period")]
    public required ResetPeriod ResetPeriod { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(MeteredEntitlementSpec? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Enabled, other.Enabled)
        && global::Meteroid.Equality.Equal(Limit, other.Limit)
        && global::Meteroid.Equality.Equal(MetricId, other.MetricId)
        && global::Meteroid.Equality.Equal(ResetPeriod, other.ResetPeriod)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Enabled));
        hash.Add(global::Meteroid.Equality.Hash(Limit));
        hash.Add(global::Meteroid.Equality.Hash(MetricId));
        hash.Add(global::Meteroid.Equality.Hash(ResetPeriod));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
