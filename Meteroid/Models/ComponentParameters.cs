// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>ComponentParameters</c> object.</summary>
public sealed partial record ComponentParameters
{
    /// <summary>The <c>billing_period</c> property.</summary>
    [JsonPropertyName("billing_period")]
    public BillingPeriodEnum? BillingPeriod { get; init; }

    /// <summary>The <c>committed_capacity</c> property.</summary>
    [JsonPropertyName("committed_capacity")]
    public long? CommittedCapacity { get; init; }

    /// <summary>The <c>initial_slot_count</c> property.</summary>
    [JsonPropertyName("initial_slot_count")]
    public int? InitialSlotCount { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(ComponentParameters? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(BillingPeriod, other.BillingPeriod)
        && global::Meteroid.Equality.Equal(CommittedCapacity, other.CommittedCapacity)
        && global::Meteroid.Equality.Equal(InitialSlotCount, other.InitialSlotCount)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(BillingPeriod));
        hash.Add(global::Meteroid.Equality.Hash(CommittedCapacity));
        hash.Add(global::Meteroid.Equality.Hash(InitialSlotCount));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
