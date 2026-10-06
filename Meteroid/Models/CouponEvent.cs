// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>CouponEvent</c> object.</summary>
public sealed partial record CouponEvent
{
    /// <summary>The <c>code</c> property.</summary>
    [JsonPropertyName("code")]
    public required string Code { get; init; }

    /// <summary>The <c>coupon_id</c> property.</summary>
    [JsonPropertyName("coupon_id")]
    public required string CouponId { get; init; }

    /// <summary>The <c>created_at</c> property.</summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>The <c>description</c> property.</summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    /// <summary>The <c>disabled</c> property.</summary>
    [JsonPropertyName("disabled")]
    public required bool Disabled { get; init; }

    /// <summary>The <c>discount</c> property.</summary>
    [JsonPropertyName("discount")]
    public required CouponDiscount Discount { get; init; }

    /// <summary>The <c>expires_at</c> property.</summary>
    [JsonPropertyName("expires_at")]
    public DateTimeOffset? ExpiresAt { get; init; }

    /// <summary>The <c>recurring_value</c> property.</summary>
    [JsonPropertyName("recurring_value")]
    public int? RecurringValue { get; init; }

    /// <summary>The <c>redemption_limit</c> property.</summary>
    [JsonPropertyName("redemption_limit")]
    public int? RedemptionLimit { get; init; }

    /// <summary>The <c>reusable</c> property.</summary>
    [JsonPropertyName("reusable")]
    public required bool Reusable { get; init; }

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
    public bool Equals(CouponEvent? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Code, other.Code)
        && global::Meteroid.Equality.Equal(CouponId, other.CouponId)
        && global::Meteroid.Equality.Equal(CreatedAt, other.CreatedAt)
        && global::Meteroid.Equality.Equal(Description, other.Description)
        && global::Meteroid.Equality.Equal(Disabled, other.Disabled)
        && global::Meteroid.Equality.Equal(Discount, other.Discount)
        && global::Meteroid.Equality.Equal(ExpiresAt, other.ExpiresAt)
        && global::Meteroid.Equality.Equal(RecurringValue, other.RecurringValue)
        && global::Meteroid.Equality.Equal(RedemptionLimit, other.RedemptionLimit)
        && global::Meteroid.Equality.Equal(Reusable, other.Reusable)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(Timestamp, other.Timestamp)
        && global::Meteroid.Equality.Equal(Type, other.Type)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Code));
        hash.Add(global::Meteroid.Equality.Hash(CouponId));
        hash.Add(global::Meteroid.Equality.Hash(CreatedAt));
        hash.Add(global::Meteroid.Equality.Hash(Description));
        hash.Add(global::Meteroid.Equality.Hash(Disabled));
        hash.Add(global::Meteroid.Equality.Hash(Discount));
        hash.Add(global::Meteroid.Equality.Hash(ExpiresAt));
        hash.Add(global::Meteroid.Equality.Hash(RecurringValue));
        hash.Add(global::Meteroid.Equality.Hash(RedemptionLimit));
        hash.Add(global::Meteroid.Equality.Hash(Reusable));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(Timestamp));
        hash.Add(global::Meteroid.Equality.Hash(Type));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
