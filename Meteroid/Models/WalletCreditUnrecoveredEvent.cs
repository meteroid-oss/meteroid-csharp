// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>WalletCreditUnrecoveredEvent</c> object.</summary>
public sealed partial record WalletCreditUnrecoveredEvent
{
    /// <summary>
    /// <c>PAYMENT_DISPUTED</c> (lost to a dispute or chargeback), <c>PAYMENT_REVERSED</c> (a failed
    /// collection clawed back), <c>PAYMENT_REFUNDED</c> (a payment refunded without a credit note, at
    /// the provider or as an overpayment, after the credit it backed was spent) or
    /// <c>CREDIT_NOTE_REFUNDED</c>.
    /// </summary>
    [JsonPropertyName("cause")]
    public required string Cause { get; init; }

    /// <summary>The <c>credit_note_id</c> property.</summary>
    [JsonPropertyName("credit_note_id")]
    public string? CreditNoteId { get; init; }

    /// <summary>
    /// Unspent credit taken back from the wallet at the same time, in minor units.
    /// </summary>
    [JsonPropertyName("credit_taken_back")]
    public required long CreditTakenBack { get; init; }

    /// <summary>
    /// The credit unit (its code) the amounts are in; absent for a currency.
    /// </summary>
    [JsonPropertyName("credit_unit")]
    public string? CreditUnit { get; init; }

    /// <summary>
    /// Decimal places of <c>credit_unit</c>: amounts are integers of 10^-precision credit.
    /// </summary>
    [JsonPropertyName("credit_unit_precision")]
    public int? CreditUnitPrecision { get; init; }

    /// <summary>
    /// Spent credit this event adds to the loss, in minor units. A failed collection reopens its
    /// invoice, which collects it again; a dispute's loss stays unless the dispute is won.
    /// <c>wallet.credit_recovered</c> reports what comes back.
    /// </summary>
    [JsonPropertyName("credit_unrecovered")]
    public required long CreditUnrecovered { get; init; }

    /// <summary>
    /// The loss of this money flow (an invoice's payments, a credit note, or a payment) once
    /// this event applies.
    /// </summary>
    [JsonPropertyName("credit_unrecovered_total")]
    public required long CreditUnrecoveredTotal { get; init; }

    /// <summary>
    /// Absent when the amounts are in a credit unit.
    /// </summary>
    [JsonPropertyName("currency")]
    public string? Currency { get; init; }

    /// <summary>The <c>customer_id</c> property.</summary>
    [JsonPropertyName("customer_id")]
    public required string CustomerId { get; init; }

    /// <summary>The <c>invoice_id</c> property.</summary>
    [JsonPropertyName("invoice_id")]
    public string? InvoiceId { get; init; }

    /// <summary>The <c>payment_id</c> property.</summary>
    [JsonPropertyName("payment_id")]
    public string? PaymentId { get; init; }

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
    public bool Equals(WalletCreditUnrecoveredEvent? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Cause, other.Cause)
        && global::Meteroid.Equality.Equal(CreditNoteId, other.CreditNoteId)
        && global::Meteroid.Equality.Equal(CreditTakenBack, other.CreditTakenBack)
        && global::Meteroid.Equality.Equal(CreditUnit, other.CreditUnit)
        && global::Meteroid.Equality.Equal(CreditUnitPrecision, other.CreditUnitPrecision)
        && global::Meteroid.Equality.Equal(CreditUnrecovered, other.CreditUnrecovered)
        && global::Meteroid.Equality.Equal(CreditUnrecoveredTotal, other.CreditUnrecoveredTotal)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(CustomerId, other.CustomerId)
        && global::Meteroid.Equality.Equal(InvoiceId, other.InvoiceId)
        && global::Meteroid.Equality.Equal(PaymentId, other.PaymentId)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(Timestamp, other.Timestamp)
        && global::Meteroid.Equality.Equal(Type, other.Type)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Cause));
        hash.Add(global::Meteroid.Equality.Hash(CreditNoteId));
        hash.Add(global::Meteroid.Equality.Hash(CreditTakenBack));
        hash.Add(global::Meteroid.Equality.Hash(CreditUnit));
        hash.Add(global::Meteroid.Equality.Hash(CreditUnitPrecision));
        hash.Add(global::Meteroid.Equality.Hash(CreditUnrecovered));
        hash.Add(global::Meteroid.Equality.Hash(CreditUnrecoveredTotal));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(CustomerId));
        hash.Add(global::Meteroid.Equality.Hash(InvoiceId));
        hash.Add(global::Meteroid.Equality.Hash(PaymentId));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(Timestamp));
        hash.Add(global::Meteroid.Equality.Hash(Type));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
