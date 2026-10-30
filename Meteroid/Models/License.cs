// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>License</c> object.</summary>
public sealed partial record License
{
    /// <summary>
    /// Issued automatically for a subscription to a plan that issues licenses.
    /// </summary>
    [JsonPropertyName("auto_issued")]
    public required bool AutoIssued { get; init; }

    /// <summary>The <c>created_at</c> property.</summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>The <c>customer_id</c> property.</summary>
    [JsonPropertyName("customer_id")]
    public required string CustomerId { get; init; }

    /// <summary>The <c>customer_name</c> property.</summary>
    [JsonPropertyName("customer_name")]
    public required string CustomerName { get; init; }

    /// <summary>
    /// Whether the activation code can still be retrieved: only until activation or revocation.
    /// </summary>
    [JsonPropertyName("has_activation_code")]
    public required bool HasActivationCode { get; init; }

    /// <summary>The <c>id</c> property.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The installation the license is bound to, once activated.
    /// </summary>
    [JsonPropertyName("instance_id")]
    public string? InstanceId { get; init; }

    /// <summary>The <c>last_refreshed_at</c> property.</summary>
    [JsonPropertyName("last_refreshed_at")]
    public DateTimeOffset? LastRefreshedAt { get; init; }

    /// <summary>
    /// Issued as a signed offline license: never activated nor refreshed.
    /// </summary>
    [JsonPropertyName("offline")]
    public required bool Offline { get; init; }

    /// <summary>The <c>plan_name</c> property.</summary>
    [JsonPropertyName("plan_name")]
    public string? PlanName { get; init; }

    /// <summary>The <c>revoked_at</c> property.</summary>
    [JsonPropertyName("revoked_at")]
    public DateTimeOffset? RevokedAt { get; init; }

    /// <summary>
    /// Revoked to stop at once: the installation drops its license on its next refresh instead
    /// of keeping it until it expires.
    /// </summary>
    [JsonPropertyName("revoked_immediately")]
    public required bool RevokedImmediately { get; init; }

    /// <summary>The <c>status</c> property.</summary>
    [JsonPropertyName("status")]
    public required LicenseStatus Status { get; init; }

    /// <summary>The <c>subscription_id</c> property.</summary>
    [JsonPropertyName("subscription_id")]
    public string? SubscriptionId { get; init; }

    /// <summary>
    /// Lifetime of each license token the installation receives on refresh; for an offline
    /// license, the lifetime it was issued with.
    /// </summary>
    [JsonPropertyName("validity_days")]
    public required int ValidityDays { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(License? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(AutoIssued, other.AutoIssued)
        && global::Meteroid.Equality.Equal(CreatedAt, other.CreatedAt)
        && global::Meteroid.Equality.Equal(CustomerId, other.CustomerId)
        && global::Meteroid.Equality.Equal(CustomerName, other.CustomerName)
        && global::Meteroid.Equality.Equal(HasActivationCode, other.HasActivationCode)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(InstanceId, other.InstanceId)
        && global::Meteroid.Equality.Equal(LastRefreshedAt, other.LastRefreshedAt)
        && global::Meteroid.Equality.Equal(Offline, other.Offline)
        && global::Meteroid.Equality.Equal(PlanName, other.PlanName)
        && global::Meteroid.Equality.Equal(RevokedAt, other.RevokedAt)
        && global::Meteroid.Equality.Equal(RevokedImmediately, other.RevokedImmediately)
        && global::Meteroid.Equality.Equal(Status, other.Status)
        && global::Meteroid.Equality.Equal(SubscriptionId, other.SubscriptionId)
        && global::Meteroid.Equality.Equal(ValidityDays, other.ValidityDays)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(AutoIssued));
        hash.Add(global::Meteroid.Equality.Hash(CreatedAt));
        hash.Add(global::Meteroid.Equality.Hash(CustomerId));
        hash.Add(global::Meteroid.Equality.Hash(CustomerName));
        hash.Add(global::Meteroid.Equality.Hash(HasActivationCode));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(InstanceId));
        hash.Add(global::Meteroid.Equality.Hash(LastRefreshedAt));
        hash.Add(global::Meteroid.Equality.Hash(Offline));
        hash.Add(global::Meteroid.Equality.Hash(PlanName));
        hash.Add(global::Meteroid.Equality.Hash(RevokedAt));
        hash.Add(global::Meteroid.Equality.Hash(RevokedImmediately));
        hash.Add(global::Meteroid.Equality.Hash(Status));
        hash.Add(global::Meteroid.Equality.Hash(SubscriptionId));
        hash.Add(global::Meteroid.Equality.Hash(ValidityDays));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
