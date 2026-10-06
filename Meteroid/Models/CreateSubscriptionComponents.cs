// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>CreateSubscriptionComponents</c> object.</summary>
public sealed partial record CreateSubscriptionComponents
{
    /// <summary>The <c>extra_components</c> property.</summary>
    [JsonPropertyName("extra_components")]
    public IReadOnlyList<ExtraComponent>? ExtraComponents { get; init; }

    /// <summary>The <c>overridden_components</c> property.</summary>
    [JsonPropertyName("overridden_components")]
    public IReadOnlyList<ComponentOverride>? OverriddenComponents { get; init; }

    /// <summary>The <c>parameterized_components</c> property.</summary>
    [JsonPropertyName("parameterized_components")]
    public IReadOnlyList<ComponentParameterization>? ParameterizedComponents { get; init; }

    /// <summary>The <c>remove_components</c> property.</summary>
    [JsonPropertyName("remove_components")]
    public IReadOnlyList<string>? RemoveComponents { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(CreateSubscriptionComponents? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(ExtraComponents, other.ExtraComponents)
        && global::Meteroid.Equality.Equal(OverriddenComponents, other.OverriddenComponents)
        && global::Meteroid.Equality.Equal(ParameterizedComponents, other.ParameterizedComponents)
        && global::Meteroid.Equality.Equal(RemoveComponents, other.RemoveComponents)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(ExtraComponents));
        hash.Add(global::Meteroid.Equality.Hash(OverriddenComponents));
        hash.Add(global::Meteroid.Equality.Hash(ParameterizedComponents));
        hash.Add(global::Meteroid.Equality.Hash(RemoveComponents));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
