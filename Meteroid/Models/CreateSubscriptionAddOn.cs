// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>CreateSubscriptionAddOn</c> object.</summary>
public sealed partial record CreateSubscriptionAddOn
{
    /// <summary>The <c>add_on_id</c> property.</summary>
    [JsonPropertyName("add_on_id")]
    public required string AddOnId { get; init; }

    /// <summary>The <c>customization</c> property.</summary>
    [JsonPropertyName("customization")]
    public SubscriptionAddOnCustomization? Customization { get; init; }

    /// <summary>The <c>quantity</c> property.</summary>
    [JsonPropertyName("quantity")]
    public int? Quantity { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(CreateSubscriptionAddOn? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(AddOnId, other.AddOnId)
        && global::Meteroid.Equality.Equal(Customization, other.Customization)
        && global::Meteroid.Equality.Equal(Quantity, other.Quantity)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(AddOnId));
        hash.Add(global::Meteroid.Equality.Hash(Customization));
        hash.Add(global::Meteroid.Equality.Hash(Quantity));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
