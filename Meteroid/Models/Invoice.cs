// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>Invoice</c> object.</summary>
public sealed partial record Invoice
{
    /// <summary>The <c>amount_due</c> property.</summary>
    [JsonPropertyName("amount_due")]
    public required long AmountDue { get; init; }

    /// <summary>The <c>applied_credits</c> property.</summary>
    [JsonPropertyName("applied_credits")]
    public required long AppliedCredits { get; init; }

    /// <summary>
    /// The period/moment this invoice is about — the subscription period start, or the invoice's
    /// own date for manual/one-off. Stable and always present, distinct from <c>invoice_date</c> (the
    /// emission date). Shown as "Invoice date".
    /// </summary>
    [JsonPropertyName("billing_period_start")]
    public DateOnly? BillingPeriodStart { get; init; }

    /// <summary>The <c>child_invoice_id</c> property.</summary>
    [JsonPropertyName("child_invoice_id")]
    public string? ChildInvoiceId { get; init; }

    /// <summary>The <c>coupons</c> property.</summary>
    [JsonPropertyName("coupons")]
    public required IReadOnlyList<CouponLineItem> Coupons { get; init; }

    /// <summary>The <c>created_at</c> property.</summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>The <c>currency</c> property.</summary>
    [JsonPropertyName("currency")]
    public required Currency Currency { get; init; }

    /// <summary>
    /// User-defined custom property values, keyed by definition <c>key</c>.
    /// </summary>
    [JsonPropertyName("custom_properties")]
    public required JsonNode CustomProperties { get; init; }

    /// <summary>The <c>customer_details</c> property.</summary>
    [JsonPropertyName("customer_details")]
    public required CustomerDetails CustomerDetails { get; init; }

    /// <summary>The <c>customer_id</c> property.</summary>
    [JsonPropertyName("customer_id")]
    public required string CustomerId { get; init; }

    /// <summary>The <c>due_date</c> property.</summary>
    [JsonPropertyName("due_date")]
    public DateOnly? DueDate { get; init; }

    /// <summary>The <c>einvoicing_status</c> property.</summary>
    [JsonPropertyName("einvoicing_status")]
    public EInvoicingStatus? EinvoicingStatus { get; init; }

    /// <summary>The <c>finalized_at</c> property.</summary>
    [JsonPropertyName("finalized_at")]
    public DateTimeOffset? FinalizedAt { get; init; }

    /// <summary>The <c>id</c> property.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>The <c>invoice_date</c> property.</summary>
    [JsonPropertyName("invoice_date")]
    public required DateOnly InvoiceDate { get; init; }

    /// <summary>The <c>invoice_number</c> property.</summary>
    [JsonPropertyName("invoice_number")]
    public required string InvoiceNumber { get; init; }

    /// <summary>The <c>invoice_type</c> property.</summary>
    [JsonPropertyName("invoice_type")]
    public required InvoiceType InvoiceType { get; init; }

    /// <summary>The <c>line_items</c> property.</summary>
    [JsonPropertyName("line_items")]
    public required IReadOnlyList<InvoiceLineItem> LineItems { get; init; }

    /// <summary>The <c>marked_as_uncollectible_at</c> property.</summary>
    [JsonPropertyName("marked_as_uncollectible_at")]
    public DateTimeOffset? MarkedAsUncollectibleAt { get; init; }

    /// <summary>The <c>memo</c> property.</summary>
    [JsonPropertyName("memo")]
    public string? Memo { get; init; }

    /// <summary>The <c>net_terms</c> property.</summary>
    [JsonPropertyName("net_terms")]
    public required int NetTerms { get; init; }

    /// <summary>The <c>paid_at</c> property.</summary>
    [JsonPropertyName("paid_at")]
    public DateTimeOffset? PaidAt { get; init; }

    /// <summary>The <c>parent_invoice_id</c> property.</summary>
    [JsonPropertyName("parent_invoice_id")]
    public string? ParentInvoiceId { get; init; }

    /// <summary>The <c>payment_status</c> property.</summary>
    [JsonPropertyName("payment_status")]
    public required InvoicePaymentStatus PaymentStatus { get; init; }

    /// <summary>The <c>purchase_order</c> property.</summary>
    [JsonPropertyName("purchase_order")]
    public string? PurchaseOrder { get; init; }

    /// <summary>The <c>reference</c> property.</summary>
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    /// <summary>The <c>status</c> property.</summary>
    [JsonPropertyName("status")]
    public required InvoiceStatus Status { get; init; }

    /// <summary>The <c>subscription_id</c> property.</summary>
    [JsonPropertyName("subscription_id")]
    public string? SubscriptionId { get; init; }

    /// <summary>The <c>subtotal</c> property.</summary>
    [JsonPropertyName("subtotal")]
    public required long Subtotal { get; init; }

    /// <summary>The <c>subtotal_recurring</c> property.</summary>
    [JsonPropertyName("subtotal_recurring")]
    public required long SubtotalRecurring { get; init; }

    /// <summary>The <c>tax_amount</c> property.</summary>
    [JsonPropertyName("tax_amount")]
    public required long TaxAmount { get; init; }

    /// <summary>The <c>tax_breakdown</c> property.</summary>
    [JsonPropertyName("tax_breakdown")]
    public required IReadOnlyList<TaxBreakdownItem> TaxBreakdown { get; init; }

    /// <summary>
    /// The prices billed were quoted tax-included. Amounts are net regardless: the tax was
    /// carved out of the quoted price, so <c>total</c> is that price to the unit.
    /// </summary>
    [JsonPropertyName("tax_inclusive")]
    public required bool TaxInclusive { get; init; }

    /// <summary>The <c>total</c> property.</summary>
    [JsonPropertyName("total")]
    public required long Total { get; init; }

    /// <summary>The <c>transactions</c> property.</summary>
    [JsonPropertyName("transactions")]
    public required IReadOnlyList<Transaction> Transactions { get; init; }

    /// <summary>The <c>updated_at</c> property.</summary>
    [JsonPropertyName("updated_at")]
    public DateTimeOffset? UpdatedAt { get; init; }

    /// <summary>The <c>voided_at</c> property.</summary>
    [JsonPropertyName("voided_at")]
    public DateTimeOffset? VoidedAt { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(Invoice? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(AmountDue, other.AmountDue)
        && global::Meteroid.Equality.Equal(AppliedCredits, other.AppliedCredits)
        && global::Meteroid.Equality.Equal(BillingPeriodStart, other.BillingPeriodStart)
        && global::Meteroid.Equality.Equal(ChildInvoiceId, other.ChildInvoiceId)
        && global::Meteroid.Equality.Equal(Coupons, other.Coupons)
        && global::Meteroid.Equality.Equal(CreatedAt, other.CreatedAt)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(CustomProperties, other.CustomProperties)
        && global::Meteroid.Equality.Equal(CustomerDetails, other.CustomerDetails)
        && global::Meteroid.Equality.Equal(CustomerId, other.CustomerId)
        && global::Meteroid.Equality.Equal(DueDate, other.DueDate)
        && global::Meteroid.Equality.Equal(EinvoicingStatus, other.EinvoicingStatus)
        && global::Meteroid.Equality.Equal(FinalizedAt, other.FinalizedAt)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(InvoiceDate, other.InvoiceDate)
        && global::Meteroid.Equality.Equal(InvoiceNumber, other.InvoiceNumber)
        && global::Meteroid.Equality.Equal(InvoiceType, other.InvoiceType)
        && global::Meteroid.Equality.Equal(LineItems, other.LineItems)
        && global::Meteroid.Equality.Equal(MarkedAsUncollectibleAt, other.MarkedAsUncollectibleAt)
        && global::Meteroid.Equality.Equal(Memo, other.Memo)
        && global::Meteroid.Equality.Equal(NetTerms, other.NetTerms)
        && global::Meteroid.Equality.Equal(PaidAt, other.PaidAt)
        && global::Meteroid.Equality.Equal(ParentInvoiceId, other.ParentInvoiceId)
        && global::Meteroid.Equality.Equal(PaymentStatus, other.PaymentStatus)
        && global::Meteroid.Equality.Equal(PurchaseOrder, other.PurchaseOrder)
        && global::Meteroid.Equality.Equal(Reference, other.Reference)
        && global::Meteroid.Equality.Equal(Status, other.Status)
        && global::Meteroid.Equality.Equal(SubscriptionId, other.SubscriptionId)
        && global::Meteroid.Equality.Equal(Subtotal, other.Subtotal)
        && global::Meteroid.Equality.Equal(SubtotalRecurring, other.SubtotalRecurring)
        && global::Meteroid.Equality.Equal(TaxAmount, other.TaxAmount)
        && global::Meteroid.Equality.Equal(TaxBreakdown, other.TaxBreakdown)
        && global::Meteroid.Equality.Equal(TaxInclusive, other.TaxInclusive)
        && global::Meteroid.Equality.Equal(Total, other.Total)
        && global::Meteroid.Equality.Equal(Transactions, other.Transactions)
        && global::Meteroid.Equality.Equal(UpdatedAt, other.UpdatedAt)
        && global::Meteroid.Equality.Equal(VoidedAt, other.VoidedAt)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(AmountDue));
        hash.Add(global::Meteroid.Equality.Hash(AppliedCredits));
        hash.Add(global::Meteroid.Equality.Hash(BillingPeriodStart));
        hash.Add(global::Meteroid.Equality.Hash(ChildInvoiceId));
        hash.Add(global::Meteroid.Equality.Hash(Coupons));
        hash.Add(global::Meteroid.Equality.Hash(CreatedAt));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(CustomProperties));
        hash.Add(global::Meteroid.Equality.Hash(CustomerDetails));
        hash.Add(global::Meteroid.Equality.Hash(CustomerId));
        hash.Add(global::Meteroid.Equality.Hash(DueDate));
        hash.Add(global::Meteroid.Equality.Hash(EinvoicingStatus));
        hash.Add(global::Meteroid.Equality.Hash(FinalizedAt));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(InvoiceDate));
        hash.Add(global::Meteroid.Equality.Hash(InvoiceNumber));
        hash.Add(global::Meteroid.Equality.Hash(InvoiceType));
        hash.Add(global::Meteroid.Equality.Hash(LineItems));
        hash.Add(global::Meteroid.Equality.Hash(MarkedAsUncollectibleAt));
        hash.Add(global::Meteroid.Equality.Hash(Memo));
        hash.Add(global::Meteroid.Equality.Hash(NetTerms));
        hash.Add(global::Meteroid.Equality.Hash(PaidAt));
        hash.Add(global::Meteroid.Equality.Hash(ParentInvoiceId));
        hash.Add(global::Meteroid.Equality.Hash(PaymentStatus));
        hash.Add(global::Meteroid.Equality.Hash(PurchaseOrder));
        hash.Add(global::Meteroid.Equality.Hash(Reference));
        hash.Add(global::Meteroid.Equality.Hash(Status));
        hash.Add(global::Meteroid.Equality.Hash(SubscriptionId));
        hash.Add(global::Meteroid.Equality.Hash(Subtotal));
        hash.Add(global::Meteroid.Equality.Hash(SubtotalRecurring));
        hash.Add(global::Meteroid.Equality.Hash(TaxAmount));
        hash.Add(global::Meteroid.Equality.Hash(TaxBreakdown));
        hash.Add(global::Meteroid.Equality.Hash(TaxInclusive));
        hash.Add(global::Meteroid.Equality.Hash(Total));
        hash.Add(global::Meteroid.Equality.Hash(Transactions));
        hash.Add(global::Meteroid.Equality.Hash(UpdatedAt));
        hash.Add(global::Meteroid.Equality.Hash(VoidedAt));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
