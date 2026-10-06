// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>CustomerDetails</c> object.</summary>
public sealed partial record CustomerDetails
{
    /// <summary>The <c>alias</c> property.</summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; init; }

    /// <summary>The <c>billing_address</c> property.</summary>
    [JsonPropertyName("billing_address")]
    public Address? BillingAddress { get; init; }

    /// <summary>The <c>email</c> property.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    /// <summary>The <c>id</c> property.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>The <c>name</c> property.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>The <c>snapshot_at</c> property.</summary>
    [JsonPropertyName("snapshot_at")]
    public required DateTimeOffset SnapshotAt { get; init; }

    /// <summary>The <c>vat_number</c> property.</summary>
    [JsonPropertyName("vat_number")]
    public string? VatNumber { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(CustomerDetails? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Alias, other.Alias)
        && global::Meteroid.Equality.Equal(BillingAddress, other.BillingAddress)
        && global::Meteroid.Equality.Equal(Email, other.Email)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(Name, other.Name)
        && global::Meteroid.Equality.Equal(SnapshotAt, other.SnapshotAt)
        && global::Meteroid.Equality.Equal(VatNumber, other.VatNumber)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Alias));
        hash.Add(global::Meteroid.Equality.Hash(BillingAddress));
        hash.Add(global::Meteroid.Equality.Hash(Email));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(Name));
        hash.Add(global::Meteroid.Equality.Hash(SnapshotAt));
        hash.Add(global::Meteroid.Equality.Hash(VatNumber));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
