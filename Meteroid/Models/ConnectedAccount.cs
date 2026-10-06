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
/// A connected account (relationship between platform and connected org)
/// </summary>
public sealed partial record ConnectedAccount
{
    /// <summary>The <c>connected_organization_id</c> property.</summary>
    [JsonPropertyName("connected_organization_id")]
    public string? ConnectedOrganizationId { get; init; }

    /// <summary>The <c>connected_tenant_id</c> property.</summary>
    [JsonPropertyName("connected_tenant_id")]
    public string? ConnectedTenantId { get; init; }

    /// <summary>The <c>connection_type</c> property.</summary>
    [JsonPropertyName("connection_type")]
    public required ConnectionType ConnectionType { get; init; }

    /// <summary>The <c>created_at</c> property.</summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>The <c>id</c> property.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>The <c>metadata</c> property.</summary>
    [JsonPropertyName("metadata")]
    public JsonNode? Metadata { get; init; }

    /// <summary>The <c>onboarding_completed_at</c> property.</summary>
    [JsonPropertyName("onboarding_completed_at")]
    public DateTimeOffset? OnboardingCompletedAt { get; init; }

    /// <summary>The <c>onboarding_mode</c> property.</summary>
    [JsonPropertyName("onboarding_mode")]
    public required OnboardingMode OnboardingMode { get; init; }

    /// <summary>The <c>pending_country</c> property.</summary>
    [JsonPropertyName("pending_country")]
    public string? PendingCountry { get; init; }

    /// <summary>
    /// Email of the user being invited (express flow only)
    /// </summary>
    [JsonPropertyName("pending_email")]
    public string? PendingEmail { get; init; }

    /// <summary>
    /// Name of the organization to be created (express flow only)
    /// </summary>
    [JsonPropertyName("pending_organization_name")]
    public string? PendingOrganizationName { get; init; }

    /// <summary>The <c>platform_customer_id</c> property.</summary>
    [JsonPropertyName("platform_customer_id")]
    public string? PlatformCustomerId { get; init; }

    /// <summary>The <c>platform_organization_id</c> property.</summary>
    [JsonPropertyName("platform_organization_id")]
    public required string PlatformOrganizationId { get; init; }

    /// <summary>The <c>revoked_at</c> property.</summary>
    [JsonPropertyName("revoked_at")]
    public DateTimeOffset? RevokedAt { get; init; }

    /// <summary>The <c>status</c> property.</summary>
    [JsonPropertyName("status")]
    public required ConnectionStatus Status { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(ConnectedAccount? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(ConnectedOrganizationId, other.ConnectedOrganizationId)
        && global::Meteroid.Equality.Equal(ConnectedTenantId, other.ConnectedTenantId)
        && global::Meteroid.Equality.Equal(ConnectionType, other.ConnectionType)
        && global::Meteroid.Equality.Equal(CreatedAt, other.CreatedAt)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(Metadata, other.Metadata)
        && global::Meteroid.Equality.Equal(OnboardingCompletedAt, other.OnboardingCompletedAt)
        && global::Meteroid.Equality.Equal(OnboardingMode, other.OnboardingMode)
        && global::Meteroid.Equality.Equal(PendingCountry, other.PendingCountry)
        && global::Meteroid.Equality.Equal(PendingEmail, other.PendingEmail)
        && global::Meteroid.Equality.Equal(PendingOrganizationName, other.PendingOrganizationName)
        && global::Meteroid.Equality.Equal(PlatformCustomerId, other.PlatformCustomerId)
        && global::Meteroid.Equality.Equal(PlatformOrganizationId, other.PlatformOrganizationId)
        && global::Meteroid.Equality.Equal(RevokedAt, other.RevokedAt)
        && global::Meteroid.Equality.Equal(Status, other.Status)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(ConnectedOrganizationId));
        hash.Add(global::Meteroid.Equality.Hash(ConnectedTenantId));
        hash.Add(global::Meteroid.Equality.Hash(ConnectionType));
        hash.Add(global::Meteroid.Equality.Hash(CreatedAt));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(Metadata));
        hash.Add(global::Meteroid.Equality.Hash(OnboardingCompletedAt));
        hash.Add(global::Meteroid.Equality.Hash(OnboardingMode));
        hash.Add(global::Meteroid.Equality.Hash(PendingCountry));
        hash.Add(global::Meteroid.Equality.Hash(PendingEmail));
        hash.Add(global::Meteroid.Equality.Hash(PendingOrganizationName));
        hash.Add(global::Meteroid.Equality.Hash(PlatformCustomerId));
        hash.Add(global::Meteroid.Equality.Hash(PlatformOrganizationId));
        hash.Add(global::Meteroid.Equality.Hash(RevokedAt));
        hash.Add(global::Meteroid.Equality.Hash(Status));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
