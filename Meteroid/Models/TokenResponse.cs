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
/// Token response as per OAuth 2.0 spec
/// </summary>
public sealed partial record TokenResponse
{
    /// <summary>The <c>access_token</c> property.</summary>
    [JsonPropertyName("access_token")]
    public required string AccessToken { get; init; }

    /// <summary>The <c>expires_in</c> property.</summary>
    [JsonPropertyName("expires_in")]
    public required long ExpiresIn { get; init; }

    /// <summary>The <c>refresh_token</c> property.</summary>
    [JsonPropertyName("refresh_token")]
    public string? RefreshToken { get; init; }

    /// <summary>The <c>scope</c> property.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; init; }

    /// <summary>The <c>token_type</c> property.</summary>
    [JsonPropertyName("token_type")]
    public required string TokenType { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(TokenResponse? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(AccessToken, other.AccessToken)
        && global::Meteroid.Equality.Equal(ExpiresIn, other.ExpiresIn)
        && global::Meteroid.Equality.Equal(RefreshToken, other.RefreshToken)
        && global::Meteroid.Equality.Equal(Scope, other.Scope)
        && global::Meteroid.Equality.Equal(TokenType, other.TokenType)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(AccessToken));
        hash.Add(global::Meteroid.Equality.Hash(ExpiresIn));
        hash.Add(global::Meteroid.Equality.Hash(RefreshToken));
        hash.Add(global::Meteroid.Equality.Hash(Scope));
        hash.Add(global::Meteroid.Equality.Hash(TokenType));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
