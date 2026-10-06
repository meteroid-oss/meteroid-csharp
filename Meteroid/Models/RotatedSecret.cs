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
/// Result of rotating a client secret
/// </summary>
public sealed partial record RotatedSecret
{
    /// <summary>The <c>client_secret</c> property.</summary>
    [JsonPropertyName("client_secret")]
    public required string ClientSecret { get; init; }

    /// <summary>The <c>client_secret_hint</c> property.</summary>
    [JsonPropertyName("client_secret_hint")]
    public required string ClientSecretHint { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(RotatedSecret? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(ClientSecret, other.ClientSecret)
        && global::Meteroid.Equality.Equal(ClientSecretHint, other.ClientSecretHint)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(ClientSecret));
        hash.Add(global::Meteroid.Equality.Hash(ClientSecretHint));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
