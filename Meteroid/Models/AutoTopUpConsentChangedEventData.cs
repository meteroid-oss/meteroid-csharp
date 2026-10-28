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
/// The authorization of a wallet's automatic top-up was given, changed or withdrawn.
/// </summary>
public sealed partial record AutoTopUpConsentChangedEventData
{
    /// <summary>
    /// Who gave, changed or withdrew the authorization.
    /// </summary>
    [JsonPropertyName("actor")]
    public required Actor Actor { get; init; }

    /// <summary>
    /// When the authorization changed.
    /// </summary>
    [JsonPropertyName("changed_at")]
    public required DateTimeOffset ChangedAt { get; init; }

    /// <summary>
    /// Identifies the terms authorized now, without disclosing payment details; absent when
    /// withdrawn.
    /// </summary>
    [JsonPropertyName("configuration_revision")]
    public string? ConfigurationRevision { get; init; }

    /// <summary>
    /// When that attestation was made.
    /// </summary>
    [JsonPropertyName("consent_attested_at")]
    public DateTimeOffset? ConsentAttestedAt { get; init; }

    /// <summary>The <c>consent_attested_by</c> property.</summary>
    [JsonPropertyName("consent_attested_by")]
    public Actor? ConsentAttestedBy { get; init; }

    /// <summary>
    /// The wallet's currency (ISO 4217) or credit unit code.
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>The <c>customer_id</c> property.</summary>
    [JsonPropertyName("customer_id")]
    public required string CustomerId { get; init; }

    /// <summary>
    /// Whether automatic top-up is authorized after this change.
    /// </summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; init; }

    /// <summary>
    /// Identifies the terms authorized before the change; absent when none were.
    /// </summary>
    [JsonPropertyName("previous_configuration_revision")]
    public string? PreviousConfigurationRevision { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(AutoTopUpConsentChangedEventData? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Actor, other.Actor)
        && global::Meteroid.Equality.Equal(ChangedAt, other.ChangedAt)
        && global::Meteroid.Equality.Equal(ConfigurationRevision, other.ConfigurationRevision)
        && global::Meteroid.Equality.Equal(ConsentAttestedAt, other.ConsentAttestedAt)
        && global::Meteroid.Equality.Equal(ConsentAttestedBy, other.ConsentAttestedBy)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(CustomerId, other.CustomerId)
        && global::Meteroid.Equality.Equal(Enabled, other.Enabled)
        && global::Meteroid.Equality.Equal(PreviousConfigurationRevision, other.PreviousConfigurationRevision)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Actor));
        hash.Add(global::Meteroid.Equality.Hash(ChangedAt));
        hash.Add(global::Meteroid.Equality.Hash(ConfigurationRevision));
        hash.Add(global::Meteroid.Equality.Hash(ConsentAttestedAt));
        hash.Add(global::Meteroid.Equality.Hash(ConsentAttestedBy));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(CustomerId));
        hash.Add(global::Meteroid.Equality.Hash(Enabled));
        hash.Add(global::Meteroid.Equality.Hash(PreviousConfigurationRevision));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
