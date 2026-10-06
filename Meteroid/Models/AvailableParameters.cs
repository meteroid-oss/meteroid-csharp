// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>AvailableParameters</c> object.</summary>
public sealed partial record AvailableParameters
{
    /// <summary>
    /// Map of component_id -&gt; available billing periods (e.g., "MONTHLY", "ANNUAL")
    /// </summary>
    [JsonPropertyName("billing_periods")]
    public IReadOnlyDictionary<string, IReadOnlyList<BillingPeriodEnum>>? BillingPeriods { get; init; }

    /// <summary>
    /// Map of component_id -&gt; available capacity values
    /// </summary>
    [JsonPropertyName("capacity_thresholds")]
    public IReadOnlyDictionary<string, IReadOnlyList<long>>? CapacityThresholds { get; init; }

    /// <summary>
    /// List of component_ids that support slot parametrization (initial slot count)
    /// </summary>
    [JsonPropertyName("slot_components")]
    public IReadOnlyList<string>? SlotComponents { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(AvailableParameters? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(BillingPeriods, other.BillingPeriods)
        && global::Meteroid.Equality.Equal(CapacityThresholds, other.CapacityThresholds)
        && global::Meteroid.Equality.Equal(SlotComponents, other.SlotComponents)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(BillingPeriods));
        hash.Add(global::Meteroid.Equality.Hash(CapacityThresholds));
        hash.Add(global::Meteroid.Equality.Hash(SlotComponents));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
