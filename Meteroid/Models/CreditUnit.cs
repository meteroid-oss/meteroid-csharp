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
/// A tenant-defined denomination usage can be priced or credit granted in, instead of money.
/// <c>code</c> and <c>precision</c> are immutable once created.
/// </summary>
public sealed partial record CreditUnit
{
    /// <summary>
    /// Archived units take no new prices, packs or grants; existing ones keep working.
    /// </summary>
    [JsonPropertyName("archived")]
    public required bool Archived { get; init; }

    /// <summary>
    /// Upper-case code naming the unit in wallets, grants and webhooks, e.g. <c>CREDITS</c>.
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; init; }

    /// <summary>
    /// The unit's id (<c>cun_…</c>).
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Singular display name, e.g. "Credit".
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Plural display name, e.g. "Credits".
    /// </summary>
    [JsonPropertyName("plural_name")]
    public required string PluralName { get; init; }

    /// <summary>
    /// Minor-unit exponent: amounts of this unit are integers of 10^-precision credit.
    /// </summary>
    [JsonPropertyName("precision")]
    public required int Precision { get; init; }

    /// <summary>
    /// The active selling prices, one per currency.
    /// </summary>
    [JsonPropertyName("prices")]
    public required IReadOnlyList<CreditUnitPrice> Prices { get; init; }

    /// <summary>
    /// The product sales of this unit are booked under: their tax category and accounting code.
    /// The unit can be sold (top-ups) only once it is set.
    /// </summary>
    [JsonPropertyName("product_id")]
    public string? ProductId { get; init; }

    /// <summary>
    /// Short display symbol, e.g. "cr".
    /// </summary>
    [JsonPropertyName("symbol")]
    public string? Symbol { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(CreditUnit? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Archived, other.Archived)
        && global::Meteroid.Equality.Equal(Code, other.Code)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(Name, other.Name)
        && global::Meteroid.Equality.Equal(PluralName, other.PluralName)
        && global::Meteroid.Equality.Equal(Precision, other.Precision)
        && global::Meteroid.Equality.Equal(Prices, other.Prices)
        && global::Meteroid.Equality.Equal(ProductId, other.ProductId)
        && global::Meteroid.Equality.Equal(Symbol, other.Symbol)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Archived));
        hash.Add(global::Meteroid.Equality.Hash(Code));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(Name));
        hash.Add(global::Meteroid.Equality.Hash(PluralName));
        hash.Add(global::Meteroid.Equality.Hash(Precision));
        hash.Add(global::Meteroid.Equality.Hash(Prices));
        hash.Add(global::Meteroid.Equality.Hash(ProductId));
        hash.Add(global::Meteroid.Equality.Hash(Symbol));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
