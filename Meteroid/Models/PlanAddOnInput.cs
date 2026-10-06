// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>PlanAddOnInput</c> object.</summary>
public sealed partial record PlanAddOnInput
{
    /// <summary>The <c>add_on_id</c> property.</summary>
    [JsonPropertyName("add_on_id")]
    public required string AddOnId { get; init; }

    /// <summary>The <c>max_instances</c> property.</summary>
    [JsonPropertyName("max_instances")]
    public int? MaxInstances { get; init; }

    /// <summary>The <c>price_id</c> property.</summary>
    [JsonPropertyName("price_id")]
    public string? PriceId { get; init; }

    /// <summary>The <c>self_serviceable</c> property.</summary>
    [JsonPropertyName("self_serviceable")]
    public bool? SelfServiceable { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(PlanAddOnInput? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(AddOnId, other.AddOnId)
        && global::Meteroid.Equality.Equal(MaxInstances, other.MaxInstances)
        && global::Meteroid.Equality.Equal(PriceId, other.PriceId)
        && global::Meteroid.Equality.Equal(SelfServiceable, other.SelfServiceable)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(AddOnId));
        hash.Add(global::Meteroid.Equality.Hash(MaxInstances));
        hash.Add(global::Meteroid.Equality.Hash(PriceId));
        hash.Add(global::Meteroid.Equality.Hash(SelfServiceable));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
