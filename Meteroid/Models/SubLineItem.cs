// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>SubLineItem</c> object.</summary>
public sealed partial record SubLineItem
{
    /// <summary>The <c>id</c> property.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>The <c>name</c> property.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>The <c>quantity</c> property.</summary>
    [JsonPropertyName("quantity")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public required decimal Quantity { get; init; }

    /// <summary>The <c>total</c> property.</summary>
    [JsonPropertyName("total")]
    public required long Total { get; init; }

    /// <summary>The <c>unit_price</c> property.</summary>
    [JsonPropertyName("unit_price")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public required decimal UnitPrice { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(SubLineItem? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(Name, other.Name)
        && global::Meteroid.Equality.Equal(Quantity, other.Quantity)
        && global::Meteroid.Equality.Equal(Total, other.Total)
        && global::Meteroid.Equality.Equal(UnitPrice, other.UnitPrice)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(Name));
        hash.Add(global::Meteroid.Equality.Hash(Quantity));
        hash.Add(global::Meteroid.Equality.Hash(Total));
        hash.Add(global::Meteroid.Equality.Hash(UnitPrice));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
