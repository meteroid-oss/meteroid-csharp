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
/// Whether a customer may keep consuming what their prepaid credit pays for.
/// </summary>
public sealed partial record WalletCheck
{
    /// <summary>
    /// When <c>balance</c> was computed.
    /// </summary>
    [JsonPropertyName("as_of")]
    public required DateTimeOffset AsOf { get; init; }

    /// <summary>
    /// The balance: credit on account net of the usage not invoiced yet that it will pay, in
    /// minor units of <c>currency</c> or <c>credit_unit</c>; never negative for the customer as a whole,
    /// as <c>balance</c> of <c>GET /wallets</c>. With <c>product_id</c>, only the credit that can pay for that
    /// product, net of its usage no credit covers. With <c>subscription_id</c>, only the credit that
    /// subscription can spend (credit restricted to products it is not charged for left out),
    /// net of its usage no credit covers; credit that belongs to no subscription counts in every
    /// subscription's balance (see <c>shared_balance</c>).
    /// </summary>
    [JsonPropertyName("balance")]
    public required long Balance { get; init; }

    /// <summary>
    /// The credit unit (its code) checked; absent for a currency.
    /// </summary>
    [JsonPropertyName("credit_unit")]
    public string? CreditUnit { get; init; }

    /// <summary>
    /// Decimal places of <c>credit_unit</c>: <c>balance</c> is in integers of 10^-precision credit.
    /// </summary>
    [JsonPropertyName("credit_unit_precision")]
    public int? CreditUnitPrecision { get; init; }

    /// <summary>The <c>currency</c> property.</summary>
    [JsonPropertyName("currency")]
    public Currency? Currency { get; init; }

    /// <summary>
    /// Always false: <c>balance</c> may lag usage by a few seconds (see <c>as_of</c>), and the answer is
    /// cached for one second.
    /// </summary>
    [JsonPropertyName("exact")]
    public required bool Exact { get; init; }

    /// <summary>
    /// True once <c>balance</c> is at or below zero, or, with <c>subscription_id</c>, once no credit is
    /// left for some of its usage. Independent of <c>has_access</c>: a wallet that allows overage
    /// still reports this, so the caller can warn without refusing.
    /// </summary>
    [JsonPropertyName("exhausted")]
    public required bool Exhausted { get; init; }

    /// <summary>
    /// False only once <c>balance</c> is at or below zero and <c>blocks_when_exhausted</c> is true.
    /// Customers without a wallet in <c>currency</c> do not prepay, and always have access. With
    /// <c>subscription_id</c>: false when <c>blocks_when_exhausted</c> is true and no credit that
    /// subscription can spend is left for some of its usage (of <c>product_id</c> when given), as the
    /// access gate refuses it; a subscription charged no usage in the wallet keeps access.
    /// </summary>
    [JsonPropertyName("has_access")]
    public required bool HasAccess { get; init; }

    /// <summary>
    /// Age of <c>balance</c>, in milliseconds.
    /// </summary>
    [JsonPropertyName("lag_ms")]
    public required long LagMs { get; init; }

    /// <summary>
    /// Whether usage is refused as soon as the credit is used up: the wallet's <c>usage_at_zero</c>,
    /// else the plan of the subscription checked (of any active subscription without one). A plan
    /// that invoices usage up to a cap refuses it past the cap only, as <c>has_access</c> reports.
    /// </summary>
    [JsonPropertyName("pauses_at_zero")]
    public required bool PausesAtZero { get; init; }

    /// <summary>
    /// With <c>subscription_id</c> only: the part of <c>balance</c> that belongs to no subscription, which
    /// the customer's other subscriptions can spend too.
    /// </summary>
    [JsonPropertyName("shared_balance")]
    public long? SharedBalance { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(WalletCheck? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(AsOf, other.AsOf)
        && global::Meteroid.Equality.Equal(Balance, other.Balance)
        && global::Meteroid.Equality.Equal(CreditUnit, other.CreditUnit)
        && global::Meteroid.Equality.Equal(CreditUnitPrecision, other.CreditUnitPrecision)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(Exact, other.Exact)
        && global::Meteroid.Equality.Equal(Exhausted, other.Exhausted)
        && global::Meteroid.Equality.Equal(HasAccess, other.HasAccess)
        && global::Meteroid.Equality.Equal(LagMs, other.LagMs)
        && global::Meteroid.Equality.Equal(PausesAtZero, other.PausesAtZero)
        && global::Meteroid.Equality.Equal(SharedBalance, other.SharedBalance)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(AsOf));
        hash.Add(global::Meteroid.Equality.Hash(Balance));
        hash.Add(global::Meteroid.Equality.Hash(CreditUnit));
        hash.Add(global::Meteroid.Equality.Hash(CreditUnitPrecision));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(Exact));
        hash.Add(global::Meteroid.Equality.Hash(Exhausted));
        hash.Add(global::Meteroid.Equality.Hash(HasAccess));
        hash.Add(global::Meteroid.Equality.Hash(LagMs));
        hash.Add(global::Meteroid.Equality.Hash(PausesAtZero));
        hash.Add(global::Meteroid.Equality.Hash(SharedBalance));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
