// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>AddOnEvent</c> object.</summary>
public sealed partial record AddOnEvent
{
    /// <summary>The <c>add_on_id</c> property.</summary>
    [JsonPropertyName("add_on_id")]
    public required string AddOnId { get; init; }

    /// <summary>The <c>created_at</c> property.</summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>The <c>description</c> property.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>The <c>fee_type</c> property.</summary>
    [JsonPropertyName("fee_type")]
    public ProductFeeTypeEnum? FeeType { get; init; }

    /// <summary>The <c>max_instances_per_subscription</c> property.</summary>
    [JsonPropertyName("max_instances_per_subscription")]
    public int? MaxInstancesPerSubscription { get; init; }

    /// <summary>The <c>name</c> property.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>The <c>price_id</c> property.</summary>
    [JsonPropertyName("price_id")]
    public required string PriceId { get; init; }

    /// <summary>The <c>product_id</c> property.</summary>
    [JsonPropertyName("product_id")]
    public required string ProductId { get; init; }

    /// <summary>The <c>self_serviceable</c> property.</summary>
    [JsonPropertyName("self_serviceable")]
    public required bool SelfServiceable { get; init; }

    /// <summary>The <c>id</c> property.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>The <c>timestamp</c> property.</summary>
    [JsonPropertyName("timestamp")]
    public required DateTimeOffset Timestamp { get; init; }

    /// <summary>The <c>type</c> property.</summary>
    [JsonPropertyName("type")]
    public required EventType Type { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(AddOnEvent? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(AddOnId, other.AddOnId)
        && global::Meteroid.Equality.Equal(CreatedAt, other.CreatedAt)
        && global::Meteroid.Equality.Equal(Description, other.Description)
        && global::Meteroid.Equality.Equal(FeeType, other.FeeType)
        && global::Meteroid.Equality.Equal(MaxInstancesPerSubscription, other.MaxInstancesPerSubscription)
        && global::Meteroid.Equality.Equal(Name, other.Name)
        && global::Meteroid.Equality.Equal(PriceId, other.PriceId)
        && global::Meteroid.Equality.Equal(ProductId, other.ProductId)
        && global::Meteroid.Equality.Equal(SelfServiceable, other.SelfServiceable)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(Timestamp, other.Timestamp)
        && global::Meteroid.Equality.Equal(Type, other.Type)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(AddOnId));
        hash.Add(global::Meteroid.Equality.Hash(CreatedAt));
        hash.Add(global::Meteroid.Equality.Hash(Description));
        hash.Add(global::Meteroid.Equality.Hash(FeeType));
        hash.Add(global::Meteroid.Equality.Hash(MaxInstancesPerSubscription));
        hash.Add(global::Meteroid.Equality.Hash(Name));
        hash.Add(global::Meteroid.Equality.Hash(PriceId));
        hash.Add(global::Meteroid.Equality.Hash(ProductId));
        hash.Add(global::Meteroid.Equality.Hash(SelfServiceable));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(Timestamp));
        hash.Add(global::Meteroid.Equality.Hash(Type));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
