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
/// A customer's credit in one currency or credit unit. Amounts are minor units of it. Read with
/// <c>subscription_id</c>, every amount counts only the credit that subscription can use.
/// </summary>
public sealed partial record Wallet
{
    /// <summary>
    /// When <c>balance</c> and <c>unbilled_usage</c> were computed. They follow usage within a few seconds
    /// while the balance is near zero or a threshold, and within a minute otherwise.
    /// </summary>
    [JsonPropertyName("as_of")]
    public DateTimeOffset? AsOf { get; init; }

    /// <summary>The <c>auto_top_up</c> property.</summary>
    [JsonPropertyName("auto_top_up")]
    public AutoTopUp? AutoTopUp { get; init; }

    /// <summary>
    /// What the customer has left: <c>credit_on_account</c> minus the part of <c>unbilled_usage</c> that
    /// credit will pay. Never negative: usage beyond the credit stays in <c>unbilled_usage</c>, to be
    /// invoiced. Low-balance alerts use it; automatic top-ups watch only its part that pays any
    /// charge (credit that belongs to no subscription and is not limited to usage or products).
    /// Absent, with <c>unbilled_usage</c> and <c>as_of</c>, until the customer's usage has been priced once.
    /// With <c>subscription_id</c>: the credit that subscription can spend once every subscription's
    /// unbilled usage is paid, minus its own unbilled usage no credit pays (negative then), as
    /// <c>GET /wallets/check</c> reads it. Credit restricted to products it is not charged for is
    /// left out. Credit that belongs to no subscription counts in the balance of every
    /// subscription that can use it (see <c>shared_balance</c>): never add subscriptions' balances up.
    /// </summary>
    [JsonPropertyName("balance")]
    public long? Balance { get; init; }

    /// <summary>
    /// The ledger total: credit granted and effective, not yet applied to an invoice or expired,
    /// whatever it applies to. Usage not invoiced yet is not deducted (see <c>balance</c>).
    /// </summary>
    [JsonPropertyName("credit_on_account")]
    public required long CreditOnAccount { get; init; }

    /// <summary>
    /// The part of <c>credit_on_account</c> that pays only usage charges.
    /// </summary>
    [JsonPropertyName("credit_on_account_usage_only")]
    public required long CreditOnAccountUsageOnly { get; init; }

    /// <summary>
    /// The credit unit (its code) the wallet holds; absent for a currency.
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
    /// Ascending, distinct, at most 5. <c>wallet.balance_low</c> fires once when <c>balance</c> falls below
    /// one; a drop below several at once fires once, for the lowest. All credit counts, including
    /// credit that belongs to a subscription or is limited to usage or products, which
    /// <c>wallet.depleted</c> leaves out: a wallet can be depleted without an alert firing.
    /// </summary>
    [JsonPropertyName("low_balance_thresholds")]
    public required IReadOnlyList<long> LowBalanceThresholds { get; init; }

    /// <summary>
    /// Usage stops as soon as the credit is used up, for at least one active subscription: by
    /// <c>usage_at_zero</c>, or by the plan of a subscription charging usage in this wallet.
    /// </summary>
    [JsonPropertyName("pauses_at_zero")]
    public required bool PausesAtZero { get; init; }

    /// <summary>
    /// With <c>subscription_id</c> only: the part of <c>balance</c> that belongs to no subscription, which
    /// the customer's other subscriptions can spend too.
    /// </summary>
    [JsonPropertyName("shared_balance")]
    public long? SharedBalance { get; init; }

    /// <summary>
    /// The part of <c>credit_on_account</c> that belongs to a subscription, which only that
    /// subscription's charges can use, per subscription. The rest pays any subscription.
    /// </summary>
    [JsonPropertyName("subscription_credit")]
    public required IReadOnlyList<SubscriptionCredit> SubscriptionCredit { get; init; }

    /// <summary>
    /// Usage recorded and priced but not invoiced yet, tax included, in minor units: what the
    /// next invoices will charge for it, paid from credit as far as the credit goes. With
    /// <c>subscription_id</c>, that subscription's usage only; other subscriptions' usage paid from
    /// shared credit still lowers <c>balance</c>.
    /// </summary>
    [JsonPropertyName("unbilled_usage")]
    public long? UnbilledUsage { get; init; }

    /// <summary>
    /// Credit unit wallets: the price this customer agreed for one credit, in major units of
    /// <c>unit_price_currency</c>, as a decimal string (e.g. "0.0008"). Purchases and automatic
    /// top-ups in that currency charge it instead of the list price, unless a purchase sets its
    /// own <c>unit_price</c>. Absent: the list price applies.
    /// </summary>
    [JsonPropertyName("unit_price")]
    public string? UnitPrice { get; init; }

    /// <summary>The <c>unit_price_currency</c> property.</summary>
    [JsonPropertyName("unit_price_currency")]
    public Currency? UnitPriceCurrency { get; init; }

    /// <summary>
    /// Credit granted that takes effect later.
    /// </summary>
    [JsonPropertyName("upcoming_credit")]
    public required long UpcomingCredit { get; init; }

    /// <summary>
    /// What this customer's usage does once the credit a subscription can use for it is used up
    /// (its own credit, credit that belongs to no subscription, and credit limited to the product:
    /// the <c>balance</c> of <c>GET /wallets/check</c>). <c>FOLLOW_PLAN</c> applies the "when credit runs out"
    /// rule of each subscription's plan.
    /// </summary>
    [JsonPropertyName("usage_at_zero")]
    public required UsageAtZero UsageAtZero { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(Wallet? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(AsOf, other.AsOf)
        && global::Meteroid.Equality.Equal(AutoTopUp, other.AutoTopUp)
        && global::Meteroid.Equality.Equal(Balance, other.Balance)
        && global::Meteroid.Equality.Equal(CreditOnAccount, other.CreditOnAccount)
        && global::Meteroid.Equality.Equal(CreditOnAccountUsageOnly, other.CreditOnAccountUsageOnly)
        && global::Meteroid.Equality.Equal(CreditUnit, other.CreditUnit)
        && global::Meteroid.Equality.Equal(CreditUnitPrecision, other.CreditUnitPrecision)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(LowBalanceThresholds, other.LowBalanceThresholds)
        && global::Meteroid.Equality.Equal(PausesAtZero, other.PausesAtZero)
        && global::Meteroid.Equality.Equal(SharedBalance, other.SharedBalance)
        && global::Meteroid.Equality.Equal(SubscriptionCredit, other.SubscriptionCredit)
        && global::Meteroid.Equality.Equal(UnbilledUsage, other.UnbilledUsage)
        && global::Meteroid.Equality.Equal(UnitPrice, other.UnitPrice)
        && global::Meteroid.Equality.Equal(UnitPriceCurrency, other.UnitPriceCurrency)
        && global::Meteroid.Equality.Equal(UpcomingCredit, other.UpcomingCredit)
        && global::Meteroid.Equality.Equal(UsageAtZero, other.UsageAtZero)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(AsOf));
        hash.Add(global::Meteroid.Equality.Hash(AutoTopUp));
        hash.Add(global::Meteroid.Equality.Hash(Balance));
        hash.Add(global::Meteroid.Equality.Hash(CreditOnAccount));
        hash.Add(global::Meteroid.Equality.Hash(CreditOnAccountUsageOnly));
        hash.Add(global::Meteroid.Equality.Hash(CreditUnit));
        hash.Add(global::Meteroid.Equality.Hash(CreditUnitPrecision));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(LowBalanceThresholds));
        hash.Add(global::Meteroid.Equality.Hash(PausesAtZero));
        hash.Add(global::Meteroid.Equality.Hash(SharedBalance));
        hash.Add(global::Meteroid.Equality.Hash(SubscriptionCredit));
        hash.Add(global::Meteroid.Equality.Hash(UnbilledUsage));
        hash.Add(global::Meteroid.Equality.Hash(UnitPrice));
        hash.Add(global::Meteroid.Equality.Hash(UnitPriceCurrency));
        hash.Add(global::Meteroid.Equality.Hash(UpcomingCredit));
        hash.Add(global::Meteroid.Equality.Hash(UsageAtZero));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
