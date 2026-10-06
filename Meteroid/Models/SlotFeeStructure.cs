// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>SlotFeeStructure</c> object.</summary>
public sealed partial record SlotFeeStructure
{
    /// <summary>The <c>downgrade_policy</c> property.</summary>
    [JsonPropertyName("downgrade_policy")]
    public required SlotDowngradePolicyEnum DowngradePolicy { get; init; }

    /// <summary>The <c>slot_unit_name</c> property.</summary>
    [JsonPropertyName("slot_unit_name")]
    public required string SlotUnitName { get; init; }

    /// <summary>The <c>upgrade_policy</c> property.</summary>
    [JsonPropertyName("upgrade_policy")]
    public required SlotUpgradePolicyEnum UpgradePolicy { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(SlotFeeStructure? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(DowngradePolicy, other.DowngradePolicy)
        && global::Meteroid.Equality.Equal(SlotUnitName, other.SlotUnitName)
        && global::Meteroid.Equality.Equal(UpgradePolicy, other.UpgradePolicy)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(DowngradePolicy));
        hash.Add(global::Meteroid.Equality.Hash(SlotUnitName));
        hash.Add(global::Meteroid.Equality.Hash(UpgradePolicy));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
