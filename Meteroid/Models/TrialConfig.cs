// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>TrialConfig</c> object.</summary>
public sealed partial record TrialConfig
{
    /// <summary>The <c>duration_days</c> property.</summary>
    [JsonPropertyName("duration_days")]
    public required int DurationDays { get; init; }

    /// <summary>The <c>is_free</c> property.</summary>
    [JsonPropertyName("is_free")]
    public required bool IsFree { get; init; }

    /// <summary>The <c>trialing_plan_id</c> property.</summary>
    [JsonPropertyName("trialing_plan_id")]
    public string? TrialingPlanId { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(TrialConfig? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(DurationDays, other.DurationDays)
        && global::Meteroid.Equality.Equal(IsFree, other.IsFree)
        && global::Meteroid.Equality.Equal(TrialingPlanId, other.TrialingPlanId)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(DurationDays));
        hash.Add(global::Meteroid.Equality.Hash(IsFree));
        hash.Add(global::Meteroid.Equality.Hash(TrialingPlanId));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
