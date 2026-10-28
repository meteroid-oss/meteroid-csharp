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
/// A lot of credit given to or bought by a customer. An invoice applies promotional currency
/// credit before tax and paid credit after it. Within each, it draws the grants that belong to
/// the invoiced subscription first, then grants restricted to products (the fewest products
/// first), then usage-only grants, then the others; then by lowest <c>priority</c>, then the soonest
/// to lapse.
/// </summary>
public sealed partial record CreditGrant
{
    /// <summary>
    /// Amount granted, in minor units of <c>currency</c> or <c>credit_unit</c>.
    /// </summary>
    [JsonPropertyName("amount")]
    public required long Amount { get; init; }

    /// <summary>
    /// The products whose charges the credit pays, combined with <c>applies_to</c>; empty when it
    /// applies to every product.
    /// </summary>
    [JsonPropertyName("applicable_product_ids")]
    public required IReadOnlyList<string> ApplicableProductIds { get; init; }

    /// <summary>
    /// ALL pays any charge on an invoice; USAGE only usage charges.
    /// </summary>
    [JsonPropertyName("applies_to")]
    public required CreditAppliesTo AppliesTo { get; init; }

    /// <summary>
    /// Only on the response that created a PAID currency grant whose <c>cost</c> was below its
    /// amount: the PROMOTIONAL "Bonus credit" grant created beside it for the difference, with
    /// the same expiry, scope and priority.
    /// </summary>
    [JsonPropertyName("bonus_grant_id")]
    public string? BonusGrantId { get; init; }

    /// <summary>The <c>cost</c> property.</summary>
    [JsonPropertyName("cost")]
    public CreditCost? Cost { get; init; }

    /// <summary>
    /// <c>cost</c> per one major unit of credit, in major units of the cost currency (e.g. "0.008"),
    /// rounded to 12 decimal places, for display only.
    /// </summary>
    [JsonPropertyName("cost_basis")]
    public string? CostBasis { get; init; }

    /// <summary>
    /// When the grant was recorded.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// The credit note that gave the credit back.
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
    /// When the credit became spendable.
    /// </summary>
    [JsonPropertyName("effective_at")]
    public required DateTimeOffset EffectiveAt { get; init; }

    /// <summary>
    /// When the subscription the grant belongs to ended, if it ended. Unspent credit lapses then
    /// (status EXPIRED), even before <c>expires_at</c>.
    /// </summary>
    [JsonPropertyName("ended_at")]
    public DateTimeOffset? EndedAt { get; init; }

    /// <summary>
    /// Lost to expiry; present only on an expired grant.
    /// </summary>
    [JsonPropertyName("expired_amount")]
    public long? ExpiredAmount { get; init; }

    /// <summary>
    /// When unspent credit lapses; absent never expires.
    /// </summary>
    [JsonPropertyName("expires_at")]
    public DateTimeOffset? ExpiresAt { get; init; }

    /// <summary>
    /// The grant's id (<c>cgr_…</c>).
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The invoice that sold the credit, or whose void or negative total gave it back.
    /// </summary>
    [JsonPropertyName("invoice_id")]
    public string? InvoiceId { get; init; }

    /// <summary>
    /// The group the grant is shown in: INCLUDED, PREPAID, BONUS or ACCOUNT_BALANCE.
    /// </summary>
    [JsonPropertyName("kind")]
    public required CreditGrantKind Kind { get; init; }

    /// <summary>
    /// The group's name as Meteroid shows it: "Included with &lt;plan&gt;", "Purchased credit", "Free
    /// credit" or "Account balance".
    /// </summary>
    [JsonPropertyName("kind_label")]
    public required string KindLabel { get; init; }

    /// <summary>
    /// Lower values are drawn first among grants of the same type that pay the same charges; 100
    /// by default.
    /// </summary>
    [JsonPropertyName("priority")]
    public required int Priority { get; init; }

    /// <summary>
    /// Shown on the credit ledger.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; init; }

    /// <summary>
    /// Your own reference, e.g. a contract or support ticket.
    /// </summary>
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    /// <summary>
    /// Not spent yet, in the same minor units.
    /// </summary>
    [JsonPropertyName("remaining")]
    public required long Remaining { get; init; }

    /// <summary>
    /// Where the credit came from.
    /// </summary>
    [JsonPropertyName("source")]
    public required CreditGrantSource Source { get; init; }

    /// <summary>
    /// PENDING until <c>effective_at</c>, then ACTIVE, DEPLETED once spent, or EXPIRED.
    /// </summary>
    [JsonPropertyName("status")]
    public required CreditGrantStatus Status { get; init; }

    /// <summary>
    /// The subscription the grant belongs to (<c>sub_…</c>): it pays only that subscription's
    /// charges, and lapses when the subscription ends. Null when it pays any of the customer's
    /// subscriptions.
    /// </summary>
    [JsonPropertyName("subscription_id")]
    public string? SubscriptionId { get; init; }

    /// <summary>
    /// PAID or PROMOTIONAL: whether it applies after or before tax.
    /// </summary>
    [JsonPropertyName("type")]
    public required CreditGrantType Type { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(CreditGrant? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Amount, other.Amount)
        && global::Meteroid.Equality.Equal(ApplicableProductIds, other.ApplicableProductIds)
        && global::Meteroid.Equality.Equal(AppliesTo, other.AppliesTo)
        && global::Meteroid.Equality.Equal(BonusGrantId, other.BonusGrantId)
        && global::Meteroid.Equality.Equal(Cost, other.Cost)
        && global::Meteroid.Equality.Equal(CostBasis, other.CostBasis)
        && global::Meteroid.Equality.Equal(CreatedAt, other.CreatedAt)
        && global::Meteroid.Equality.Equal(CreditNoteId, other.CreditNoteId)
        && global::Meteroid.Equality.Equal(CreditUnit, other.CreditUnit)
        && global::Meteroid.Equality.Equal(CreditUnitPrecision, other.CreditUnitPrecision)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(EffectiveAt, other.EffectiveAt)
        && global::Meteroid.Equality.Equal(EndedAt, other.EndedAt)
        && global::Meteroid.Equality.Equal(ExpiredAmount, other.ExpiredAmount)
        && global::Meteroid.Equality.Equal(ExpiresAt, other.ExpiresAt)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(InvoiceId, other.InvoiceId)
        && global::Meteroid.Equality.Equal(Kind, other.Kind)
        && global::Meteroid.Equality.Equal(KindLabel, other.KindLabel)
        && global::Meteroid.Equality.Equal(Priority, other.Priority)
        && global::Meteroid.Equality.Equal(Reason, other.Reason)
        && global::Meteroid.Equality.Equal(Reference, other.Reference)
        && global::Meteroid.Equality.Equal(Remaining, other.Remaining)
        && global::Meteroid.Equality.Equal(Source, other.Source)
        && global::Meteroid.Equality.Equal(Status, other.Status)
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
        hash.Add(global::Meteroid.Equality.Hash(BonusGrantId));
        hash.Add(global::Meteroid.Equality.Hash(Cost));
        hash.Add(global::Meteroid.Equality.Hash(CostBasis));
        hash.Add(global::Meteroid.Equality.Hash(CreatedAt));
        hash.Add(global::Meteroid.Equality.Hash(CreditNoteId));
        hash.Add(global::Meteroid.Equality.Hash(CreditUnit));
        hash.Add(global::Meteroid.Equality.Hash(CreditUnitPrecision));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(EffectiveAt));
        hash.Add(global::Meteroid.Equality.Hash(EndedAt));
        hash.Add(global::Meteroid.Equality.Hash(ExpiredAmount));
        hash.Add(global::Meteroid.Equality.Hash(ExpiresAt));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(InvoiceId));
        hash.Add(global::Meteroid.Equality.Hash(Kind));
        hash.Add(global::Meteroid.Equality.Hash(KindLabel));
        hash.Add(global::Meteroid.Equality.Hash(Priority));
        hash.Add(global::Meteroid.Equality.Hash(Reason));
        hash.Add(global::Meteroid.Equality.Hash(Reference));
        hash.Add(global::Meteroid.Equality.Hash(Remaining));
        hash.Add(global::Meteroid.Equality.Hash(Source));
        hash.Add(global::Meteroid.Equality.Hash(Status));
        hash.Add(global::Meteroid.Equality.Hash(SubscriptionId));
        hash.Add(global::Meteroid.Equality.Hash(Type));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
