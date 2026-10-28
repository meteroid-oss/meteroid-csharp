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
/// Promotional credit added to the customer's credit balance when the subscription the coupon is
/// redeemed on starts. It never discounts an invoice and applies before tax. A customer redeems
/// it at most once, so the coupon cannot be <c>reusable</c>. Its code is case-insensitive: it is stored
/// upper-case and redeemed whatever the case.
/// </summary>
public sealed partial record CreditDiscount
{
    /// <summary>
    /// Credit added per redemption, in major units (e.g. "25.00").
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; init; }

    /// <summary>
    /// ISO 4217 code; it must match the currency of the subscription the coupon is redeemed on.
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>
    /// Days the credit stays spendable after redemption, 1 to 3660. Absent: it never expires.
    /// </summary>
    [JsonPropertyName("expires_in_days")]
    public int? ExpiresInDays { get; init; }

    /// <summary>
    /// CUSTOMER (default): the credit pays any of the customer's subscriptions. SUBSCRIPTION: the
    /// credit pays only the subscription the code is redeemed on, and ends with it.
    /// </summary>
    [JsonPropertyName("scope")]
    public CouponCreditScope? Scope { get; init; }

    /// <summary>The <c>type</c> property.</summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "CREDIT";

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(CreditDiscount? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Amount, other.Amount)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(ExpiresInDays, other.ExpiresInDays)
        && global::Meteroid.Equality.Equal(Scope, other.Scope)
        && global::Meteroid.Equality.Equal(Type, other.Type)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Amount));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(ExpiresInDays));
        hash.Add(global::Meteroid.Equality.Hash(Scope));
        hash.Add(global::Meteroid.Equality.Hash(Type));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
