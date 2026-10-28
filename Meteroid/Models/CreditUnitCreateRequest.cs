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
/// A new credit unit.
/// </summary>
public sealed partial record CreditUnitCreateRequest
{
    /// <summary>
    /// Immutable once created: 4 to 16 characters, A-Z/0-9/_, starting with a letter. Never an
    /// ISO currency code (those are always 3 letters).
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; init; }

    /// <summary>
    /// Singular display name, 1 to 64 characters, e.g. "Credit".
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Plural display name, 1 to 64 characters, e.g. "Credits".
    /// </summary>
    [JsonPropertyName("plural_name")]
    public required string PluralName { get; init; }

    /// <summary>
    /// Immutable once created: 0 to 6.
    /// </summary>
    [JsonPropertyName("precision")]
    public required int Precision { get; init; }

    /// <summary>
    /// Short display symbol, at most 8 characters.
    /// </summary>
    [JsonPropertyName("symbol")]
    public string? Symbol { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(CreditUnitCreateRequest? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Code, other.Code)
        && global::Meteroid.Equality.Equal(Name, other.Name)
        && global::Meteroid.Equality.Equal(PluralName, other.PluralName)
        && global::Meteroid.Equality.Equal(Precision, other.Precision)
        && global::Meteroid.Equality.Equal(Symbol, other.Symbol)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Code));
        hash.Add(global::Meteroid.Equality.Hash(Name));
        hash.Add(global::Meteroid.Equality.Hash(PluralName));
        hash.Add(global::Meteroid.Equality.Hash(Precision));
        hash.Add(global::Meteroid.Equality.Hash(Symbol));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
