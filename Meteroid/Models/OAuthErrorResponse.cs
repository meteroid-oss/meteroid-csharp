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
/// OAuth 2.0 error response as per RFC 6749 Section 5.2
/// </summary>
public sealed partial record OAuthErrorResponse
{
    /// <summary>The <c>error</c> property.</summary>
    [JsonPropertyName("error")]
    public required OAuthErrorCode Error { get; init; }

    /// <summary>The <c>error_description</c> property.</summary>
    [JsonPropertyName("error_description")]
    public string? ErrorDescription { get; init; }

    /// <summary>The <c>error_uri</c> property.</summary>
    [JsonPropertyName("error_uri")]
    public string? ErrorUri { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(OAuthErrorResponse? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Error, other.Error)
        && global::Meteroid.Equality.Equal(ErrorDescription, other.ErrorDescription)
        && global::Meteroid.Equality.Equal(ErrorUri, other.ErrorUri)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Error));
        hash.Add(global::Meteroid.Equality.Hash(ErrorDescription));
        hash.Add(global::Meteroid.Equality.Hash(ErrorUri));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
