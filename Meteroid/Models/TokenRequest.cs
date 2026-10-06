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
/// Token request (from POST body, application/x-www-form-urlencoded)
/// </summary>
public sealed partial record TokenRequest
{
    /// <summary>
    /// Client ID (if not using HTTP Basic auth)
    /// </summary>
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }

    /// <summary>
    /// Client secret (if not using HTTP Basic auth)
    /// </summary>
    [JsonPropertyName("client_secret")]
    public string? ClientSecret { get; init; }

    /// <summary>
    /// Authorization code (for authorization_code grant)
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; init; }

    /// <summary>
    /// PKCE code verifier (for authorization_code grant with PKCE)
    /// </summary>
    [JsonPropertyName("code_verifier")]
    public string? CodeVerifier { get; init; }

    /// <summary>
    /// Grant type: "authorization_code" or "refresh_token"
    /// </summary>
    [JsonPropertyName("grant_type")]
    public required string GrantType { get; init; }

    /// <summary>
    /// Redirect URI (for authorization_code grant, must match the one used in /authorize)
    /// </summary>
    [JsonPropertyName("redirect_uri")]
    public string? RedirectUri { get; init; }

    /// <summary>
    /// Refresh token (for refresh_token grant)
    /// </summary>
    [JsonPropertyName("refresh_token")]
    public string? RefreshToken { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(TokenRequest? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(ClientId, other.ClientId)
        && global::Meteroid.Equality.Equal(ClientSecret, other.ClientSecret)
        && global::Meteroid.Equality.Equal(Code, other.Code)
        && global::Meteroid.Equality.Equal(CodeVerifier, other.CodeVerifier)
        && global::Meteroid.Equality.Equal(GrantType, other.GrantType)
        && global::Meteroid.Equality.Equal(RedirectUri, other.RedirectUri)
        && global::Meteroid.Equality.Equal(RefreshToken, other.RefreshToken)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(ClientId));
        hash.Add(global::Meteroid.Equality.Hash(ClientSecret));
        hash.Add(global::Meteroid.Equality.Hash(Code));
        hash.Add(global::Meteroid.Equality.Hash(CodeVerifier));
        hash.Add(global::Meteroid.Equality.Hash(GrantType));
        hash.Add(global::Meteroid.Equality.Hash(RedirectUri));
        hash.Add(global::Meteroid.Equality.Hash(RefreshToken));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
