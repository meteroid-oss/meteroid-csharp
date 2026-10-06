// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>IngestEventsRequest</c> object.</summary>
public sealed partial record IngestEventsRequest
{
    /// <summary>
    /// Allow events with timestamps more than 1 day in the past. Defaults to <c>false</c>.
    /// </summary>
    [JsonPropertyName("allow_backfilling")]
    public bool? AllowBackfilling { get; init; }

    /// <summary>
    /// Accept the batch even if some events fail validation. Defaults to <c>false</c>.
    /// When <c>true</c>, valid events are ingested and failures are reported in the response body.
    /// When <c>false</c> (default), any invalid event rejects the entire batch.
    /// </summary>
    [JsonPropertyName("allow_partial_failures")]
    public bool? AllowPartialFailures { get; init; }

    /// <summary>
    /// 1–100 events per request.
    /// </summary>
    [JsonPropertyName("events")]
    public required IReadOnlyList<Event> Events { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(IngestEventsRequest? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(AllowBackfilling, other.AllowBackfilling)
        && global::Meteroid.Equality.Equal(AllowPartialFailures, other.AllowPartialFailures)
        && global::Meteroid.Equality.Equal(Events, other.Events)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(AllowBackfilling));
        hash.Add(global::Meteroid.Equality.Hash(AllowPartialFailures));
        hash.Add(global::Meteroid.Equality.Hash(Events));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
