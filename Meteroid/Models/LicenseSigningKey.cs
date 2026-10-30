// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>LicenseSigningKey</c> object.</summary>
public sealed partial record LicenseSigningKey
{
    /// <summary>The <c>created_at</c> property.</summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// The key id, the <c>kid</c> header of the licenses it signs.
    /// </summary>
    [JsonPropertyName("kid")]
    public required string Kid { get; init; }

    /// <summary>
    /// Ed25519 public key, PEM-encoded.
    /// </summary>
    [JsonPropertyName("public_key_pem")]
    public required string PublicKeyPem { get; init; }

    /// <summary>The <c>retired_at</c> property.</summary>
    [JsonPropertyName("retired_at")]
    public DateTimeOffset? RetiredAt { get; init; }

    /// <summary>The <c>status</c> property.</summary>
    [JsonPropertyName("status")]
    public required LicenseSigningKeyStatus Status { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(LicenseSigningKey? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(CreatedAt, other.CreatedAt)
        && global::Meteroid.Equality.Equal(Kid, other.Kid)
        && global::Meteroid.Equality.Equal(PublicKeyPem, other.PublicKeyPem)
        && global::Meteroid.Equality.Equal(RetiredAt, other.RetiredAt)
        && global::Meteroid.Equality.Equal(Status, other.Status)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(CreatedAt));
        hash.Add(global::Meteroid.Equality.Hash(Kid));
        hash.Add(global::Meteroid.Equality.Hash(PublicKeyPem));
        hash.Add(global::Meteroid.Equality.Hash(RetiredAt));
        hash.Add(global::Meteroid.Equality.Hash(Status));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
