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
/// A spending cap stopped an automatic top-up.
/// </summary>
public sealed partial record AutoTopUpCapReachedEventData
{
    /// <summary>
    /// What the suppressed top-up would have charged, tax included once it was quoted (before
    /// tax when the cap stopped it before then). Caps are always money: for a credit unit wallet,
    /// <c>currency</c> is the customer's currency.
    /// </summary>
    [JsonPropertyName("attempted_amount")]
    public required long AttemptedAmount { get; init; }

    /// <summary>
    /// The cap, tax included, in minor units of <c>currency</c>.
    /// </summary>
    [JsonPropertyName("cap")]
    public required long Cap { get; init; }

    /// <summary>
    /// The currency the cap and the charge are in (ISO 4217).
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>The <c>customer_id</c> property.</summary>
    [JsonPropertyName("customer_id")]
    public required string CustomerId { get; init; }

    /// <summary>
    /// <c>DAILY</c> (rolling day) or <c>MONTHLY</c> (calendar month, UTC).
    /// </summary>
    [JsonPropertyName("period")]
    public required string Period { get; init; }

    /// <summary>
    /// End of the capped period.
    /// </summary>
    [JsonPropertyName("period_end")]
    public required DateTimeOffset PeriodEnd { get; init; }

    /// <summary>
    /// Start of the capped period.
    /// </summary>
    [JsonPropertyName("period_start")]
    public required DateTimeOffset PeriodStart { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(AutoTopUpCapReachedEventData? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(AttemptedAmount, other.AttemptedAmount)
        && global::Meteroid.Equality.Equal(Cap, other.Cap)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(CustomerId, other.CustomerId)
        && global::Meteroid.Equality.Equal(Period, other.Period)
        && global::Meteroid.Equality.Equal(PeriodEnd, other.PeriodEnd)
        && global::Meteroid.Equality.Equal(PeriodStart, other.PeriodStart)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(AttemptedAmount));
        hash.Add(global::Meteroid.Equality.Hash(Cap));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(CustomerId));
        hash.Add(global::Meteroid.Equality.Hash(Period));
        hash.Add(global::Meteroid.Equality.Hash(PeriodEnd));
        hash.Add(global::Meteroid.Equality.Hash(PeriodStart));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
