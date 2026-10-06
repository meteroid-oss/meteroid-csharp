// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>SubscriptionCreateRequest</c> object.</summary>
public sealed partial record SubscriptionCreateRequest
{
    /// <summary>The <c>activation_condition</c> property.</summary>
    [JsonPropertyName("activation_condition")]
    public required SubscriptionActivationConditionEnum ActivationCondition { get; init; }

    /// <summary>The <c>add_ons</c> property.</summary>
    [JsonPropertyName("add_ons")]
    public IReadOnlyList<CreateSubscriptionAddOn>? AddOns { get; init; }

    /// <summary>The <c>auto_advance_invoices</c> property.</summary>
    [JsonPropertyName("auto_advance_invoices")]
    public bool? AutoAdvanceInvoices { get; init; }

    /// <summary>
    /// Historical import mode: when true, invoices finalized for this subscription keep their
    /// billing-period date as the invoice date instead of being stamped with the emission date.
    /// </summary>
    [JsonPropertyName("backdate_invoices")]
    public bool? BackdateInvoices { get; init; }

    /// <summary>The <c>billing_day_anchor</c> property.</summary>
    [JsonPropertyName("billing_day_anchor")]
    public int? BillingDayAnchor { get; init; }

    /// <summary>The <c>charge_automatically</c> property.</summary>
    [JsonPropertyName("charge_automatically")]
    public bool? ChargeAutomatically { get; init; }

    /// <summary>The <c>coupon_codes</c> property.</summary>
    [JsonPropertyName("coupon_codes")]
    public IReadOnlyList<string>? CouponCodes { get; init; }

    /// <summary>
    /// User-defined custom property values, keyed by definition <c>key</c>. Validated against the
    /// tenant's subscription definitions.
    /// </summary>
    [JsonPropertyName("custom_properties")]
    public JsonNode? CustomProperties { get; init; }

    /// <summary>The <c>customer_id_or_alias</c> property.</summary>
    [JsonPropertyName("customer_id_or_alias")]
    public required string CustomerIdOrAlias { get; init; }

    /// <summary>The <c>end_date</c> property.</summary>
    [JsonPropertyName("end_date")]
    public DateOnly? EndDate { get; init; }

    /// <summary>The <c>invoice_memo</c> property.</summary>
    [JsonPropertyName("invoice_memo")]
    public string? InvoiceMemo { get; init; }

    /// <summary>The <c>net_terms</c> property.</summary>
    [JsonPropertyName("net_terms")]
    public int? NetTerms { get; init; }

    /// <summary>
    /// Payment methods configuration. If not specified, inherits from the invoicing entity.
    /// </summary>
    [JsonPropertyName("payment_methods_config")]
    public PaymentMethodsConfig? PaymentMethodsConfig { get; init; }

    /// <summary>The <c>plan_id</c> property.</summary>
    [JsonPropertyName("plan_id")]
    public required string PlanId { get; init; }

    /// <summary>The <c>price_components</c> property.</summary>
    [JsonPropertyName("price_components")]
    public CreateSubscriptionComponents? PriceComponents { get; init; }

    /// <summary>The <c>purchase_order</c> property.</summary>
    [JsonPropertyName("purchase_order")]
    public string? PurchaseOrder { get; init; }

    /// <summary>
    /// Migration mode: when true with a past start_date, skip creating invoices for past cycles.
    /// The subscription will be set to the current billing period with correct cycle_index.
    /// </summary>
    [JsonPropertyName("skip_past_invoices")]
    public bool? SkipPastInvoices { get; init; }

    /// <summary>The <c>start_date</c> property.</summary>
    [JsonPropertyName("start_date")]
    public required DateOnly StartDate { get; init; }

    /// <summary>The <c>trial_days</c> property.</summary>
    [JsonPropertyName("trial_days")]
    public int? TrialDays { get; init; }

    /// <summary>The <c>version</c> property.</summary>
    [JsonPropertyName("version")]
    public int? Version { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(SubscriptionCreateRequest? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(ActivationCondition, other.ActivationCondition)
        && global::Meteroid.Equality.Equal(AddOns, other.AddOns)
        && global::Meteroid.Equality.Equal(AutoAdvanceInvoices, other.AutoAdvanceInvoices)
        && global::Meteroid.Equality.Equal(BackdateInvoices, other.BackdateInvoices)
        && global::Meteroid.Equality.Equal(BillingDayAnchor, other.BillingDayAnchor)
        && global::Meteroid.Equality.Equal(ChargeAutomatically, other.ChargeAutomatically)
        && global::Meteroid.Equality.Equal(CouponCodes, other.CouponCodes)
        && global::Meteroid.Equality.Equal(CustomProperties, other.CustomProperties)
        && global::Meteroid.Equality.Equal(CustomerIdOrAlias, other.CustomerIdOrAlias)
        && global::Meteroid.Equality.Equal(EndDate, other.EndDate)
        && global::Meteroid.Equality.Equal(InvoiceMemo, other.InvoiceMemo)
        && global::Meteroid.Equality.Equal(NetTerms, other.NetTerms)
        && global::Meteroid.Equality.Equal(PaymentMethodsConfig, other.PaymentMethodsConfig)
        && global::Meteroid.Equality.Equal(PlanId, other.PlanId)
        && global::Meteroid.Equality.Equal(PriceComponents, other.PriceComponents)
        && global::Meteroid.Equality.Equal(PurchaseOrder, other.PurchaseOrder)
        && global::Meteroid.Equality.Equal(SkipPastInvoices, other.SkipPastInvoices)
        && global::Meteroid.Equality.Equal(StartDate, other.StartDate)
        && global::Meteroid.Equality.Equal(TrialDays, other.TrialDays)
        && global::Meteroid.Equality.Equal(Version, other.Version)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(ActivationCondition));
        hash.Add(global::Meteroid.Equality.Hash(AddOns));
        hash.Add(global::Meteroid.Equality.Hash(AutoAdvanceInvoices));
        hash.Add(global::Meteroid.Equality.Hash(BackdateInvoices));
        hash.Add(global::Meteroid.Equality.Hash(BillingDayAnchor));
        hash.Add(global::Meteroid.Equality.Hash(ChargeAutomatically));
        hash.Add(global::Meteroid.Equality.Hash(CouponCodes));
        hash.Add(global::Meteroid.Equality.Hash(CustomProperties));
        hash.Add(global::Meteroid.Equality.Hash(CustomerIdOrAlias));
        hash.Add(global::Meteroid.Equality.Hash(EndDate));
        hash.Add(global::Meteroid.Equality.Hash(InvoiceMemo));
        hash.Add(global::Meteroid.Equality.Hash(NetTerms));
        hash.Add(global::Meteroid.Equality.Hash(PaymentMethodsConfig));
        hash.Add(global::Meteroid.Equality.Hash(PlanId));
        hash.Add(global::Meteroid.Equality.Hash(PriceComponents));
        hash.Add(global::Meteroid.Equality.Hash(PurchaseOrder));
        hash.Add(global::Meteroid.Equality.Hash(SkipPastInvoices));
        hash.Add(global::Meteroid.Equality.Hash(StartDate));
        hash.Add(global::Meteroid.Equality.Hash(TrialDays));
        hash.Add(global::Meteroid.Equality.Hash(Version));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
