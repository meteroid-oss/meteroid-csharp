// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>SubscriptionEventData</c> object.</summary>
public sealed partial record SubscriptionEventData
{
    /// <summary>The <c>activated_at</c> property.</summary>
    [JsonPropertyName("activated_at")]
    public DateTimeOffset? ActivatedAt { get; init; }

    /// <summary>The <c>auto_advance_invoices</c> property.</summary>
    [JsonPropertyName("auto_advance_invoices")]
    public required bool AutoAdvanceInvoices { get; init; }

    /// <summary>The <c>billing_day_anchor</c> property.</summary>
    [JsonPropertyName("billing_day_anchor")]
    public required int BillingDayAnchor { get; init; }

    /// <summary>The <c>billing_start_date</c> property.</summary>
    [JsonPropertyName("billing_start_date")]
    public DateOnly? BillingStartDate { get; init; }

    /// <summary>
    /// Present on <c>subscription.cancelled</c> when a reason was supplied.
    /// </summary>
    [JsonPropertyName("cancellation_reason")]
    public string? CancellationReason { get; init; }

    /// <summary>The <c>change_type</c> property.</summary>
    [JsonPropertyName("change_type")]
    public SubscriptionUpdateType? ChangeType { get; init; }

    /// <summary>The <c>charge_automatically</c> property.</summary>
    [JsonPropertyName("charge_automatically")]
    public required bool ChargeAutomatically { get; init; }

    /// <summary>The <c>created_at</c> property.</summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>The <c>currency</c> property.</summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>
    /// User-defined custom property values, keyed by definition key.
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

    /// <summary>The <c>end_date</c> property.</summary>
    [JsonPropertyName("end_date")]
    public DateOnly? EndDate { get; init; }

    /// <summary>The <c>invoice_memo</c> property.</summary>
    [JsonPropertyName("invoice_memo")]
    public string? InvoiceMemo { get; init; }

    /// <summary>The <c>invoice_threshold</c> property.</summary>
    [JsonPropertyName("invoice_threshold")]
    public string? InvoiceThreshold { get; init; }

    /// <summary>The <c>mrr_cents</c> property.</summary>
    [JsonPropertyName("mrr_cents")]
    public required long MrrCents { get; init; }

    /// <summary>The <c>net_terms</c> property.</summary>
    [JsonPropertyName("net_terms")]
    public required int NetTerms { get; init; }

    /// <summary>The <c>period</c> property.</summary>
    [JsonPropertyName("period")]
    public required BillingPeriodEnum Period { get; init; }

    /// <summary>The <c>plan_name</c> property.</summary>
    [JsonPropertyName("plan_name")]
    public required string PlanName { get; init; }

    /// <summary>The <c>purchase_order</c> property.</summary>
    [JsonPropertyName("purchase_order")]
    public string? PurchaseOrder { get; init; }

    /// <summary>The <c>start_date</c> property.</summary>
    [JsonPropertyName("start_date")]
    public required DateOnly StartDate { get; init; }

    /// <summary>The <c>status</c> property.</summary>
    [JsonPropertyName("status")]
    public required SubscriptionStatusEnum Status { get; init; }

    /// <summary>The <c>subscription_id</c> property.</summary>
    [JsonPropertyName("subscription_id")]
    public required string SubscriptionId { get; init; }

    /// <summary>The <c>trial_duration</c> property.</summary>
    [JsonPropertyName("trial_duration")]
    public int? TrialDuration { get; init; }

    /// <summary>The <c>version</c> property.</summary>
    [JsonPropertyName("version")]
    public required int Version { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(SubscriptionEventData? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(ActivatedAt, other.ActivatedAt)
        && global::Meteroid.Equality.Equal(AutoAdvanceInvoices, other.AutoAdvanceInvoices)
        && global::Meteroid.Equality.Equal(BillingDayAnchor, other.BillingDayAnchor)
        && global::Meteroid.Equality.Equal(BillingStartDate, other.BillingStartDate)
        && global::Meteroid.Equality.Equal(CancellationReason, other.CancellationReason)
        && global::Meteroid.Equality.Equal(ChangeType, other.ChangeType)
        && global::Meteroid.Equality.Equal(ChargeAutomatically, other.ChargeAutomatically)
        && global::Meteroid.Equality.Equal(CreatedAt, other.CreatedAt)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(CustomProperties, other.CustomProperties)
        && global::Meteroid.Equality.Equal(CustomerAlias, other.CustomerAlias)
        && global::Meteroid.Equality.Equal(CustomerId, other.CustomerId)
        && global::Meteroid.Equality.Equal(CustomerName, other.CustomerName)
        && global::Meteroid.Equality.Equal(EndDate, other.EndDate)
        && global::Meteroid.Equality.Equal(InvoiceMemo, other.InvoiceMemo)
        && global::Meteroid.Equality.Equal(InvoiceThreshold, other.InvoiceThreshold)
        && global::Meteroid.Equality.Equal(MrrCents, other.MrrCents)
        && global::Meteroid.Equality.Equal(NetTerms, other.NetTerms)
        && global::Meteroid.Equality.Equal(Period, other.Period)
        && global::Meteroid.Equality.Equal(PlanName, other.PlanName)
        && global::Meteroid.Equality.Equal(PurchaseOrder, other.PurchaseOrder)
        && global::Meteroid.Equality.Equal(StartDate, other.StartDate)
        && global::Meteroid.Equality.Equal(Status, other.Status)
        && global::Meteroid.Equality.Equal(SubscriptionId, other.SubscriptionId)
        && global::Meteroid.Equality.Equal(TrialDuration, other.TrialDuration)
        && global::Meteroid.Equality.Equal(Version, other.Version)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(ActivatedAt));
        hash.Add(global::Meteroid.Equality.Hash(AutoAdvanceInvoices));
        hash.Add(global::Meteroid.Equality.Hash(BillingDayAnchor));
        hash.Add(global::Meteroid.Equality.Hash(BillingStartDate));
        hash.Add(global::Meteroid.Equality.Hash(CancellationReason));
        hash.Add(global::Meteroid.Equality.Hash(ChangeType));
        hash.Add(global::Meteroid.Equality.Hash(ChargeAutomatically));
        hash.Add(global::Meteroid.Equality.Hash(CreatedAt));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(CustomProperties));
        hash.Add(global::Meteroid.Equality.Hash(CustomerAlias));
        hash.Add(global::Meteroid.Equality.Hash(CustomerId));
        hash.Add(global::Meteroid.Equality.Hash(CustomerName));
        hash.Add(global::Meteroid.Equality.Hash(EndDate));
        hash.Add(global::Meteroid.Equality.Hash(InvoiceMemo));
        hash.Add(global::Meteroid.Equality.Hash(InvoiceThreshold));
        hash.Add(global::Meteroid.Equality.Hash(MrrCents));
        hash.Add(global::Meteroid.Equality.Hash(NetTerms));
        hash.Add(global::Meteroid.Equality.Hash(Period));
        hash.Add(global::Meteroid.Equality.Hash(PlanName));
        hash.Add(global::Meteroid.Equality.Hash(PurchaseOrder));
        hash.Add(global::Meteroid.Equality.Hash(StartDate));
        hash.Add(global::Meteroid.Equality.Hash(Status));
        hash.Add(global::Meteroid.Equality.Hash(SubscriptionId));
        hash.Add(global::Meteroid.Equality.Hash(TrialDuration));
        hash.Add(global::Meteroid.Equality.Hash(Version));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
