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
/// An automatic top-up charge failed, or the automatic top-up was suspended.
/// </summary>
public sealed partial record AutoTopUpEventData
{
    /// <summary>
    /// The charge in minor units of <c>currency</c>: the credit it would have added, or for a credit
    /// unit wallet the price of those credits in the customer's currency. When the credits could
    /// not be priced (no selling price), the credits themselves, with <c>currency</c> the unit code. On
    /// a suspension after a top-up payment was refunded or disputed: that payment's top-up.
    /// </summary>
    [JsonPropertyName("amount")]
    public required long Amount { get; init; }

    /// <summary>
    /// Failed charges in a row, this one included.
    /// </summary>
    [JsonPropertyName("consecutive_failures")]
    public required int ConsecutiveFailures { get; init; }

    /// <summary>
    /// The currency charged (ISO 4217), or the credit unit code when the credits had no price.
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>The <c>customer_id</c> property.</summary>
    [JsonPropertyName("customer_id")]
    public required string CustomerId { get; init; }

    /// <summary>
    /// May carry payment provider detail.
    /// </summary>
    [JsonPropertyName("error")]
    public required string Error { get; init; }

    /// <summary>
    /// Set on <c>wallet.auto_top_up_suspended</c>: when it was suspended.
    /// </summary>
    [JsonPropertyName("suspended_at")]
    public DateTimeOffset? SuspendedAt { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(AutoTopUpEventData? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Amount, other.Amount)
        && global::Meteroid.Equality.Equal(ConsecutiveFailures, other.ConsecutiveFailures)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(CustomerId, other.CustomerId)
        && global::Meteroid.Equality.Equal(Error, other.Error)
        && global::Meteroid.Equality.Equal(SuspendedAt, other.SuspendedAt)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Amount));
        hash.Add(global::Meteroid.Equality.Hash(ConsecutiveFailures));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(CustomerId));
        hash.Add(global::Meteroid.Equality.Hash(Error));
        hash.Add(global::Meteroid.Equality.Hash(SuspendedAt));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
