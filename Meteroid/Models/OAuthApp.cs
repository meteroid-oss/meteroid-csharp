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
/// An OAuth application registered by a platform
/// </summary>
public sealed partial record OAuthApp
{
    /// <summary>The <c>client_id</c> property.</summary>
    [JsonPropertyName("client_id")]
    public required string ClientId { get; init; }

    /// <summary>The <c>client_secret_hint</c> property.</summary>
    [JsonPropertyName("client_secret_hint")]
    public required string ClientSecretHint { get; init; }

    /// <summary>The <c>created_at</c> property.</summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>The <c>id</c> property.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>The <c>is_active</c> property.</summary>
    [JsonPropertyName("is_active")]
    public required bool IsActive { get; init; }

    /// <summary>The <c>name</c> property.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>The <c>organization_id</c> property.</summary>
    [JsonPropertyName("organization_id")]
    public required string OrganizationId { get; init; }

    /// <summary>The <c>redirect_uris</c> property.</summary>
    [JsonPropertyName("redirect_uris")]
    public required IReadOnlyList<string> RedirectUris { get; init; }

    /// <summary>The <c>scopes</c> property.</summary>
    [JsonPropertyName("scopes")]
    public required IReadOnlyList<string> Scopes { get; init; }

    /// <summary>The <c>updated_at</c> property.</summary>
    [JsonPropertyName("updated_at")]
    public DateTimeOffset? UpdatedAt { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(OAuthApp? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(ClientId, other.ClientId)
        && global::Meteroid.Equality.Equal(ClientSecretHint, other.ClientSecretHint)
        && global::Meteroid.Equality.Equal(CreatedAt, other.CreatedAt)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(IsActive, other.IsActive)
        && global::Meteroid.Equality.Equal(Name, other.Name)
        && global::Meteroid.Equality.Equal(OrganizationId, other.OrganizationId)
        && global::Meteroid.Equality.Equal(RedirectUris, other.RedirectUris)
        && global::Meteroid.Equality.Equal(Scopes, other.Scopes)
        && global::Meteroid.Equality.Equal(UpdatedAt, other.UpdatedAt)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(ClientId));
        hash.Add(global::Meteroid.Equality.Hash(ClientSecretHint));
        hash.Add(global::Meteroid.Equality.Hash(CreatedAt));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(IsActive));
        hash.Add(global::Meteroid.Equality.Hash(Name));
        hash.Add(global::Meteroid.Equality.Hash(OrganizationId));
        hash.Add(global::Meteroid.Equality.Hash(RedirectUris));
        hash.Add(global::Meteroid.Equality.Hash(Scopes));
        hash.Add(global::Meteroid.Equality.Hash(UpdatedAt));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
