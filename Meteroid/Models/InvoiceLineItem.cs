// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>InvoiceLineItem</c> object.</summary>
public sealed partial record InvoiceLineItem
{
    /// <summary>The <c>amount_total</c> property.</summary>
    [JsonPropertyName("amount_total")]
    public required long AmountTotal { get; init; }

    /// <summary>The <c>description</c> property.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>The <c>end_date</c> property.</summary>
    [JsonPropertyName("end_date")]
    public required DateOnly EndDate { get; init; }

    /// <summary>The <c>name</c> property.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>The <c>quantity</c> property.</summary>
    [JsonPropertyName("quantity")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public decimal? Quantity { get; init; }

    /// <summary>
    /// The tax-included unit price the customer was quoted, on a line billed from
    /// tax-inclusive prices. <c>unit_price</c> is its net counterpart.
    /// </summary>
    [JsonPropertyName("quoted_unit_price")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public decimal? QuotedUnitPrice { get; init; }

    /// <summary>The <c>start_date</c> property.</summary>
    [JsonPropertyName("start_date")]
    public required DateOnly StartDate { get; init; }

    /// <summary>The <c>sub_line_items</c> property.</summary>
    [JsonPropertyName("sub_line_items")]
    public required IReadOnlyList<SubLineItem> SubLineItems { get; init; }

    /// <summary>The <c>tax_rate</c> property.</summary>
    [JsonPropertyName("tax_rate")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public required decimal TaxRate { get; init; }

    /// <summary>The <c>unit_price</c> property.</summary>
    [JsonPropertyName("unit_price")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public decimal? UnitPrice { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(InvoiceLineItem? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(AmountTotal, other.AmountTotal)
        && global::Meteroid.Equality.Equal(Description, other.Description)
        && global::Meteroid.Equality.Equal(EndDate, other.EndDate)
        && global::Meteroid.Equality.Equal(Name, other.Name)
        && global::Meteroid.Equality.Equal(Quantity, other.Quantity)
        && global::Meteroid.Equality.Equal(QuotedUnitPrice, other.QuotedUnitPrice)
        && global::Meteroid.Equality.Equal(StartDate, other.StartDate)
        && global::Meteroid.Equality.Equal(SubLineItems, other.SubLineItems)
        && global::Meteroid.Equality.Equal(TaxRate, other.TaxRate)
        && global::Meteroid.Equality.Equal(UnitPrice, other.UnitPrice)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(AmountTotal));
        hash.Add(global::Meteroid.Equality.Hash(Description));
        hash.Add(global::Meteroid.Equality.Hash(EndDate));
        hash.Add(global::Meteroid.Equality.Hash(Name));
        hash.Add(global::Meteroid.Equality.Hash(Quantity));
        hash.Add(global::Meteroid.Equality.Hash(QuotedUnitPrice));
        hash.Add(global::Meteroid.Equality.Hash(StartDate));
        hash.Add(global::Meteroid.Equality.Hash(SubLineItems));
        hash.Add(global::Meteroid.Equality.Hash(TaxRate));
        hash.Add(global::Meteroid.Equality.Hash(UnitPrice));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
