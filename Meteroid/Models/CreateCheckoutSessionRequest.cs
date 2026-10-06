// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>CreateCheckoutSessionRequest</c> object.</summary>
public sealed partial record CreateCheckoutSessionRequest
{
    /// <summary>The <c>add_ons</c> property.</summary>
    [JsonPropertyName("add_ons")]
    public IReadOnlyList<CreateSubscriptionAddOn>? AddOns { get; init; }

    /// <summary>
    /// If false, invoices will stay in Draft until manually reviewed and finalized. Default is true.
    /// </summary>
    [JsonPropertyName("auto_advance_invoices")]
    public bool? AutoAdvanceInvoices { get; init; }

    /// <summary>The <c>billing_day_anchor</c> property.</summary>
    [JsonPropertyName("billing_day_anchor")]
    public int? BillingDayAnchor { get; init; }

    /// <summary>The <c>billing_start_date</c> property.</summary>
    [JsonPropertyName("billing_start_date")]
    public DateOnly? BillingStartDate { get; init; }

    /// <summary>
    /// Absolute http(s) URL offered to the customer to leave the checkout without paying.
    /// </summary>
    [JsonPropertyName("cancel_url")]
    public string? CancelUrl { get; init; }

    /// <summary>
    /// Automatically try to charge the customer's configured payment method on finalize. Default is true.
    /// </summary>
    [JsonPropertyName("charge_automatically")]
    public bool? ChargeAutomatically { get; init; }

    /// <summary>The <c>components</c> property.</summary>
    [JsonPropertyName("components")]
    public CreateSubscriptionComponents? Components { get; init; }

    /// <summary>The <c>coupon_code</c> property.</summary>
    [JsonPropertyName("coupon_code")]
    public string? CouponCode { get; init; }

    /// <summary>The <c>coupon_ids</c> property.</summary>
    [JsonPropertyName("coupon_ids")]
    public IReadOnlyList<string>? CouponIds { get; init; }

    /// <summary>
    /// Customer ID or alias
    /// </summary>
    [JsonPropertyName("customer_id")]
    public required string CustomerId { get; init; }

    /// <summary>The <c>end_date</c> property.</summary>
    [JsonPropertyName("end_date")]
    public DateOnly? EndDate { get; init; }

    /// <summary>
    /// Session expiry time in hours. Default is 1 hour for self-serve checkout.
    /// </summary>
    [JsonPropertyName("expires_in_hours")]
    public int? ExpiresInHours { get; init; }

    /// <summary>The <c>invoice_memo</c> property.</summary>
    [JsonPropertyName("invoice_memo")]
    public string? InvoiceMemo { get; init; }

    /// <summary>The <c>invoice_threshold</c> property.</summary>
    [JsonPropertyName("invoice_threshold")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public decimal? InvoiceThreshold { get; init; }

    /// <summary>The <c>metadata</c> property.</summary>
    [JsonPropertyName("metadata")]
    public JsonNode? Metadata { get; init; }

    /// <summary>The <c>net_terms</c> property.</summary>
    [JsonPropertyName("net_terms")]
    public int? NetTerms { get; init; }

    /// <summary>The <c>payment_methods_config</c> property.</summary>
    [JsonPropertyName("payment_methods_config")]
    public PaymentMethodsConfig? PaymentMethodsConfig { get; init; }

    /// <summary>The <c>plan_version_id</c> property.</summary>
    [JsonPropertyName("plan_version_id")]
    public required string PlanVersionId { get; init; }

    /// <summary>The <c>purchase_order</c> property.</summary>
    [JsonPropertyName("purchase_order")]
    public string? PurchaseOrder { get; init; }

    /// <summary>
    /// Absolute http(s) URL the customer is sent to after a successful checkout.
    /// <c>checkout_session_id</c> is appended as a query parameter. Without it the customer stays on
    /// the hosted confirmation page.
    /// </summary>
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
    public bool Equals(CreateCheckoutSessionRequest? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(AddOns, other.AddOns)
        && global::Meteroid.Equality.Equal(AutoAdvanceInvoices, other.AutoAdvanceInvoices)
        && global::Meteroid.Equality.Equal(BillingDayAnchor, other.BillingDayAnchor)
        && global::Meteroid.Equality.Equal(BillingStartDate, other.BillingStartDate)
        && global::Meteroid.Equality.Equal(CancelUrl, other.CancelUrl)
        && global::Meteroid.Equality.Equal(ChargeAutomatically, other.ChargeAutomatically)
        && global::Meteroid.Equality.Equal(Components, other.Components)
        && global::Meteroid.Equality.Equal(CouponCode, other.CouponCode)
        && global::Meteroid.Equality.Equal(CouponIds, other.CouponIds)
        && global::Meteroid.Equality.Equal(CustomerId, other.CustomerId)
        && global::Meteroid.Equality.Equal(EndDate, other.EndDate)
        && global::Meteroid.Equality.Equal(ExpiresInHours, other.ExpiresInHours)
        && global::Meteroid.Equality.Equal(InvoiceMemo, other.InvoiceMemo)
        && global::Meteroid.Equality.Equal(InvoiceThreshold, other.InvoiceThreshold)
        && global::Meteroid.Equality.Equal(Metadata, other.Metadata)
        && global::Meteroid.Equality.Equal(NetTerms, other.NetTerms)
        && global::Meteroid.Equality.Equal(PaymentMethodsConfig, other.PaymentMethodsConfig)
        && global::Meteroid.Equality.Equal(PlanVersionId, other.PlanVersionId)
        && global::Meteroid.Equality.Equal(PurchaseOrder, other.PurchaseOrder)
        && global::Meteroid.Equality.Equal(SuccessUrl, other.SuccessUrl)
        && global::Meteroid.Equality.Equal(TrialDurationDays, other.TrialDurationDays)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(AddOns));
        hash.Add(global::Meteroid.Equality.Hash(AutoAdvanceInvoices));
        hash.Add(global::Meteroid.Equality.Hash(BillingDayAnchor));
        hash.Add(global::Meteroid.Equality.Hash(BillingStartDate));
        hash.Add(global::Meteroid.Equality.Hash(CancelUrl));
        hash.Add(global::Meteroid.Equality.Hash(ChargeAutomatically));
        hash.Add(global::Meteroid.Equality.Hash(Components));
        hash.Add(global::Meteroid.Equality.Hash(CouponCode));
        hash.Add(global::Meteroid.Equality.Hash(CouponIds));
        hash.Add(global::Meteroid.Equality.Hash(CustomerId));
        hash.Add(global::Meteroid.Equality.Hash(EndDate));
        hash.Add(global::Meteroid.Equality.Hash(ExpiresInHours));
        hash.Add(global::Meteroid.Equality.Hash(InvoiceMemo));
        hash.Add(global::Meteroid.Equality.Hash(InvoiceThreshold));
        hash.Add(global::Meteroid.Equality.Hash(Metadata));
        hash.Add(global::Meteroid.Equality.Hash(NetTerms));
        hash.Add(global::Meteroid.Equality.Hash(PaymentMethodsConfig));
        hash.Add(global::Meteroid.Equality.Hash(PlanVersionId));
        hash.Add(global::Meteroid.Equality.Hash(PurchaseOrder));
        hash.Add(global::Meteroid.Equality.Hash(SuccessUrl));
        hash.Add(global::Meteroid.Equality.Hash(TrialDurationDays));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
