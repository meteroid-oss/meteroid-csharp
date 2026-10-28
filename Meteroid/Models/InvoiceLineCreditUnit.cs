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
/// How a usage line priced in a credit unit was paid: the credits it consumed, those the
/// customer's balance in the unit covered, and the rate the rest was billed at.
/// </summary>
public sealed partial record InvoiceLineCreditUnit
{
    /// <summary>
    /// The credit unit's code, e.g. <c>CREDITS</c>.
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; init; }

    /// <summary>
    /// Credits the usage priced.
    /// </summary>
    [JsonPropertyName("consumed")]
    public required long Consumed { get; init; }

    /// <summary>
    /// Of which paid by the customer's credit wallet.
    /// </summary>
    [JsonPropertyName("covered")]
    public required long Covered { get; init; }

    /// <summary>
    /// Credit amounts are integers in 10^-precision credit.
    /// </summary>
    [JsonPropertyName("precision")]
    public required int Precision { get; init; }

    /// <summary>
    /// Invoice-currency major units per credit.
    /// </summary>
    [JsonPropertyName("rate")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public required decimal Rate { get; init; }

    /// <summary>
    /// Credits per usage unit.
    /// </summary>
    [JsonPropertyName("unit_price")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public decimal? UnitPrice { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(InvoiceLineCreditUnit? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Code, other.Code)
        && global::Meteroid.Equality.Equal(Consumed, other.Consumed)
        && global::Meteroid.Equality.Equal(Covered, other.Covered)
        && global::Meteroid.Equality.Equal(Precision, other.Precision)
        && global::Meteroid.Equality.Equal(Rate, other.Rate)
        && global::Meteroid.Equality.Equal(UnitPrice, other.UnitPrice)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Code));
        hash.Add(global::Meteroid.Equality.Hash(Consumed));
        hash.Add(global::Meteroid.Equality.Hash(Covered));
        hash.Add(global::Meteroid.Equality.Hash(Precision));
        hash.Add(global::Meteroid.Equality.Hash(Rate));
        hash.Add(global::Meteroid.Equality.Hash(UnitPrice));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
