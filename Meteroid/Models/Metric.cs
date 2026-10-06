// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>Metric</c> object.</summary>
public sealed partial record Metric
{
    /// <summary>The <c>aggregation_key</c> property.</summary>
    [JsonPropertyName("aggregation_key")]
    public string? AggregationKey { get; init; }

    /// <summary>The <c>aggregation_type</c> property.</summary>
    [JsonPropertyName("aggregation_type")]
    public required BillingMetricAggregateEnum AggregationType { get; init; }

    /// <summary>The <c>archived_at</c> property.</summary>
    [JsonPropertyName("archived_at")]
    public DateTimeOffset? ArchivedAt { get; init; }

    /// <summary>The <c>code</c> property.</summary>
    [JsonPropertyName("code")]
    public required string Code { get; init; }

    /// <summary>The <c>created_at</c> property.</summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>The <c>description</c> property.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>The <c>filters</c> property.</summary>
    [JsonPropertyName("filters")]
    public IReadOnlyList<MetricFilter>? Filters { get; init; }

    /// <summary>The <c>id</c> property.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>The <c>name</c> property.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>The <c>product_family_id</c> property.</summary>
    [JsonPropertyName("product_family_id")]
    public required string ProductFamilyId { get; init; }

    /// <summary>The <c>product_id</c> property.</summary>
    [JsonPropertyName("product_id")]
    public string? ProductId { get; init; }

    /// <summary>The <c>segmentation_matrix</c> property.</summary>
    [JsonPropertyName("segmentation_matrix")]
    public MetricSegmentationMatrix? SegmentationMatrix { get; init; }

    /// <summary>The <c>unit_conversion</c> property.</summary>
    [JsonPropertyName("unit_conversion")]
    public UnitConversion? UnitConversion { get; init; }

    /// <summary>The <c>usage_group_key</c> property.</summary>
    [JsonPropertyName("usage_group_key")]
    public string? UsageGroupKey { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(Metric? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(AggregationKey, other.AggregationKey)
        && global::Meteroid.Equality.Equal(AggregationType, other.AggregationType)
        && global::Meteroid.Equality.Equal(ArchivedAt, other.ArchivedAt)
        && global::Meteroid.Equality.Equal(Code, other.Code)
        && global::Meteroid.Equality.Equal(CreatedAt, other.CreatedAt)
        && global::Meteroid.Equality.Equal(Description, other.Description)
        && global::Meteroid.Equality.Equal(Filters, other.Filters)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(Name, other.Name)
        && global::Meteroid.Equality.Equal(ProductFamilyId, other.ProductFamilyId)
        && global::Meteroid.Equality.Equal(ProductId, other.ProductId)
        && global::Meteroid.Equality.Equal(SegmentationMatrix, other.SegmentationMatrix)
        && global::Meteroid.Equality.Equal(UnitConversion, other.UnitConversion)
        && global::Meteroid.Equality.Equal(UsageGroupKey, other.UsageGroupKey)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(AggregationKey));
        hash.Add(global::Meteroid.Equality.Hash(AggregationType));
        hash.Add(global::Meteroid.Equality.Hash(ArchivedAt));
        hash.Add(global::Meteroid.Equality.Hash(Code));
        hash.Add(global::Meteroid.Equality.Hash(CreatedAt));
        hash.Add(global::Meteroid.Equality.Hash(Description));
        hash.Add(global::Meteroid.Equality.Hash(Filters));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(Name));
        hash.Add(global::Meteroid.Equality.Hash(ProductFamilyId));
        hash.Add(global::Meteroid.Equality.Hash(ProductId));
        hash.Add(global::Meteroid.Equality.Hash(SegmentationMatrix));
        hash.Add(global::Meteroid.Equality.Hash(UnitConversion));
        hash.Add(global::Meteroid.Equality.Hash(UsageGroupKey));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
