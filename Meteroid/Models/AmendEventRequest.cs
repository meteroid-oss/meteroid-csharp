// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>AmendEventRequest</c> object.</summary>
public sealed partial record AmendEventRequest
{
    /// <summary>
    /// Allow a timestamp more than 1 day in the past. Defaults to <c>false</c>.
    /// </summary>
    [JsonPropertyName("allow_backfilling")]
    public bool? AllowBackfilling { get; init; }

    /// <summary>
    /// External customer alias of the event. Set this or <c>customer_id</c>.
    /// </summary>
    [JsonPropertyName("customer_alias")]
    public string? CustomerAlias { get; init; }

    /// <summary>
    /// Meteroid customer ID of the event. Set this or <c>customer_alias</c>.
    /// </summary>
    [JsonPropertyName("customer_id")]
    public string? CustomerId { get; init; }

    /// <summary>
    /// The corrected properties. They replace the stored ones.
    /// </summary>
    [JsonPropertyName("properties")]
    public required IReadOnlyDictionary<string, string> Properties { get; init; }

    /// <summary>
    /// RFC 3339 timestamp of the corrected event.
    /// Must be between 24 hours ago and 1 hour from now. Set <c>allow_backfilling</c> to remove the past limit.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public required DateTimeOffset Timestamp { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(AmendEventRequest? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(AllowBackfilling, other.AllowBackfilling)
        && global::Meteroid.Equality.Equal(CustomerAlias, other.CustomerAlias)
        && global::Meteroid.Equality.Equal(CustomerId, other.CustomerId)
        && global::Meteroid.Equality.Equal(Properties, other.Properties)
        && global::Meteroid.Equality.Equal(Timestamp, other.Timestamp)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(AllowBackfilling));
        hash.Add(global::Meteroid.Equality.Hash(CustomerAlias));
        hash.Add(global::Meteroid.Equality.Hash(CustomerId));
        hash.Add(global::Meteroid.Equality.Hash(Properties));
        hash.Add(global::Meteroid.Equality.Hash(Timestamp));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
