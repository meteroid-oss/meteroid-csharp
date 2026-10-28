// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>UsageEvent</c> object.</summary>
public sealed partial record UsageEvent
{
    /// <summary>The <c>cost</c> property.</summary>
    [JsonPropertyName("cost")]
    public UsageCost? Cost { get; init; }

    /// <summary>The <c>id</c> property.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>The <c>properties</c> property.</summary>
    [JsonPropertyName("properties")]
    public required IReadOnlyDictionary<string, string> Properties { get; init; }

    /// <summary>
    /// Billed units the event adds. Absent when the metric's aggregation cannot be split per
    /// event, or when the event does not count towards the metric.
    /// </summary>
    [JsonPropertyName("quantity")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public decimal? Quantity { get; init; }

    /// <summary>The <c>timestamp</c> property.</summary>
    [JsonPropertyName("timestamp")]
    public required DateTimeOffset Timestamp { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(UsageEvent? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Cost, other.Cost)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(Properties, other.Properties)
        && global::Meteroid.Equality.Equal(Quantity, other.Quantity)
        && global::Meteroid.Equality.Equal(Timestamp, other.Timestamp)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Cost));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(Properties));
        hash.Add(global::Meteroid.Equality.Hash(Quantity));
        hash.Add(global::Meteroid.Equality.Hash(Timestamp));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
