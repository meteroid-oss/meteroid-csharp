// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>ExtraComponent</c> object.</summary>
public sealed partial record ExtraComponent
{
    /// <summary>The <c>name</c> property.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>The <c>price_entry</c> property.</summary>
    [JsonPropertyName("price_entry")]
    public required PriceEntry PriceEntry { get; init; }

    /// <summary>The <c>product_ref</c> property.</summary>
    [JsonPropertyName("product_ref")]
    public required ProductRef ProductRef { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(ExtraComponent? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Name, other.Name)
        && global::Meteroid.Equality.Equal(PriceEntry, other.PriceEntry)
        && global::Meteroid.Equality.Equal(ProductRef, other.ProductRef)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Name));
        hash.Add(global::Meteroid.Equality.Hash(PriceEntry));
        hash.Add(global::Meteroid.Equality.Hash(ProductRef));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
