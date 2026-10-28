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
/// Restricts the customer's usage events a subscription bills to those whose <c>property</c> equals
/// <c>value</c> (for example <c>api_key</c> = <c>key-A</c>). Among the customer's subscriptions pricing the same
/// metric, one with a usage filter bills the events matching it (an event two filters match goes
/// to the older subscription); one without bills the events matching no other subscription's
/// filter. Two subscriptions without a usage filter both bill every such event. Events matching
/// no filter while every subscription pricing their metric has one are billed by none and
/// reported as unattributed usage.
/// </summary>
public sealed partial record UsageFilter
{
    /// <summary>
    /// Event property name, e.g. <c>api_key</c>.
    /// </summary>
    [JsonPropertyName("property")]
    public required string Property { get; init; }

    /// <summary>
    /// Value the property must have.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(UsageFilter? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Property, other.Property)
        && global::Meteroid.Equality.Equal(Value, other.Value)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Property));
        hash.Add(global::Meteroid.Equality.Hash(Value));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
