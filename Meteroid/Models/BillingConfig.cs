// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>BillingConfig</c> object.</summary>
public sealed partial record BillingConfig
{
    /// <summary>The <c>billing_cycles</c> property.</summary>
    [JsonPropertyName("billing_cycles")]
    public int? BillingCycles { get; init; }

    /// <summary>The <c>net_terms</c> property.</summary>
    [JsonPropertyName("net_terms")]
    public int? NetTerms { get; init; }

    /// <summary>The <c>period_start_day</c> property.</summary>
    [JsonPropertyName("period_start_day")]
    public int? PeriodStartDay { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(BillingConfig? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(BillingCycles, other.BillingCycles)
        && global::Meteroid.Equality.Equal(NetTerms, other.NetTerms)
        && global::Meteroid.Equality.Equal(PeriodStartDay, other.PeriodStartDay)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(BillingCycles));
        hash.Add(global::Meteroid.Equality.Hash(NetTerms));
        hash.Add(global::Meteroid.Equality.Hash(PeriodStartDay));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
