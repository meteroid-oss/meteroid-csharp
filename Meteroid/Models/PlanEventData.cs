// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>PlanEventData</c> object.</summary>
public sealed partial record PlanEventData
{
    /// <summary>The <c>created_at</c> property.</summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>The <c>currency</c> property.</summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>The <c>description</c> property.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>The <c>name</c> property.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>The <c>plan_id</c> property.</summary>
    [JsonPropertyName("plan_id")]
    public required string PlanId { get; init; }

    /// <summary>The <c>plan_type</c> property.</summary>
    [JsonPropertyName("plan_type")]
    public required PlanTypeEnum PlanType { get; init; }

    /// <summary>The <c>status</c> property.</summary>
    [JsonPropertyName("status")]
    public required PlanStatusEnum Status { get; init; }

    /// <summary>The <c>version</c> property.</summary>
    [JsonPropertyName("version")]
    public required int Version { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(PlanEventData? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(CreatedAt, other.CreatedAt)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(Description, other.Description)
        && global::Meteroid.Equality.Equal(Name, other.Name)
        && global::Meteroid.Equality.Equal(PlanId, other.PlanId)
        && global::Meteroid.Equality.Equal(PlanType, other.PlanType)
        && global::Meteroid.Equality.Equal(Status, other.Status)
        && global::Meteroid.Equality.Equal(Version, other.Version)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(CreatedAt));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(Description));
        hash.Add(global::Meteroid.Equality.Hash(Name));
        hash.Add(global::Meteroid.Equality.Hash(PlanId));
        hash.Add(global::Meteroid.Equality.Hash(PlanType));
        hash.Add(global::Meteroid.Equality.Hash(Status));
        hash.Add(global::Meteroid.Equality.Hash(Version));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
