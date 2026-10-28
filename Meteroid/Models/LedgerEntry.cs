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
/// One movement of a customer's credit.
/// </summary>
public sealed partial record LedgerEntry
{
    /// <summary>
    /// Signed change to the credit on account, in minor units.
    /// </summary>
    [JsonPropertyName("amount")]
    public required long Amount { get; init; }

    /// <summary>
    /// What the moved credit's grant pays: ALL any charge, USAGE only usage charges.
    /// </summary>
    [JsonPropertyName("applies_to")]
    public required CreditAppliesTo AppliesTo { get; init; }

    /// <summary>
    /// The credit on account after this entry, whatever it applies to.
    /// </summary>
    [JsonPropertyName("balance_after")]
    public required long BalanceAfter { get; init; }

    /// <summary>The <c>cost</c> property.</summary>
    [JsonPropertyName("cost")]
    public CreditCost? Cost { get; init; }

    /// <summary>
    /// The grant the credit moved in or out of.
    /// </summary>
    [JsonPropertyName("credit_grant_id")]
    public required string CreditGrantId { get; init; }

    /// <summary>
    /// The credit note that gave the credit back or took it back.
    /// </summary>
    [JsonPropertyName("credit_note_id")]
    public string? CreditNoteId { get; init; }

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

    /// <summary>The <c>currency</c> property.</summary>
    [JsonPropertyName("currency")]
    public Currency? Currency { get; init; }

    /// <summary>
    /// When the movement took effect; the ledger is ordered by it.
    /// </summary>
    [JsonPropertyName("effective_at")]
    public required DateTimeOffset EffectiveAt { get; init; }

    /// <summary>
    /// The entry's id (<c>wle_…</c>).
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The invoice the credit was applied to, bought on, or given back by.
    /// </summary>
    [JsonPropertyName("invoice_id")]
    public string? InvoiceId { get; init; }

    /// <summary>
    /// Why the credit moved, as shown on the ledger.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; init; }

    /// <summary>
    /// When the movement was recorded.
    /// </summary>
    [JsonPropertyName("recorded_at")]
    public required DateTimeOffset RecordedAt { get; init; }

    /// <summary>
    /// Your own reference, e.g. a contract or support ticket.
    /// </summary>
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    /// <summary>
    /// Position within the currency's ledger in the order the movements took effect, from 1. A
    /// movement recorded later with an earlier date shifts the positions after it: identify an
    /// entry by its <c>id</c>.
    /// </summary>
    [JsonPropertyName("sequence")]
    public required long Sequence { get; init; }

    /// <summary>
    /// The subscription the moved credit's grant belongs to; null when it pays any of the
    /// customer's subscriptions.
    /// </summary>
    [JsonPropertyName("subscription_id")]
    public string? SubscriptionId { get; init; }

    /// <summary>
    /// What moved the credit.
    /// </summary>
    [JsonPropertyName("type")]
    public required LedgerEntryType Type { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(LedgerEntry? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Amount, other.Amount)
        && global::Meteroid.Equality.Equal(AppliesTo, other.AppliesTo)
        && global::Meteroid.Equality.Equal(BalanceAfter, other.BalanceAfter)
        && global::Meteroid.Equality.Equal(Cost, other.Cost)
        && global::Meteroid.Equality.Equal(CreditGrantId, other.CreditGrantId)
        && global::Meteroid.Equality.Equal(CreditNoteId, other.CreditNoteId)
        && global::Meteroid.Equality.Equal(CreditUnit, other.CreditUnit)
        && global::Meteroid.Equality.Equal(CreditUnitPrecision, other.CreditUnitPrecision)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(EffectiveAt, other.EffectiveAt)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(InvoiceId, other.InvoiceId)
        && global::Meteroid.Equality.Equal(Reason, other.Reason)
        && global::Meteroid.Equality.Equal(RecordedAt, other.RecordedAt)
        && global::Meteroid.Equality.Equal(Reference, other.Reference)
        && global::Meteroid.Equality.Equal(Sequence, other.Sequence)
        && global::Meteroid.Equality.Equal(SubscriptionId, other.SubscriptionId)
        && global::Meteroid.Equality.Equal(Type, other.Type)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Amount));
        hash.Add(global::Meteroid.Equality.Hash(AppliesTo));
        hash.Add(global::Meteroid.Equality.Hash(BalanceAfter));
        hash.Add(global::Meteroid.Equality.Hash(Cost));
        hash.Add(global::Meteroid.Equality.Hash(CreditGrantId));
        hash.Add(global::Meteroid.Equality.Hash(CreditNoteId));
        hash.Add(global::Meteroid.Equality.Hash(CreditUnit));
        hash.Add(global::Meteroid.Equality.Hash(CreditUnitPrecision));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(EffectiveAt));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(InvoiceId));
        hash.Add(global::Meteroid.Equality.Hash(Reason));
        hash.Add(global::Meteroid.Equality.Hash(RecordedAt));
        hash.Add(global::Meteroid.Equality.Hash(Reference));
        hash.Add(global::Meteroid.Equality.Hash(Sequence));
        hash.Add(global::Meteroid.Equality.Hash(SubscriptionId));
        hash.Add(global::Meteroid.Equality.Hash(Type));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
