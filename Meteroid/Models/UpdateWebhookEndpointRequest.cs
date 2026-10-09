// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>UpdateWebhookEndpointRequest</c> object.</summary>
public sealed partial record UpdateWebhookEndpointRequest
{
    /// <summary>
    /// Omit to leave unchanged; send <c>null</c> or an empty string to clear.
    /// </summary>
    [JsonPropertyName("description")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<string?>))]
    public MaybeUnset<string?> Description { get; init; }

    /// <summary>
    /// Re-enabling an endpoint also resets its consecutive failure count.
    /// </summary>
    [JsonPropertyName("disabled")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<bool?>))]
    public MaybeUnset<bool?> Disabled { get; init; }

    /// <summary>
    /// Replaces the subscription list. An empty array subscribes to every event type.
    /// </summary>
    [JsonPropertyName("event_types")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<IReadOnlyList<string>?>))]
    public MaybeUnset<IReadOnlyList<string>?> EventTypes { get; init; }

    /// <summary>
    /// Replaces the custom header list. An empty array removes every header.
    /// </summary>
    [JsonPropertyName("headers")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<IReadOnlyList<WebhookHeaderInput>?>))]
    public MaybeUnset<IReadOnlyList<WebhookHeaderInput>?> Headers { get; init; }

    /// <summary>
    /// Omit to leave unchanged; send <c>null</c> to remove the rate limit.
    /// </summary>
    [JsonPropertyName("rate_limit_per_sec")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<int?>))]
    public MaybeUnset<int?> RateLimitPerSec { get; init; }

    /// <summary>The <c>url</c> property.</summary>
    [JsonPropertyName("url")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<string?>))]
    public MaybeUnset<string?> Url { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(UpdateWebhookEndpointRequest? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Description, other.Description)
        && global::Meteroid.Equality.Equal(Disabled, other.Disabled)
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
        hash.Add(global::Meteroid.Equality.Hash(Disabled));
        hash.Add(global::Meteroid.Equality.Hash(EventTypes));
        hash.Add(global::Meteroid.Equality.Hash(Headers));
        hash.Add(global::Meteroid.Equality.Hash(RateLimitPerSec));
        hash.Add(global::Meteroid.Equality.Hash(Url));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
