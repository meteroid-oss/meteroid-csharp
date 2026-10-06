// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>AppliedCouponDetailed</c> object.</summary>
public sealed partial record AppliedCouponDetailed
{
    /// <summary>The <c>applied_coupon</c> property.</summary>
    [JsonPropertyName("applied_coupon")]
    public required AppliedCoupon AppliedCoupon { get; init; }

    /// <summary>The <c>coupon</c> property.</summary>
    [JsonPropertyName("coupon")]
    public required SubscriptionCoupon Coupon { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(AppliedCouponDetailed? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(AppliedCoupon, other.AppliedCoupon)
        && global::Meteroid.Equality.Equal(Coupon, other.Coupon)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(AppliedCoupon));
        hash.Add(global::Meteroid.Equality.Hash(Coupon));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
