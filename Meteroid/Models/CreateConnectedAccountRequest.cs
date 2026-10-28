// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>CreateConnectedAccountRequest</c> object.</summary>
public sealed partial record CreateConnectedAccountRequest
{
    /// <summary>The <c>country</c> property.</summary>
    [JsonPropertyName("country")]
    public string? Country { get; init; }

    /// <summary>The <c>email</c> property.</summary>
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    /// <summary>The <c>metadata</c> property.</summary>
    [JsonPropertyName("metadata")]
    public JsonNode? Metadata { get; init; }

    /// <summary>The <c>mode</c> property.</summary>
    [JsonPropertyName("mode")]
    public OnboardingMode? Mode { get; init; }

    /// <summary>The <c>organization_name</c> property.</summary>
    [JsonPropertyName("organization_name")]
    public required string OrganizationName { get; init; }

    /// <summary>The <c>redirect_url</c> property.</summary>
    [JsonPropertyName("redirect_url")]
    public string? RedirectUrl { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(CreateConnectedAccountRequest? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Country, other.Country)
        && global::Meteroid.Equality.Equal(Email, other.Email)
        && global::Meteroid.Equality.Equal(Metadata, other.Metadata)
        && global::Meteroid.Equality.Equal(Mode, other.Mode)
        && global::Meteroid.Equality.Equal(OrganizationName, other.OrganizationName)
        && global::Meteroid.Equality.Equal(RedirectUrl, other.RedirectUrl)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Country));
        hash.Add(global::Meteroid.Equality.Hash(Email));
        hash.Add(global::Meteroid.Equality.Hash(Metadata));
        hash.Add(global::Meteroid.Equality.Hash(Mode));
        hash.Add(global::Meteroid.Equality.Hash(OrganizationName));
        hash.Add(global::Meteroid.Equality.Hash(RedirectUrl));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
