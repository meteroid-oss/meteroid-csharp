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
/// A credit pack: charged like a fixed fee, it grants <c>credit_amount</c> × <c>quantity</c> of credit once
/// paid, in the subscription currency or in <c>credit_unit</c>. A zero <c>unit_price</c> makes it credit
/// included with the plan (promotional). A currency pack priced below its credit grants the price
/// paid as paid credit and the difference as promotional bonus credit, which applies before tax.
/// </summary>
public sealed partial record CreditFee
{
    /// <summary>
    /// Credit granted per pack, in major units of the subscription currency, or a number of
    /// credits of <c>credit_unit</c> when set.
    /// </summary>
    [JsonPropertyName("credit_amount")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public required decimal CreditAmount { get; init; }

    /// <summary>The <c>credit_unit</c> property.</summary>
    [JsonPropertyName("credit_unit")]
    public CreditPackUnit? CreditUnit { get; init; }

    /// <summary>The <c>expiry</c> property.</summary>
    [JsonPropertyName("expiry")]
    public CreditPackExpiry? Expiry { get; init; }

    /// <summary>
    /// When true, billed and granted once, on the subscription's first invoice, instead of every
    /// period.
    /// </summary>
    [JsonPropertyName("once")]
    public bool? Once { get; init; }

    /// <summary>
    /// Packs billed and granted each time.
    /// </summary>
    [JsonPropertyName("quantity")]
    public required int Quantity { get; init; }

    /// <summary>The <c>rollover</c> property.</summary>
    [JsonPropertyName("rollover")]
    public CreditPackRollover? Rollover { get; init; }

    /// <summary>The <c>type</c> property.</summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "CREDIT";

    /// <summary>
    /// Price of one pack, in major units of the subscription currency.
    /// </summary>
    [JsonPropertyName("unit_price")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public required decimal UnitPrice { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(CreditFee? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(CreditAmount, other.CreditAmount)
        && global::Meteroid.Equality.Equal(CreditUnit, other.CreditUnit)
        && global::Meteroid.Equality.Equal(Expiry, other.Expiry)
        && global::Meteroid.Equality.Equal(Once, other.Once)
        && global::Meteroid.Equality.Equal(Quantity, other.Quantity)
        && global::Meteroid.Equality.Equal(Rollover, other.Rollover)
        && global::Meteroid.Equality.Equal(Type, other.Type)
        && global::Meteroid.Equality.Equal(UnitPrice, other.UnitPrice)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(CreditAmount));
        hash.Add(global::Meteroid.Equality.Hash(CreditUnit));
        hash.Add(global::Meteroid.Equality.Hash(Expiry));
        hash.Add(global::Meteroid.Equality.Hash(Once));
        hash.Add(global::Meteroid.Equality.Hash(Quantity));
        hash.Add(global::Meteroid.Equality.Hash(Rollover));
        hash.Add(global::Meteroid.Equality.Hash(Type));
        hash.Add(global::Meteroid.Equality.Hash(UnitPrice));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
