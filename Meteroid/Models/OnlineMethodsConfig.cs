// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>OnlineMethodsConfig</c> object.</summary>
public sealed partial record OnlineMethodsConfig
{
    /// <summary>The <c>card</c> property.</summary>
    [JsonPropertyName("card")]
    public OnlineMethodConfig? Card { get; init; }

    /// <summary>The <c>direct_debit</c> property.</summary>
    [JsonPropertyName("direct_debit")]
    public OnlineMethodConfig? DirectDebit { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(OnlineMethodsConfig? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Card, other.Card)
        && global::Meteroid.Equality.Equal(DirectDebit, other.DirectDebit)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Card));
        hash.Add(global::Meteroid.Equality.Hash(DirectDebit));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
