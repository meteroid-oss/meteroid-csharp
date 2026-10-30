// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>IssueLicenseRequest</c> object.</summary>
public sealed partial record IssueLicenseRequest
{
    /// <summary>
    /// Customer ID or alias
    /// </summary>
    [JsonPropertyName("customer_id")]
    public required string CustomerId { get; init; }

    /// <summary>
    /// Offline only. The installation's id as it reports it, up to 255 characters without
    /// spaces: the license names it (<c>aud</c>) and stays bound to it. Without one, the license is
    /// not tied to an installation.
    /// </summary>
    [JsonPropertyName("instance_id")]
    public string? InstanceId { get; init; }

    /// <summary>
    /// Delivers the license at once as a signed offline license, for an installation that
    /// can't reach the license server: no activation code, no refresh. Default: false.
    /// </summary>
    [JsonPropertyName("offline")]
    public bool? Offline { get; init; }

    /// <summary>
    /// Ties the license to this subscription of the customer: it is renewed while the
    /// subscription is paid, and carries its plan's entitlements.
    /// </summary>
    [JsonPropertyName("subscription_id")]
    public string? SubscriptionId { get; init; }

    /// <summary>
    /// Online: lifetime of each license token the installation refreshes, 1 to 31 days.
    /// Default: 7. Offline: lifetime of the signed license, 1 to 400 days. Default: 365.
    /// </summary>
    [JsonPropertyName("validity_days")]
    public int? ValidityDays { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(IssueLicenseRequest? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(CustomerId, other.CustomerId)
        && global::Meteroid.Equality.Equal(InstanceId, other.InstanceId)
        && global::Meteroid.Equality.Equal(Offline, other.Offline)
        && global::Meteroid.Equality.Equal(SubscriptionId, other.SubscriptionId)
        && global::Meteroid.Equality.Equal(ValidityDays, other.ValidityDays)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(CustomerId));
        hash.Add(global::Meteroid.Equality.Hash(InstanceId));
        hash.Add(global::Meteroid.Equality.Hash(Offline));
        hash.Add(global::Meteroid.Equality.Hash(SubscriptionId));
        hash.Add(global::Meteroid.Equality.Hash(ValidityDays));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
