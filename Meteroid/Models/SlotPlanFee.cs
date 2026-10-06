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
/// Slot-based fee (e.g., per-seat pricing)
/// </summary>
public sealed partial record SlotPlanFee
{
    /// <summary>The <c>minimum_count</c> property.</summary>
    [JsonPropertyName("minimum_count")]
    public int? MinimumCount { get; init; }

    /// <summary>The <c>quota</c> property.</summary>
    [JsonPropertyName("quota")]
    public int? Quota { get; init; }

    /// <summary>The <c>rates</c> property.</summary>
    [JsonPropertyName("rates")]
    public required IReadOnlyList<TermRate> Rates { get; init; }

    /// <summary>The <c>slot_unit_name</c> property.</summary>
    [JsonPropertyName("slot_unit_name")]
    public required string SlotUnitName { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(SlotPlanFee? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(MinimumCount, other.MinimumCount)
        && global::Meteroid.Equality.Equal(Quota, other.Quota)
        && global::Meteroid.Equality.Equal(Rates, other.Rates)
        && global::Meteroid.Equality.Equal(SlotUnitName, other.SlotUnitName)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(MinimumCount));
        hash.Add(global::Meteroid.Equality.Hash(Quota));
        hash.Add(global::Meteroid.Equality.Hash(Rates));
        hash.Add(global::Meteroid.Equality.Hash(SlotUnitName));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
