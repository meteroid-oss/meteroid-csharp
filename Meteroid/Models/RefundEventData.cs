// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// A refund row, or the payment that failed or was clawed back — the same shape the REST invoice
/// exposes as a transaction. <c>reversal_reason</c> is deliberately absent: it is free provider text and is
/// not carried on the outbox event.
/// </summary>
public sealed partial record RefundEventData
{
    /// <summary>The <c>amount</c> property.</summary>
    [JsonPropertyName("amount")]
    public required long Amount { get; init; }

    /// <summary>The <c>amount_refunded</c> property.</summary>
    [JsonPropertyName("amount_refunded")]
    public required long AmountRefunded { get; init; }

    /// <summary>The <c>amount_reversed</c> property.</summary>
    [JsonPropertyName("amount_reversed")]
    public required long AmountReversed { get; init; }

    /// <summary>The <c>credit_note_id</c> property.</summary>
    [JsonPropertyName("credit_note_id")]
    public string? CreditNoteId { get; init; }

    /// <summary>The <c>currency</c> property.</summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>The <c>decline_kind</c> property.</summary>
    [JsonPropertyName("decline_kind")]
    public DeclineKind? DeclineKind { get; init; }

    /// <summary>The <c>error</c> property.</summary>
    [JsonPropertyName("error")]
    public string? Error { get; init; }

    /// <summary>The <c>invoice_id</c> property.</summary>
    [JsonPropertyName("invoice_id")]
    public string? InvoiceId { get; init; }

    /// <summary>The <c>parent_transaction_id</c> property.</summary>
    [JsonPropertyName("parent_transaction_id")]
    public string? ParentTransactionId { get; init; }

    /// <summary>The <c>payment_type</c> property.</summary>
    [JsonPropertyName("payment_type")]
    public required PaymentTypeEnum PaymentType { get; init; }

    /// <summary>The <c>processed_at</c> property.</summary>
    [JsonPropertyName("processed_at")]
    public DateTimeOffset? ProcessedAt { get; init; }

    /// <summary>The <c>provider_transaction_id</c> property.</summary>
    [JsonPropertyName("provider_transaction_id")]
    public string? ProviderTransactionId { get; init; }

    /// <summary>The <c>refund_mode</c> property.</summary>
    [JsonPropertyName("refund_mode")]
    public RefundMode? RefundMode { get; init; }

    /// <summary>The <c>reversal_kind</c> property.</summary>
    [JsonPropertyName("reversal_kind")]
    public ReversalKind? ReversalKind { get; init; }

    /// <summary>The <c>status</c> property.</summary>
    [JsonPropertyName("status")]
    public required PaymentStatusEnum Status { get; init; }

    /// <summary>The <c>transaction_id</c> property.</summary>
    [JsonPropertyName("transaction_id")]
    public required string TransactionId { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(RefundEventData? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Amount, other.Amount)
        && global::Meteroid.Equality.Equal(AmountRefunded, other.AmountRefunded)
        && global::Meteroid.Equality.Equal(AmountReversed, other.AmountReversed)
        && global::Meteroid.Equality.Equal(CreditNoteId, other.CreditNoteId)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(DeclineKind, other.DeclineKind)
        && global::Meteroid.Equality.Equal(Error, other.Error)
        && global::Meteroid.Equality.Equal(InvoiceId, other.InvoiceId)
        && global::Meteroid.Equality.Equal(ParentTransactionId, other.ParentTransactionId)
        && global::Meteroid.Equality.Equal(PaymentType, other.PaymentType)
        && global::Meteroid.Equality.Equal(ProcessedAt, other.ProcessedAt)
        && global::Meteroid.Equality.Equal(ProviderTransactionId, other.ProviderTransactionId)
        && global::Meteroid.Equality.Equal(RefundMode, other.RefundMode)
        && global::Meteroid.Equality.Equal(ReversalKind, other.ReversalKind)
        && global::Meteroid.Equality.Equal(Status, other.Status)
        && global::Meteroid.Equality.Equal(TransactionId, other.TransactionId)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Amount));
        hash.Add(global::Meteroid.Equality.Hash(AmountRefunded));
        hash.Add(global::Meteroid.Equality.Hash(AmountReversed));
        hash.Add(global::Meteroid.Equality.Hash(CreditNoteId));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(DeclineKind));
        hash.Add(global::Meteroid.Equality.Hash(Error));
        hash.Add(global::Meteroid.Equality.Hash(InvoiceId));
        hash.Add(global::Meteroid.Equality.Hash(ParentTransactionId));
        hash.Add(global::Meteroid.Equality.Hash(PaymentType));
        hash.Add(global::Meteroid.Equality.Hash(ProcessedAt));
        hash.Add(global::Meteroid.Equality.Hash(ProviderTransactionId));
        hash.Add(global::Meteroid.Equality.Hash(RefundMode));
        hash.Add(global::Meteroid.Equality.Hash(ReversalKind));
        hash.Add(global::Meteroid.Equality.Hash(Status));
        hash.Add(global::Meteroid.Equality.Hash(TransactionId));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
