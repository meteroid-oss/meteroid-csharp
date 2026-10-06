// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>CheckoutSession</c> object.</summary>
public sealed partial record CheckoutSession
{
    /// <summary>The <c>billing_day_anchor</c> property.</summary>
    [JsonPropertyName("billing_day_anchor")]
    public int? BillingDayAnchor { get; init; }

    /// <summary>The <c>billing_start_date</c> property.</summary>
    [JsonPropertyName("billing_start_date")]
    public DateOnly? BillingStartDate { get; init; }

    /// <summary>The <c>cancel_url</c> property.</summary>
    [JsonPropertyName("cancel_url")]
    public string? CancelUrl { get; init; }

    /// <summary>The <c>checkout_type</c> property.</summary>
    [JsonPropertyName("checkout_type")]
    public required CheckoutType CheckoutType { get; init; }

    /// <summary>The <c>checkout_url</c> property.</summary>
    [JsonPropertyName("checkout_url")]
    public string? CheckoutUrl { get; init; }

    /// <summary>The <c>completed_at</c> property.</summary>
    [JsonPropertyName("completed_at")]
    public DateTimeOffset? CompletedAt { get; init; }

    /// <summary>The <c>coupon_code</c> property.</summary>
    [JsonPropertyName("coupon_code")]
    public string? CouponCode { get; init; }

    /// <summary>The <c>created_at</c> property.</summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>The <c>customer_id</c> property.</summary>
    [JsonPropertyName("customer_id")]
    public required string CustomerId { get; init; }

    /// <summary>
    /// When the session expires. None means the session never expires.
    /// </summary>
    [JsonPropertyName("expires_at")]
    public DateTimeOffset? ExpiresAt { get; init; }

    /// <summary>The <c>id</c> property.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>The <c>net_terms</c> property.</summary>
    [JsonPropertyName("net_terms")]
    public int? NetTerms { get; init; }

    /// <summary>The <c>payment_methods_config</c> property.</summary>
    [JsonPropertyName("payment_methods_config")]
    public PaymentMethodsConfig? PaymentMethodsConfig { get; init; }

    /// <summary>The <c>plan_version_id</c> property.</summary>
    [JsonPropertyName("plan_version_id")]
    public required string PlanVersionId { get; init; }

    /// <summary>The <c>status</c> property.</summary>
    [JsonPropertyName("status")]
    public required CheckoutSessionStatus Status { get; init; }

    /// <summary>The <c>subscription_id</c> property.</summary>
    [JsonPropertyName("subscription_id")]
    public string? SubscriptionId { get; init; }

    /// <summary>The <c>success_url</c> property.</summary>
    [JsonPropertyName("success_url")]
    public string? SuccessUrl { get; init; }

    /// <summary>The <c>trial_duration_days</c> property.</summary>
    [JsonPropertyName("trial_duration_days")]
    public int? TrialDurationDays { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(CheckoutSession? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(BillingDayAnchor, other.BillingDayAnchor)
        && global::Meteroid.Equality.Equal(BillingStartDate, other.BillingStartDate)
        && global::Meteroid.Equality.Equal(CancelUrl, other.CancelUrl)
        && global::Meteroid.Equality.Equal(CheckoutType, other.CheckoutType)
        && global::Meteroid.Equality.Equal(CheckoutUrl, other.CheckoutUrl)
        && global::Meteroid.Equality.Equal(CompletedAt, other.CompletedAt)
        && global::Meteroid.Equality.Equal(CouponCode, other.CouponCode)
        && global::Meteroid.Equality.Equal(CreatedAt, other.CreatedAt)
        && global::Meteroid.Equality.Equal(CustomerId, other.CustomerId)
        && global::Meteroid.Equality.Equal(ExpiresAt, other.ExpiresAt)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(NetTerms, other.NetTerms)
        && global::Meteroid.Equality.Equal(PaymentMethodsConfig, other.PaymentMethodsConfig)
        && global::Meteroid.Equality.Equal(PlanVersionId, other.PlanVersionId)
        && global::Meteroid.Equality.Equal(Status, other.Status)
        && global::Meteroid.Equality.Equal(SubscriptionId, other.SubscriptionId)
        && global::Meteroid.Equality.Equal(SuccessUrl, other.SuccessUrl)
        && global::Meteroid.Equality.Equal(TrialDurationDays, other.TrialDurationDays)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(BillingDayAnchor));
        hash.Add(global::Meteroid.Equality.Hash(BillingStartDate));
        hash.Add(global::Meteroid.Equality.Hash(CancelUrl));
        hash.Add(global::Meteroid.Equality.Hash(CheckoutType));
        hash.Add(global::Meteroid.Equality.Hash(CheckoutUrl));
        hash.Add(global::Meteroid.Equality.Hash(CompletedAt));
        hash.Add(global::Meteroid.Equality.Hash(CouponCode));
        hash.Add(global::Meteroid.Equality.Hash(CreatedAt));
        hash.Add(global::Meteroid.Equality.Hash(CustomerId));
        hash.Add(global::Meteroid.Equality.Hash(ExpiresAt));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(NetTerms));
        hash.Add(global::Meteroid.Equality.Hash(PaymentMethodsConfig));
        hash.Add(global::Meteroid.Equality.Hash(PlanVersionId));
        hash.Add(global::Meteroid.Equality.Hash(Status));
        hash.Add(global::Meteroid.Equality.Hash(SubscriptionId));
        hash.Add(global::Meteroid.Equality.Hash(SuccessUrl));
        hash.Add(global::Meteroid.Equality.Hash(TrialDurationDays));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
