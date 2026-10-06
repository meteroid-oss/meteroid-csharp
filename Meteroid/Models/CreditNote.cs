// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>CreditNote</c> object.</summary>
public sealed partial record CreditNote
{
    /// <summary>The <c>created_at</c> property.</summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>The <c>credit_note_number</c> property.</summary>
    [JsonPropertyName("credit_note_number")]
    public required string CreditNoteNumber { get; init; }

    /// <summary>The <c>credit_type</c> property.</summary>
    [JsonPropertyName("credit_type")]
    public required CreditType CreditType { get; init; }

    /// <summary>The <c>credited_amount_cents</c> property.</summary>
    [JsonPropertyName("credited_amount_cents")]
    public required long CreditedAmountCents { get; init; }

    /// <summary>The <c>currency</c> property.</summary>
    [JsonPropertyName("currency")]
    public required Currency Currency { get; init; }

    /// <summary>
    /// User-defined custom property values, keyed by definition <c>key</c>.
    /// </summary>
    [JsonPropertyName("custom_properties")]
    public required JsonNode CustomProperties { get; init; }

    /// <summary>The <c>customer_id</c> property.</summary>
    [JsonPropertyName("customer_id")]
    public required string CustomerId { get; init; }

    /// <summary>The <c>finalized_at</c> property.</summary>
    [JsonPropertyName("finalized_at")]
    public DateTimeOffset? FinalizedAt { get; init; }

    /// <summary>The <c>id</c> property.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>The <c>invoice_id</c> property.</summary>
    [JsonPropertyName("invoice_id")]
    public required string InvoiceId { get; init; }

    /// <summary>The <c>invoice_number</c> property.</summary>
    [JsonPropertyName("invoice_number")]
    public required string InvoiceNumber { get; init; }

    /// <summary>The <c>line_items</c> property.</summary>
    [JsonPropertyName("line_items")]
    public required IReadOnlyList<InvoiceLineItem> LineItems { get; init; }

    /// <summary>The <c>memo</c> property.</summary>
    [JsonPropertyName("memo")]
    public string? Memo { get; init; }

    /// <summary>The <c>plan_version_id</c> property.</summary>
    [JsonPropertyName("plan_version_id")]
    public string? PlanVersionId { get; init; }

    /// <summary>The <c>reason</c> property.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    /// <summary>The <c>refunded_amount_cents</c> property.</summary>
    [JsonPropertyName("refunded_amount_cents")]
    public required long RefundedAmountCents { get; init; }

    /// <summary>The <c>status</c> property.</summary>
    [JsonPropertyName("status")]
    public required CreditNoteStatus Status { get; init; }

    /// <summary>The <c>subscription_id</c> property.</summary>
    [JsonPropertyName("subscription_id")]
    public string? SubscriptionId { get; init; }

    /// <summary>The <c>subtotal</c> property.</summary>
    [JsonPropertyName("subtotal")]
    public required long Subtotal { get; init; }

    /// <summary>The <c>tax_amount</c> property.</summary>
    [JsonPropertyName("tax_amount")]
    public required long TaxAmount { get; init; }

    /// <summary>The <c>tax_breakdown</c> property.</summary>
    [JsonPropertyName("tax_breakdown")]
    public required IReadOnlyList<TaxBreakdownItem> TaxBreakdown { get; init; }

    /// <summary>The <c>total</c> property.</summary>
    [JsonPropertyName("total")]
    public required long Total { get; init; }

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
    public bool Equals(CreditNote? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(CreatedAt, other.CreatedAt)
        && global::Meteroid.Equality.Equal(CreditNoteNumber, other.CreditNoteNumber)
        && global::Meteroid.Equality.Equal(CreditType, other.CreditType)
        && global::Meteroid.Equality.Equal(CreditedAmountCents, other.CreditedAmountCents)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(CustomProperties, other.CustomProperties)
        && global::Meteroid.Equality.Equal(CustomerId, other.CustomerId)
        && global::Meteroid.Equality.Equal(FinalizedAt, other.FinalizedAt)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(InvoiceId, other.InvoiceId)
        && global::Meteroid.Equality.Equal(InvoiceNumber, other.InvoiceNumber)
        && global::Meteroid.Equality.Equal(LineItems, other.LineItems)
        && global::Meteroid.Equality.Equal(Memo, other.Memo)
        && global::Meteroid.Equality.Equal(PlanVersionId, other.PlanVersionId)
        && global::Meteroid.Equality.Equal(Reason, other.Reason)
        && global::Meteroid.Equality.Equal(RefundedAmountCents, other.RefundedAmountCents)
        && global::Meteroid.Equality.Equal(Status, other.Status)
        && global::Meteroid.Equality.Equal(SubscriptionId, other.SubscriptionId)
        && global::Meteroid.Equality.Equal(Subtotal, other.Subtotal)
        && global::Meteroid.Equality.Equal(TaxAmount, other.TaxAmount)
        && global::Meteroid.Equality.Equal(TaxBreakdown, other.TaxBreakdown)
        && global::Meteroid.Equality.Equal(Total, other.Total)
        && global::Meteroid.Equality.Equal(UpdatedAt, other.UpdatedAt)
        && global::Meteroid.Equality.Equal(VoidedAt, other.VoidedAt)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(CreatedAt));
        hash.Add(global::Meteroid.Equality.Hash(CreditNoteNumber));
        hash.Add(global::Meteroid.Equality.Hash(CreditType));
        hash.Add(global::Meteroid.Equality.Hash(CreditedAmountCents));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(CustomProperties));
        hash.Add(global::Meteroid.Equality.Hash(CustomerId));
        hash.Add(global::Meteroid.Equality.Hash(FinalizedAt));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(InvoiceId));
        hash.Add(global::Meteroid.Equality.Hash(InvoiceNumber));
        hash.Add(global::Meteroid.Equality.Hash(LineItems));
        hash.Add(global::Meteroid.Equality.Hash(Memo));
        hash.Add(global::Meteroid.Equality.Hash(PlanVersionId));
        hash.Add(global::Meteroid.Equality.Hash(Reason));
        hash.Add(global::Meteroid.Equality.Hash(RefundedAmountCents));
        hash.Add(global::Meteroid.Equality.Hash(Status));
        hash.Add(global::Meteroid.Equality.Hash(SubscriptionId));
        hash.Add(global::Meteroid.Equality.Hash(Subtotal));
        hash.Add(global::Meteroid.Equality.Hash(TaxAmount));
        hash.Add(global::Meteroid.Equality.Hash(TaxBreakdown));
        hash.Add(global::Meteroid.Equality.Hash(Total));
        hash.Add(global::Meteroid.Equality.Hash(UpdatedAt));
        hash.Add(global::Meteroid.Equality.Hash(VoidedAt));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
