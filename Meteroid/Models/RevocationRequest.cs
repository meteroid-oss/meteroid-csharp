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
/// Token revocation request
/// </summary>
public sealed partial record RevocationRequest
{
    /// <summary>
    /// The token to revoke
    /// </summary>
    [JsonPropertyName("token")]
    public required string Token { get; init; }

    /// <summary>
    /// Optional hint about the token type (access_token or refresh_token)
    /// </summary>
    [JsonPropertyName("token_type_hint")]
    public string? TokenTypeHint { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(RevocationRequest? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Token, other.Token)
        && global::Meteroid.Equality.Equal(TokenTypeHint, other.TokenTypeHint)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Token));
        hash.Add(global::Meteroid.Equality.Hash(TokenTypeHint));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
