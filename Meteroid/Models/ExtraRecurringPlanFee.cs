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
/// Extra recurring fee
/// </summary>
public sealed partial record ExtraRecurringPlanFee
{
    /// <summary>The <c>billing_type</c> property.</summary>
    [JsonPropertyName("billing_type")]
    public required BillingType BillingType { get; init; }

    /// <summary>The <c>cadence</c> property.</summary>
    [JsonPropertyName("cadence")]
    public required BillingPeriodEnum Cadence { get; init; }

    /// <summary>The <c>quantity</c> property.</summary>
    [JsonPropertyName("quantity")]
    public required int Quantity { get; init; }

    /// <summary>The <c>unit_price</c> property.</summary>
    [JsonPropertyName("unit_price")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public required decimal UnitPrice { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(ExtraRecurringPlanFee? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(BillingType, other.BillingType)
        && global::Meteroid.Equality.Equal(Cadence, other.Cadence)
        && global::Meteroid.Equality.Equal(Quantity, other.Quantity)
        && global::Meteroid.Equality.Equal(UnitPrice, other.UnitPrice)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(BillingType));
        hash.Add(global::Meteroid.Equality.Hash(Cadence));
        hash.Add(global::Meteroid.Equality.Hash(Quantity));
        hash.Add(global::Meteroid.Equality.Hash(UnitPrice));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
