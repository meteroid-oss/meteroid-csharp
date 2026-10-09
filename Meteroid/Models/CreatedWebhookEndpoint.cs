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
/// The signing secret is returned in full here and never again outside the reveal
/// and rotate endpoints.
/// </summary>
public sealed partial record CreatedWebhookEndpoint
{
    /// <summary>
    /// Failures since the last success, reset to 0 on any 2xx.
    /// </summary>
    [JsonPropertyName("consecutive_failures")]
    public required int ConsecutiveFailures { get; init; }

    /// <summary>The <c>created_at</c> property.</summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>The <c>description</c> property.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>The <c>disabled</c> property.</summary>
    [JsonPropertyName("disabled")]
    public required bool Disabled { get; init; }

    /// <summary>The <c>disabled_reason</c> property.</summary>
    [JsonPropertyName("disabled_reason")]
    public WebhookEndpointDisabledReason? DisabledReason { get; init; }

    /// <summary>
    /// Subscribed event types. Empty means every event type.
    /// </summary>
    [JsonPropertyName("event_types")]
    public required IReadOnlyList<string> EventTypes { get; init; }

    /// <summary>
    /// Custom headers sent with every delivery.
    /// </summary>
    [JsonPropertyName("headers")]
    public required IReadOnlyList<WebhookHeader> Headers { get; init; }

    /// <summary>The <c>id</c> property.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>The <c>last_failure_at</c> property.</summary>
    [JsonPropertyName("last_failure_at")]
    public DateTimeOffset? LastFailureAt { get; init; }

    /// <summary>The <c>last_success_at</c> property.</summary>
    [JsonPropertyName("last_success_at")]
    public DateTimeOffset? LastSuccessAt { get; init; }

    /// <summary>
    /// How many deliveries this endpoint may have in flight at once. Read-only; it is
    /// set from the tenant's environment when the endpoint is created.
    /// </summary>
    [JsonPropertyName("max_in_flight")]
    public required int MaxInFlight { get; init; }

    /// <summary>
    /// A sensitive header still waits for its value; the endpoint cannot be enabled
    /// until it is set.
    /// </summary>
    [JsonPropertyName("needs_setup")]
    public required bool NeedsSetup { get; init; }

    /// <summary>
    /// The endpoint was unreachable several times in a row: nothing is sent before
    /// this time, then it is retried one delivery at a time until it answers again.
    /// </summary>
    [JsonPropertyName("paused_until")]
    public DateTimeOffset? PausedUntil { get; init; }

    /// <summary>
    /// Deliveries started per second, at most.
    /// </summary>
    [JsonPropertyName("rate_limit_per_sec")]
    public int? RateLimitPerSec { get; init; }

    /// <summary>The <c>updated_at</c> property.</summary>
    [JsonPropertyName("updated_at")]
    public DateTimeOffset? UpdatedAt { get; init; }

    /// <summary>The <c>url</c> property.</summary>
    [JsonPropertyName("url")]
    public required string Url { get; init; }

    /// <summary>The <c>secret</c> property.</summary>
    [JsonPropertyName("secret")]
    public required string Secret { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(CreatedWebhookEndpoint? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(ConsecutiveFailures, other.ConsecutiveFailures)
        && global::Meteroid.Equality.Equal(CreatedAt, other.CreatedAt)
        && global::Meteroid.Equality.Equal(Description, other.Description)
        && global::Meteroid.Equality.Equal(Disabled, other.Disabled)
        && global::Meteroid.Equality.Equal(DisabledReason, other.DisabledReason)
        && global::Meteroid.Equality.Equal(EventTypes, other.EventTypes)
        && global::Meteroid.Equality.Equal(Headers, other.Headers)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(LastFailureAt, other.LastFailureAt)
        && global::Meteroid.Equality.Equal(LastSuccessAt, other.LastSuccessAt)
        && global::Meteroid.Equality.Equal(MaxInFlight, other.MaxInFlight)
        && global::Meteroid.Equality.Equal(NeedsSetup, other.NeedsSetup)
        && global::Meteroid.Equality.Equal(PausedUntil, other.PausedUntil)
        && global::Meteroid.Equality.Equal(RateLimitPerSec, other.RateLimitPerSec)
        && global::Meteroid.Equality.Equal(UpdatedAt, other.UpdatedAt)
        && global::Meteroid.Equality.Equal(Url, other.Url)
        && global::Meteroid.Equality.Equal(Secret, other.Secret)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(ConsecutiveFailures));
        hash.Add(global::Meteroid.Equality.Hash(CreatedAt));
        hash.Add(global::Meteroid.Equality.Hash(Description));
        hash.Add(global::Meteroid.Equality.Hash(Disabled));
        hash.Add(global::Meteroid.Equality.Hash(DisabledReason));
        hash.Add(global::Meteroid.Equality.Hash(EventTypes));
        hash.Add(global::Meteroid.Equality.Hash(Headers));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(LastFailureAt));
        hash.Add(global::Meteroid.Equality.Hash(LastSuccessAt));
        hash.Add(global::Meteroid.Equality.Hash(MaxInFlight));
        hash.Add(global::Meteroid.Equality.Hash(NeedsSetup));
        hash.Add(global::Meteroid.Equality.Hash(PausedUntil));
        hash.Add(global::Meteroid.Equality.Hash(RateLimitPerSec));
        hash.Add(global::Meteroid.Equality.Hash(UpdatedAt));
        hash.Add(global::Meteroid.Equality.Hash(Url));
        hash.Add(global::Meteroid.Equality.Hash(Secret));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
