// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>Product</c> object.</summary>
public sealed partial record Product
{
    /// <summary>The <c>archived_at</c> property.</summary>
    [JsonPropertyName("archived_at")]
    public DateTimeOffset? ArchivedAt { get; init; }

    /// <summary>The <c>catalog</c> property.</summary>
    [JsonPropertyName("catalog")]
    public required bool Catalog { get; init; }

    /// <summary>The <c>created_at</c> property.</summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>The <c>description</c> property.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>The <c>fee_structure</c> property.</summary>
    [JsonPropertyName("fee_structure")]
    public required ProductFeeStructure FeeStructure { get; init; }

    /// <summary>The <c>fee_type</c> property.</summary>
    [JsonPropertyName("fee_type")]
    public required ProductFeeTypeEnum FeeType { get; init; }

    /// <summary>The <c>id</c> property.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>The <c>name</c> property.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>The <c>product_family_id</c> property.</summary>
    [JsonPropertyName("product_family_id")]
    public required string ProductFamilyId { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(Product? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(ArchivedAt, other.ArchivedAt)
        && global::Meteroid.Equality.Equal(Catalog, other.Catalog)
        && global::Meteroid.Equality.Equal(CreatedAt, other.CreatedAt)
        && global::Meteroid.Equality.Equal(Description, other.Description)
        && global::Meteroid.Equality.Equal(FeeStructure, other.FeeStructure)
        && global::Meteroid.Equality.Equal(FeeType, other.FeeType)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(Name, other.Name)
        && global::Meteroid.Equality.Equal(ProductFamilyId, other.ProductFamilyId)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(ArchivedAt));
        hash.Add(global::Meteroid.Equality.Hash(Catalog));
        hash.Add(global::Meteroid.Equality.Hash(CreatedAt));
        hash.Add(global::Meteroid.Equality.Hash(Description));
        hash.Add(global::Meteroid.Equality.Hash(FeeStructure));
        hash.Add(global::Meteroid.Equality.Hash(FeeType));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(Name));
        hash.Add(global::Meteroid.Equality.Hash(ProductFamilyId));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
