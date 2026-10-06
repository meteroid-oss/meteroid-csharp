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
/// Token introspection response as per RFC 7662
/// </summary>
public sealed partial record TokenIntrospectionResponse
{
    /// <summary>The <c>active</c> property.</summary>
    [JsonPropertyName("active")]
    public required bool Active { get; init; }

    /// <summary>The <c>client_id</c> property.</summary>
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>The <c>exp</c> property.</summary>
    [JsonPropertyName("exp")]
    public long? Exp { get; init; }

    /// <summary>The <c>iat</c> property.</summary>
    [JsonPropertyName("iat")]
    public long? Iat { get; init; }

    /// <summary>The <c>scope</c> property.</summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; init; }

    /// <summary>The <c>sub</c> property.</summary>
    [JsonPropertyName("sub")]
    public string? Sub { get; init; }

    /// <summary>The <c>token_type</c> property.</summary>
    [JsonPropertyName("token_type")]
    public string? TokenType { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(TokenIntrospectionResponse? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Active, other.Active)
        && global::Meteroid.Equality.Equal(ClientId, other.ClientId)
        && global::Meteroid.Equality.Equal(Exp, other.Exp)
        && global::Meteroid.Equality.Equal(Iat, other.Iat)
        && global::Meteroid.Equality.Equal(Scope, other.Scope)
        && global::Meteroid.Equality.Equal(Sub, other.Sub)
        && global::Meteroid.Equality.Equal(TokenType, other.TokenType)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Active));
        hash.Add(global::Meteroid.Equality.Hash(ClientId));
        hash.Add(global::Meteroid.Equality.Hash(Exp));
        hash.Add(global::Meteroid.Equality.Hash(Iat));
        hash.Add(global::Meteroid.Equality.Hash(Scope));
        hash.Add(global::Meteroid.Equality.Hash(Sub));
        hash.Add(global::Meteroid.Equality.Hash(TokenType));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
