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
/// One event queued for one endpoint, with the state of its retry cycle.
/// </summary>
public sealed partial record WebhookDelivery
{
    /// <summary>The <c>attempt_count</c> property.</summary>
    [JsonPropertyName("attempt_count")]
    public required int AttemptCount { get; init; }

    /// <summary>The <c>completed_at</c> property.</summary>
    [JsonPropertyName("completed_at")]
    public DateTimeOffset? CompletedAt { get; init; }

    /// <summary>The <c>created_at</c> property.</summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>The <c>endpoint_id</c> property.</summary>
    [JsonPropertyName("endpoint_id")]
    public required string EndpointId { get; init; }

    /// <summary>The <c>event_type</c> property.</summary>
    [JsonPropertyName("event_type")]
    public required string EventType { get; init; }

    /// <summary>The <c>id</c> property.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>The <c>last_error</c> property.</summary>
    [JsonPropertyName("last_error")]
    public string? LastError { get; init; }

    /// <summary>The <c>last_response_status</c> property.</summary>
    [JsonPropertyName("last_response_status")]
    public int? LastResponseStatus { get; init; }

    /// <summary>
    /// True when the delivery was created by a resend or a test event.
    /// </summary>
    [JsonPropertyName("manual")]
    public required bool Manual { get; init; }

    /// <summary>The <c>message_id</c> property.</summary>
    [JsonPropertyName("message_id")]
    public required string MessageId { get; init; }

    /// <summary>The <c>next_attempt_at</c> property.</summary>
    [JsonPropertyName("next_attempt_at")]
    public DateTimeOffset? NextAttemptAt { get; init; }

    /// <summary>The <c>status</c> property.</summary>
    [JsonPropertyName("status")]
    public required WebhookDeliveryStatus Status { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(WebhookDelivery? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(AttemptCount, other.AttemptCount)
        && global::Meteroid.Equality.Equal(CompletedAt, other.CompletedAt)
        && global::Meteroid.Equality.Equal(CreatedAt, other.CreatedAt)
        && global::Meteroid.Equality.Equal(EndpointId, other.EndpointId)
        && global::Meteroid.Equality.Equal(EventType, other.EventType)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(LastError, other.LastError)
        && global::Meteroid.Equality.Equal(LastResponseStatus, other.LastResponseStatus)
        && global::Meteroid.Equality.Equal(Manual, other.Manual)
        && global::Meteroid.Equality.Equal(MessageId, other.MessageId)
        && global::Meteroid.Equality.Equal(NextAttemptAt, other.NextAttemptAt)
        && global::Meteroid.Equality.Equal(Status, other.Status)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(AttemptCount));
        hash.Add(global::Meteroid.Equality.Hash(CompletedAt));
        hash.Add(global::Meteroid.Equality.Hash(CreatedAt));
        hash.Add(global::Meteroid.Equality.Hash(EndpointId));
        hash.Add(global::Meteroid.Equality.Hash(EventType));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(LastError));
        hash.Add(global::Meteroid.Equality.Hash(LastResponseStatus));
        hash.Add(global::Meteroid.Equality.Hash(Manual));
        hash.Add(global::Meteroid.Equality.Hash(MessageId));
        hash.Add(global::Meteroid.Equality.Hash(NextAttemptAt));
        hash.Add(global::Meteroid.Equality.Hash(Status));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
