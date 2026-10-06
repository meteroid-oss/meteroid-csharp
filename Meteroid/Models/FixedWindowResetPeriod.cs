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
/// Resets at regular intervals — anchored to your subscription's exact activation time.
/// </summary>
public sealed partial record FixedWindowResetPeriod
{
    /// <summary>The <c>interval</c> property.</summary>
    [JsonPropertyName("interval")]
    public required int Interval { get; init; }

    /// <summary>The <c>unit</c> property.</summary>
    [JsonPropertyName("unit")]
    public required CalendarUnit Unit { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(FixedWindowResetPeriod? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Interval, other.Interval)
        && global::Meteroid.Equality.Equal(Unit, other.Unit)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Interval));
        hash.Add(global::Meteroid.Equality.Hash(Unit));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
