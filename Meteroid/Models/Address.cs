// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>Address</c> object.</summary>
public sealed partial record Address
{
    /// <summary>The <c>city</c> property.</summary>
    [JsonPropertyName("city")]
    public string? City { get; init; }

    /// <summary>The <c>country</c> property.</summary>
    [JsonPropertyName("country")]
    public string? Country { get; init; }

    /// <summary>The <c>line1</c> property.</summary>
    [JsonPropertyName("line1")]
    public string? Line1 { get; init; }

    /// <summary>The <c>line2</c> property.</summary>
    [JsonPropertyName("line2")]
    public string? Line2 { get; init; }

    /// <summary>The <c>state</c> property.</summary>
    [JsonPropertyName("state")]
    public string? State { get; init; }

    /// <summary>The <c>zip_code</c> property.</summary>
    [JsonPropertyName("zip_code")]
    public string? ZipCode { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(Address? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(City, other.City)
        && global::Meteroid.Equality.Equal(Country, other.Country)
        && global::Meteroid.Equality.Equal(Line1, other.Line1)
        && global::Meteroid.Equality.Equal(Line2, other.Line2)
        && global::Meteroid.Equality.Equal(State, other.State)
        && global::Meteroid.Equality.Equal(ZipCode, other.ZipCode)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(City));
        hash.Add(global::Meteroid.Equality.Hash(Country));
        hash.Add(global::Meteroid.Equality.Hash(Line1));
        hash.Add(global::Meteroid.Equality.Hash(Line2));
        hash.Add(global::Meteroid.Equality.Hash(State));
        hash.Add(global::Meteroid.Equality.Hash(ZipCode));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
