// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>CreateWebhookEndpointRequest</c> object.</summary>
public sealed partial record CreateWebhookEndpointRequest
{
    /// <summary>The <c>description</c> property.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Event types to subscribe to. Omit or leave empty to receive every event type.
    /// </summary>
    [JsonPropertyName("event_types")]
    public IReadOnlyList<string>? EventTypes { get; init; }

    /// <summary>
    /// Custom headers sent with every delivery.
    /// </summary>
    [JsonPropertyName("headers")]
    public IReadOnlyList<WebhookHeaderInput>? Headers { get; init; }

    /// <summary>
    /// Deliveries started per second, at most (1 to 1000).
    /// </summary>
    [JsonPropertyName("rate_limit_per_sec")]
    public int? RateLimitPerSec { get; init; }

    /// <summary>
    /// HTTPS destination. Private and loopback addresses are rejected unless the
    /// instance is configured to allow them.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(CreateWebhookEndpointRequest? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Description, other.Description)
        && global::Meteroid.Equality.Equal(EventTypes, other.EventTypes)
        && global::Meteroid.Equality.Equal(Headers, other.Headers)
        && global::Meteroid.Equality.Equal(RateLimitPerSec, other.RateLimitPerSec)
        && global::Meteroid.Equality.Equal(Url, other.Url)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Description));
        hash.Add(global::Meteroid.Equality.Hash(EventTypes));
        hash.Add(global::Meteroid.Equality.Hash(Headers));
        hash.Add(global::Meteroid.Equality.Hash(RateLimitPerSec));
        hash.Add(global::Meteroid.Equality.Hash(Url));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
