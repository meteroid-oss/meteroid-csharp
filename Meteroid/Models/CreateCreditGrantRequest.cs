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
/// Credit granted without charging or invoicing.
/// </summary>
public sealed partial record CreateCreditGrantRequest
{
    /// <summary>
    /// Credit granted, in minor units of <c>currency</c>, or of <c>credit_unit</c> when set (e.g. 500000
    /// is 5,000.00 credits of a unit with precision 2). Positive.
    /// </summary>
    [JsonPropertyName("amount")]
    public required long Amount { get; init; }

    /// <summary>
    /// Restricts the credit to charges of these products; absent applies to every product.
    /// Combined with <c>applies_to</c>. Not available for credit units.
    /// </summary>
    [JsonPropertyName("applicable_product_ids")]
    public IReadOnlyList<string>? ApplicableProductIds { get; init; }

    /// <summary>
    /// ALL pays any charge on an invoice; USAGE only usage charges.
    /// </summary>
    [JsonPropertyName("applies_to")]
    public CreditAppliesTo? AppliesTo { get; init; }

    /// <summary>The <c>cost</c> property.</summary>
    [JsonPropertyName("cost")]
    public CreditCostRequest? Cost { get; init; }

    /// <summary>
    /// Grants in this credit unit (its code) instead of a currency; excludes <c>currency</c>. Credit in
    /// a credit unit pays the usage priced in that unit, so <c>applies_to</c> must stay ALL.
    /// </summary>
    [JsonPropertyName("credit_unit")]
    public string? CreditUnit { get; init; }

    /// <summary>The <c>currency</c> property.</summary>
    [JsonPropertyName("currency")]
    public Currency? Currency { get; init; }

    /// <summary>
    /// When unspent credit lapses; absent never expires.
    /// </summary>
    [JsonPropertyName("expires_at")]
    public DateTimeOffset? ExpiresAt { get; init; }

    /// <summary>
    /// Lower values are drawn first among grants of the same type that pay the same charges;
    /// defaults to 100.
    /// </summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; init; }

    /// <summary>
    /// Shown on the credit ledger.
    /// </summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    /// <summary>
    /// Your own reference, e.g. a contract or support ticket. Required for PAID credit that cost
    /// more than zero when the customer's invoicing entity is in France: the number of the invoice
    /// or receipt for the payment, as French law requires a supporting document for every
    /// accounting entry. Refused with 400 when missing.
    /// </summary>
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    /// <summary>
    /// The customer's subscription (<c>sub_…</c>) the credit belongs to: it pays only that
    /// subscription's charges and lapses when the subscription ends. It must not have ended,
    /// and its currency must be the grant's. Absent pays any of the customer's subscriptions.
    /// </summary>
    [JsonPropertyName("subscription_id")]
    public string? SubscriptionId { get; init; }

    /// <summary>
    /// PROMOTIONAL gives credit for free (a goodwill or marketing grant). PAID records credit
    /// the customer paid for outside of Meteroid: nothing is charged or invoiced, and the grant
    /// is shown as "Paid outside Meteroid". Usage paid with PAID currency credit is taxed on the
    /// invoice that bills it, so do not charge tax on the external sale of currency credit, or
    /// the customer is taxed twice. Credit in a credit unit is the exception: its usage is billed
    /// in credits, untaxed, so tax its sale as you would any other. Use a top-up to sell credit
    /// through Meteroid.
    /// </summary>
    [JsonPropertyName("type")]
    public required CreditGrantType Type { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(CreateCreditGrantRequest? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Amount, other.Amount)
        && global::Meteroid.Equality.Equal(ApplicableProductIds, other.ApplicableProductIds)
        && global::Meteroid.Equality.Equal(AppliesTo, other.AppliesTo)
        && global::Meteroid.Equality.Equal(Cost, other.Cost)
        && global::Meteroid.Equality.Equal(CreditUnit, other.CreditUnit)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(ExpiresAt, other.ExpiresAt)
        && global::Meteroid.Equality.Equal(Priority, other.Priority)
        && global::Meteroid.Equality.Equal(Reason, other.Reason)
        && global::Meteroid.Equality.Equal(Reference, other.Reference)
        && global::Meteroid.Equality.Equal(SubscriptionId, other.SubscriptionId)
        && global::Meteroid.Equality.Equal(Type, other.Type)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Amount));
        hash.Add(global::Meteroid.Equality.Hash(ApplicableProductIds));
        hash.Add(global::Meteroid.Equality.Hash(AppliesTo));
        hash.Add(global::Meteroid.Equality.Hash(Cost));
        hash.Add(global::Meteroid.Equality.Hash(CreditUnit));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(ExpiresAt));
        hash.Add(global::Meteroid.Equality.Hash(Priority));
        hash.Add(global::Meteroid.Equality.Hash(Reason));
        hash.Add(global::Meteroid.Equality.Hash(Reference));
        hash.Add(global::Meteroid.Equality.Hash(SubscriptionId));
        hash.Add(global::Meteroid.Equality.Hash(Type));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
