// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>InvoiceLineUsageBreakdownItem</c> object.</summary>
public sealed partial record InvoiceLineUsageBreakdownItem
{
    /// <summary>
    /// Its part of the line's amount before discounts and tax, in minor units.
    /// </summary>
    [JsonPropertyName("amount_subtotal")]
    public required long AmountSubtotal { get; init; }

    /// <summary>
    /// Its part of <c>credit_unit.consumed</c>, on a line priced in a credit unit.
    /// </summary>
    [JsonPropertyName("credits_consumed")]
    public long? CreditsConsumed { get; init; }

    /// <summary>
    /// Set on the last item when there are more than 99 values: it sums the rest.
    /// </summary>
    [JsonPropertyName("others")]
    public bool? Others { get; init; }

    /// <summary>
    /// Usage of this value, in the units the line is priced in.
    /// </summary>
    [JsonPropertyName("quantity")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public required decimal Quantity { get; init; }

    /// <summary>
    /// Its part of the tax-included amount quoted, on a line billed from tax-inclusive prices.
    /// </summary>
    [JsonPropertyName("quoted_amount_subtotal")]
    public long? QuotedAmountSubtotal { get; init; }

    /// <summary>
    /// The property's value; absent for events without it, and for <c>others</c>.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(InvoiceLineUsageBreakdownItem? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(AmountSubtotal, other.AmountSubtotal)
        && global::Meteroid.Equality.Equal(CreditsConsumed, other.CreditsConsumed)
        && global::Meteroid.Equality.Equal(Others, other.Others)
        && global::Meteroid.Equality.Equal(Quantity, other.Quantity)
        && global::Meteroid.Equality.Equal(QuotedAmountSubtotal, other.QuotedAmountSubtotal)
        && global::Meteroid.Equality.Equal(Value, other.Value)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(AmountSubtotal));
        hash.Add(global::Meteroid.Equality.Hash(CreditsConsumed));
        hash.Add(global::Meteroid.Equality.Hash(Others));
        hash.Add(global::Meteroid.Equality.Hash(Quantity));
        hash.Add(global::Meteroid.Equality.Hash(QuotedAmountSubtotal));
        hash.Add(global::Meteroid.Equality.Hash(Value));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
