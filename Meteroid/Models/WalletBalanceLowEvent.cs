// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>WalletBalanceLowEvent</c> object.</summary>
public sealed partial record WalletBalanceLowEvent
{
    /// <summary>
    /// The balance when it fell below <c>threshold</c>, in minor units: the wallet's <c>balance</c>, all
    /// its credit on account net of the unbilled usage it pays, including credit that belongs to
    /// a subscription or is limited to usage or products. Sent once per crossing, for the lowest
    /// threshold crossed; it re-arms once the balance is back at the threshold. Because that
    /// credit counts here and not in <c>wallet.depleted</c>, a wallet can be depleted without this
    /// event firing.
    /// </summary>
    [JsonPropertyName("balance")]
    public required long Balance { get; init; }

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

    /// <summary>
    /// The part of <c>balance</c> that pays any charge of any subscription: what automatic top-ups
    /// refill and <c>wallet.depleted</c> watches. Absent on events recorded before it was reported.
    /// </summary>
    [JsonPropertyName("shared_balance")]
    public long? SharedBalance { get; init; }

    /// <summary>
    /// The low-balance threshold crossed, in the same minor units.
    /// </summary>
    [JsonPropertyName("threshold")]
    public required long Threshold { get; init; }

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
    public bool Equals(WalletBalanceLowEvent? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Balance, other.Balance)
        && global::Meteroid.Equality.Equal(CreditUnit, other.CreditUnit)
        && global::Meteroid.Equality.Equal(CreditUnitPrecision, other.CreditUnitPrecision)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(CustomerId, other.CustomerId)
        && global::Meteroid.Equality.Equal(SharedBalance, other.SharedBalance)
        && global::Meteroid.Equality.Equal(Threshold, other.Threshold)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(Timestamp, other.Timestamp)
        && global::Meteroid.Equality.Equal(Type, other.Type)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Balance));
        hash.Add(global::Meteroid.Equality.Hash(CreditUnit));
        hash.Add(global::Meteroid.Equality.Hash(CreditUnitPrecision));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(CustomerId));
        hash.Add(global::Meteroid.Equality.Hash(SharedBalance));
        hash.Add(global::Meteroid.Equality.Hash(Threshold));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(Timestamp));
        hash.Add(global::Meteroid.Equality.Hash(Type));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
