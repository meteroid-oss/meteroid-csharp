// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>TaxBreakdownItem</c> object.</summary>
public sealed partial record TaxBreakdownItem
{
    /// <summary>
    /// Free-text legal exemption mention (EU exempt/reverse-charge invoices).
    /// </summary>
    [JsonPropertyName("exemption_reason")]
    public string? ExemptionReason { get; init; }

    /// <summary>The <c>exemption_type</c> property.</summary>
    [JsonPropertyName("exemption_type")]
    public TaxExemptionType? ExemptionType { get; init; }

    /// <summary>The <c>name</c> property.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>The <c>tax_amount</c> property.</summary>
    [JsonPropertyName("tax_amount")]
    public required long TaxAmount { get; init; }

    /// <summary>The <c>tax_rate</c> property.</summary>
    [JsonPropertyName("tax_rate")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public required decimal TaxRate { get; init; }

    /// <summary>
    /// Accounting/reporting code of the tax rate for this line, for exports.
    /// </summary>
    [JsonPropertyName("tax_reference")]
    public string? TaxReference { get; init; }

    /// <summary>The <c>taxable_amount</c> property.</summary>
    [JsonPropertyName("taxable_amount")]
    public required long TaxableAmount { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(TaxBreakdownItem? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(ExemptionReason, other.ExemptionReason)
        && global::Meteroid.Equality.Equal(ExemptionType, other.ExemptionType)
        && global::Meteroid.Equality.Equal(Name, other.Name)
        && global::Meteroid.Equality.Equal(TaxAmount, other.TaxAmount)
        && global::Meteroid.Equality.Equal(TaxRate, other.TaxRate)
        && global::Meteroid.Equality.Equal(TaxReference, other.TaxReference)
        && global::Meteroid.Equality.Equal(TaxableAmount, other.TaxableAmount)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(ExemptionReason));
        hash.Add(global::Meteroid.Equality.Hash(ExemptionType));
        hash.Add(global::Meteroid.Equality.Hash(Name));
        hash.Add(global::Meteroid.Equality.Hash(TaxAmount));
        hash.Add(global::Meteroid.Equality.Hash(TaxRate));
        hash.Add(global::Meteroid.Equality.Hash(TaxReference));
        hash.Add(global::Meteroid.Equality.Hash(TaxableAmount));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
