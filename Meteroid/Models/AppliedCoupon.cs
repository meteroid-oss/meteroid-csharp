// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>AppliedCoupon</c> object.</summary>
public sealed partial record AppliedCoupon
{
    /// <summary>The <c>applied_amount</c> property.</summary>
    [JsonPropertyName("applied_amount")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public decimal? AppliedAmount { get; init; }

    /// <summary>The <c>applied_count</c> property.</summary>
    [JsonPropertyName("applied_count")]
    public int? AppliedCount { get; init; }

    /// <summary>The <c>coupon_id</c> property.</summary>
    [JsonPropertyName("coupon_id")]
    public required string CouponId { get; init; }

    /// <summary>The <c>created_at</c> property.</summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>The <c>id</c> property.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>The <c>is_active</c> property.</summary>
    [JsonPropertyName("is_active")]
    public required bool IsActive { get; init; }

    /// <summary>The <c>last_applied_at</c> property.</summary>
    [JsonPropertyName("last_applied_at")]
    public DateTimeOffset? LastAppliedAt { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(AppliedCoupon? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(AppliedAmount, other.AppliedAmount)
        && global::Meteroid.Equality.Equal(AppliedCount, other.AppliedCount)
        && global::Meteroid.Equality.Equal(CouponId, other.CouponId)
        && global::Meteroid.Equality.Equal(CreatedAt, other.CreatedAt)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(IsActive, other.IsActive)
        && global::Meteroid.Equality.Equal(LastAppliedAt, other.LastAppliedAt)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(AppliedAmount));
        hash.Add(global::Meteroid.Equality.Hash(AppliedCount));
        hash.Add(global::Meteroid.Equality.Hash(CouponId));
        hash.Add(global::Meteroid.Equality.Hash(CreatedAt));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(IsActive));
        hash.Add(global::Meteroid.Equality.Hash(LastAppliedAt));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
