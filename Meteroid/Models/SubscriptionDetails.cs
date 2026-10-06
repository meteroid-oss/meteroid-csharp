// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>SubscriptionDetails</c> object.</summary>
public sealed partial record SubscriptionDetails
{
    /// <summary>
    /// When the subscription was activated (first payment or activation condition met)
    /// </summary>
    [JsonPropertyName("activated_at")]
    public DateTimeOffset? ActivatedAt { get; init; }

    /// <summary>The <c>add_ons</c> property.</summary>
    [JsonPropertyName("add_ons")]
    public required IReadOnlyList<SubscriptionAddOn> AddOns { get; init; }

    /// <summary>The <c>applied_coupons</c> property.</summary>
    [JsonPropertyName("applied_coupons")]
    public required IReadOnlyList<AppliedCouponDetailed> AppliedCoupons { get; init; }

    /// <summary>The <c>auto_advance_invoices</c> property.</summary>
    [JsonPropertyName("auto_advance_invoices")]
    public required bool AutoAdvanceInvoices { get; init; }

    /// <summary>The <c>billing_day_anchor</c> property.</summary>
    [JsonPropertyName("billing_day_anchor")]
    public required int BillingDayAnchor { get; init; }

    /// <summary>
    /// When billing started (after any trial period)
    /// </summary>
    [JsonPropertyName("billing_start_date")]
    public DateOnly? BillingStartDate { get; init; }

    /// <summary>The <c>charge_automatically</c> property.</summary>
    [JsonPropertyName("charge_automatically")]
    public required bool ChargeAutomatically { get; init; }

    /// <summary>The <c>checkout_url</c> property.</summary>
    [JsonPropertyName("checkout_url")]
    public string? CheckoutUrl { get; init; }

    /// <summary>The <c>components</c> property.</summary>
    [JsonPropertyName("components")]
    public required IReadOnlyList<SubscriptionComponent> Components { get; init; }

    /// <summary>
    /// When the subscription was created
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>The <c>currency</c> property.</summary>
    [JsonPropertyName("currency")]
    public required Currency Currency { get; init; }

    /// <summary>
    /// Current billing period end date
    /// </summary>
    [JsonPropertyName("current_period_end")]
    public DateOnly? CurrentPeriodEnd { get; init; }

    /// <summary>
    /// Current billing period start date
    /// </summary>
    [JsonPropertyName("current_period_start")]
    public required DateOnly CurrentPeriodStart { get; init; }

    /// <summary>
    /// User-defined custom property values, keyed by definition <c>key</c>.
    /// </summary>
    [JsonPropertyName("custom_properties")]
    public required JsonNode CustomProperties { get; init; }

    /// <summary>The <c>customer_alias</c> property.</summary>
    [JsonPropertyName("customer_alias")]
    public string? CustomerAlias { get; init; }

    /// <summary>The <c>customer_id</c> property.</summary>
    [JsonPropertyName("customer_id")]
    public required string CustomerId { get; init; }

    /// <summary>The <c>customer_name</c> property.</summary>
    [JsonPropertyName("customer_name")]
    public required string CustomerName { get; init; }

    /// <summary>
    /// When the subscription ends (if set)
    /// </summary>
    [JsonPropertyName("end_date")]
    public DateOnly? EndDate { get; init; }

    /// <summary>The <c>entitlements</c> property.</summary>
    [JsonPropertyName("entitlements")]
    public IReadOnlyList<Entitlement>? Entitlements { get; init; }

    /// <summary>The <c>id</c> property.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Default memo for invoices
    /// </summary>
    [JsonPropertyName("invoice_memo")]
    public string? InvoiceMemo { get; init; }

    /// <summary>The <c>minimum_commitment</c> property.</summary>
    [JsonPropertyName("minimum_commitment")]
    public MinimumCommitment? MinimumCommitment { get; init; }

    /// <summary>
    /// Monthly recurring revenue in cents
    /// </summary>
    [JsonPropertyName("mrr_cents")]
    public required long MrrCents { get; init; }

    /// <summary>
    /// Payment terms in days (0 = due on issue)
    /// </summary>
    [JsonPropertyName("net_terms")]
    public required int NetTerms { get; init; }

    /// <summary>The <c>payment_methods_config</c> property.</summary>
    [JsonPropertyName("payment_methods_config")]
    public PaymentMethodsConfig? PaymentMethodsConfig { get; init; }

    /// <summary>
    /// Billing period (monthly, annual, etc.)
    /// </summary>
    [JsonPropertyName("period")]
    public required BillingPeriodEnum Period { get; init; }

    /// <summary>The <c>plan_id</c> property.</summary>
    [JsonPropertyName("plan_id")]
    public required string PlanId { get; init; }

    /// <summary>The <c>plan_name</c> property.</summary>
    [JsonPropertyName("plan_name")]
    public required string PlanName { get; init; }

    /// <summary>The <c>plan_version</c> property.</summary>
    [JsonPropertyName("plan_version")]
    public required int PlanVersion { get; init; }

    /// <summary>The <c>plan_version_id</c> property.</summary>
    [JsonPropertyName("plan_version_id")]
    public required string PlanVersionId { get; init; }

    /// <summary>The <c>purchase_order</c> property.</summary>
    [JsonPropertyName("purchase_order")]
    public string? PurchaseOrder { get; init; }

    /// <summary>
    /// When the subscription contract starts (benefits apply from this date)
    /// </summary>
    [JsonPropertyName("start_date")]
    public required DateOnly StartDate { get; init; }

    /// <summary>The <c>status</c> property.</summary>
    [JsonPropertyName("status")]
    public required SubscriptionStatusEnum Status { get; init; }

    /// <summary>
    /// The subscription's prices are quoted tax-included (snapshotted from its plan version).
    /// </summary>
    [JsonPropertyName("tax_inclusive")]
    public required bool TaxInclusive { get; init; }

    /// <summary>
    /// Trial duration in days
    /// </summary>
    [JsonPropertyName("trial_duration")]
    public int? TrialDuration { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(SubscriptionDetails? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(ActivatedAt, other.ActivatedAt)
        && global::Meteroid.Equality.Equal(AddOns, other.AddOns)
        && global::Meteroid.Equality.Equal(AppliedCoupons, other.AppliedCoupons)
        && global::Meteroid.Equality.Equal(AutoAdvanceInvoices, other.AutoAdvanceInvoices)
        && global::Meteroid.Equality.Equal(BillingDayAnchor, other.BillingDayAnchor)
        && global::Meteroid.Equality.Equal(BillingStartDate, other.BillingStartDate)
        && global::Meteroid.Equality.Equal(ChargeAutomatically, other.ChargeAutomatically)
        && global::Meteroid.Equality.Equal(CheckoutUrl, other.CheckoutUrl)
        && global::Meteroid.Equality.Equal(Components, other.Components)
        && global::Meteroid.Equality.Equal(CreatedAt, other.CreatedAt)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(CurrentPeriodEnd, other.CurrentPeriodEnd)
        && global::Meteroid.Equality.Equal(CurrentPeriodStart, other.CurrentPeriodStart)
        && global::Meteroid.Equality.Equal(CustomProperties, other.CustomProperties)
        && global::Meteroid.Equality.Equal(CustomerAlias, other.CustomerAlias)
        && global::Meteroid.Equality.Equal(CustomerId, other.CustomerId)
        && global::Meteroid.Equality.Equal(CustomerName, other.CustomerName)
        && global::Meteroid.Equality.Equal(EndDate, other.EndDate)
        && global::Meteroid.Equality.Equal(Entitlements, other.Entitlements)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(InvoiceMemo, other.InvoiceMemo)
        && global::Meteroid.Equality.Equal(MinimumCommitment, other.MinimumCommitment)
        && global::Meteroid.Equality.Equal(MrrCents, other.MrrCents)
        && global::Meteroid.Equality.Equal(NetTerms, other.NetTerms)
        && global::Meteroid.Equality.Equal(PaymentMethodsConfig, other.PaymentMethodsConfig)
        && global::Meteroid.Equality.Equal(Period, other.Period)
        && global::Meteroid.Equality.Equal(PlanId, other.PlanId)
        && global::Meteroid.Equality.Equal(PlanName, other.PlanName)
        && global::Meteroid.Equality.Equal(PlanVersion, other.PlanVersion)
        && global::Meteroid.Equality.Equal(PlanVersionId, other.PlanVersionId)
        && global::Meteroid.Equality.Equal(PurchaseOrder, other.PurchaseOrder)
        && global::Meteroid.Equality.Equal(StartDate, other.StartDate)
        && global::Meteroid.Equality.Equal(Status, other.Status)
        && global::Meteroid.Equality.Equal(TaxInclusive, other.TaxInclusive)
        && global::Meteroid.Equality.Equal(TrialDuration, other.TrialDuration)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(ActivatedAt));
        hash.Add(global::Meteroid.Equality.Hash(AddOns));
        hash.Add(global::Meteroid.Equality.Hash(AppliedCoupons));
        hash.Add(global::Meteroid.Equality.Hash(AutoAdvanceInvoices));
        hash.Add(global::Meteroid.Equality.Hash(BillingDayAnchor));
        hash.Add(global::Meteroid.Equality.Hash(BillingStartDate));
        hash.Add(global::Meteroid.Equality.Hash(ChargeAutomatically));
        hash.Add(global::Meteroid.Equality.Hash(CheckoutUrl));
        hash.Add(global::Meteroid.Equality.Hash(Components));
        hash.Add(global::Meteroid.Equality.Hash(CreatedAt));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(CurrentPeriodEnd));
        hash.Add(global::Meteroid.Equality.Hash(CurrentPeriodStart));
        hash.Add(global::Meteroid.Equality.Hash(CustomProperties));
        hash.Add(global::Meteroid.Equality.Hash(CustomerAlias));
        hash.Add(global::Meteroid.Equality.Hash(CustomerId));
        hash.Add(global::Meteroid.Equality.Hash(CustomerName));
        hash.Add(global::Meteroid.Equality.Hash(EndDate));
        hash.Add(global::Meteroid.Equality.Hash(Entitlements));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(InvoiceMemo));
        hash.Add(global::Meteroid.Equality.Hash(MinimumCommitment));
        hash.Add(global::Meteroid.Equality.Hash(MrrCents));
        hash.Add(global::Meteroid.Equality.Hash(NetTerms));
        hash.Add(global::Meteroid.Equality.Hash(PaymentMethodsConfig));
        hash.Add(global::Meteroid.Equality.Hash(Period));
        hash.Add(global::Meteroid.Equality.Hash(PlanId));
        hash.Add(global::Meteroid.Equality.Hash(PlanName));
        hash.Add(global::Meteroid.Equality.Hash(PlanVersion));
        hash.Add(global::Meteroid.Equality.Hash(PlanVersionId));
        hash.Add(global::Meteroid.Equality.Hash(PurchaseOrder));
        hash.Add(global::Meteroid.Equality.Hash(StartDate));
        hash.Add(global::Meteroid.Equality.Hash(Status));
        hash.Add(global::Meteroid.Equality.Hash(TaxInclusive));
        hash.Add(global::Meteroid.Equality.Hash(TrialDuration));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
