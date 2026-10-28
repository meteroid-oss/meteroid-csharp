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
/// Credit left a customer's wallet.
/// </summary>
public sealed partial record WalletDebitedEventData
{
    /// <summary>The <c>actor</c> property.</summary>
    [JsonPropertyName("actor")]
    public Actor? Actor { get; init; }

    /// <summary>
    /// In minor units of <c>currency</c> or <c>credit_unit</c>.
    /// </summary>
    [JsonPropertyName("amount")]
    public required long Amount { get; init; }

    /// <summary>
    /// The products whose charges the grant pays; empty when it pays every product.
    /// </summary>
    [JsonPropertyName("applicable_product_ids")]
    public required IReadOnlyList<string> ApplicableProductIds { get; init; }

    /// <summary>
    /// What the grant pays: ALL any charge, USAGE only usage charges.
    /// </summary>
    [JsonPropertyName("applies_to")]
    public required CreditAppliesTo AppliesTo { get; init; }

    /// <summary>
    /// The grant the credit left.
    /// </summary>
    [JsonPropertyName("credit_grant_id")]
    public required string CreditGrantId { get; init; }

    /// <summary>The <c>credit_note_id</c> property.</summary>
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

    /// <summary>
    /// The credit ledger entry recording the movement.
    /// </summary>
    [JsonPropertyName("ledger_entry_id")]
    public required string LedgerEntryId { get; init; }

    /// <summary>
    /// Why the credit moved, as shown on the ledger.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; init; }

    /// <summary>
    /// The subscription the grant belongs to: it pays only that subscription's charges. Null when
    /// it pays any of the customer's subscriptions.
    /// </summary>
    [JsonPropertyName("subscription_id")]
    public string? SubscriptionId { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(WalletDebitedEventData? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Actor, other.Actor)
        && global::Meteroid.Equality.Equal(Amount, other.Amount)
        && global::Meteroid.Equality.Equal(ApplicableProductIds, other.ApplicableProductIds)
        && global::Meteroid.Equality.Equal(AppliesTo, other.AppliesTo)
        && global::Meteroid.Equality.Equal(CreditGrantId, other.CreditGrantId)
        && global::Meteroid.Equality.Equal(CreditNoteId, other.CreditNoteId)
        && global::Meteroid.Equality.Equal(CreditUnit, other.CreditUnit)
        && global::Meteroid.Equality.Equal(CreditUnitPrecision, other.CreditUnitPrecision)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(CustomerId, other.CustomerId)
        && global::Meteroid.Equality.Equal(InvoiceId, other.InvoiceId)
        && global::Meteroid.Equality.Equal(LedgerEntryId, other.LedgerEntryId)
        && global::Meteroid.Equality.Equal(Reason, other.Reason)
        && global::Meteroid.Equality.Equal(SubscriptionId, other.SubscriptionId)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Actor));
        hash.Add(global::Meteroid.Equality.Hash(Amount));
        hash.Add(global::Meteroid.Equality.Hash(ApplicableProductIds));
        hash.Add(global::Meteroid.Equality.Hash(AppliesTo));
        hash.Add(global::Meteroid.Equality.Hash(CreditGrantId));
        hash.Add(global::Meteroid.Equality.Hash(CreditNoteId));
        hash.Add(global::Meteroid.Equality.Hash(CreditUnit));
        hash.Add(global::Meteroid.Equality.Hash(CreditUnitPrecision));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(CustomerId));
        hash.Add(global::Meteroid.Equality.Hash(InvoiceId));
        hash.Add(global::Meteroid.Equality.Hash(LedgerEntryId));
        hash.Add(global::Meteroid.Equality.Hash(Reason));
        hash.Add(global::Meteroid.Equality.Hash(SubscriptionId));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
