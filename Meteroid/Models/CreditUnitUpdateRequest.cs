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
/// Partial update: an absent field is left unchanged. <c>code</c> and <c>precision</c> have no field here,
/// they are immutable. <c>symbol</c> set to <c>null</c> clears it.
/// </summary>
public sealed partial record CreditUnitUpdateRequest
{
    /// <summary>
    /// Blocks the unit from new prices, packs and grants; existing ones keep working.
    /// </summary>
    [JsonPropertyName("archived")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<bool?>))]
    public MaybeUnset<bool?> Archived { get; init; }

    /// <summary>
    /// Singular display name, 1 to 64 characters.
    /// </summary>
    [JsonPropertyName("name")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<string?>))]
    public MaybeUnset<string?> Name { get; init; }

    /// <summary>
    /// Plural display name, 1 to 64 characters.
    /// </summary>
    [JsonPropertyName("plural_name")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<string?>))]
    public MaybeUnset<string?> PluralName { get; init; }

    /// <summary>
    /// The product sales of the unit are booked under; <c>null</c> clears it, which stops the unit
    /// from being sold.
    /// </summary>
    [JsonPropertyName("product_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<string?>))]
    public MaybeUnset<string?> ProductId { get; init; }

    /// <summary>
    /// Validated by the store (trimmed, at most 8 characters) rather than here: <c>validator</c> has
    /// no built-in support for a double <c>Option</c>.
    /// </summary>
    [JsonPropertyName("symbol")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<string?>))]
    public MaybeUnset<string?> Symbol { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(CreditUnitUpdateRequest? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Archived, other.Archived)
        && global::Meteroid.Equality.Equal(Name, other.Name)
        && global::Meteroid.Equality.Equal(PluralName, other.PluralName)
        && global::Meteroid.Equality.Equal(ProductId, other.ProductId)
        && global::Meteroid.Equality.Equal(Symbol, other.Symbol)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Archived));
        hash.Add(global::Meteroid.Equality.Hash(Name));
        hash.Add(global::Meteroid.Equality.Hash(PluralName));
        hash.Add(global::Meteroid.Equality.Hash(ProductId));
        hash.Add(global::Meteroid.Equality.Hash(Symbol));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
