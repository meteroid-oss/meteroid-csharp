// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>IssueLicenseResponse</c> object.</summary>
public sealed partial record IssueLicenseResponse
{
    /// <summary>
    /// Online: one-time code the customer enters in their installation to activate the license.
    /// </summary>
    [JsonPropertyName("activation_code")]
    public string? ActivationCode { get; init; }

    /// <summary>The <c>license</c> property.</summary>
    [JsonPropertyName("license")]
    public required License License { get; init; }

    /// <summary>
    /// Offline: the signed license (a JWT) to install in the installation.
    /// </summary>
    [JsonPropertyName("offline_license")]
    public string? OfflineLicense { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(IssueLicenseResponse? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(ActivationCode, other.ActivationCode)
        && global::Meteroid.Equality.Equal(License, other.License)
        && global::Meteroid.Equality.Equal(OfflineLicense, other.OfflineLicense)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(ActivationCode));
        hash.Add(global::Meteroid.Equality.Hash(License));
        hash.Add(global::Meteroid.Equality.Hash(OfflineLicense));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
