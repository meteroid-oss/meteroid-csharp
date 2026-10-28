// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>CreateBudgetRequest</c> object.</summary>
public sealed partial record CreateBudgetRequest
{
    /// <summary>
    /// In minor units of the currency or credit unit.
    /// </summary>
    [JsonPropertyName("amount")]
    public required long Amount { get; init; }

    /// <summary>The <c>behavior</c> property.</summary>
    [JsonPropertyName("behavior")]
    public BudgetBehavior? Behavior { get; init; }

    /// <summary>
    /// A credit unit (its code): the budget counts the usage priced in that unit, in its minor
    /// units.
    /// </summary>
    [JsonPropertyName("credit_unit")]
    public string? CreditUnit { get; init; }

    /// <summary>The <c>currency</c> property.</summary>
    [JsonPropertyName("currency")]
    public Currency? Currency { get; init; }

    /// <summary>
    /// An active subscription of the customer (<c>sub_…</c>): the budget then counts only that
    /// subscription's spend, in its currency. Absent counts the whole customer's.
    /// </summary>
    [JsonPropertyName("subscription_id")]
    public string? SubscriptionId { get; init; }

    /// <summary>
    /// Percentages of the amount (1 to 100, at most 10). Defaults to 50, 80 and 100.
    /// </summary>
    [JsonPropertyName("thresholds")]
    public IReadOnlyList<int>? Thresholds { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(CreateBudgetRequest? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Amount, other.Amount)
        && global::Meteroid.Equality.Equal(Behavior, other.Behavior)
        && global::Meteroid.Equality.Equal(CreditUnit, other.CreditUnit)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(SubscriptionId, other.SubscriptionId)
        && global::Meteroid.Equality.Equal(Thresholds, other.Thresholds)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Amount));
        hash.Add(global::Meteroid.Equality.Hash(Behavior));
        hash.Add(global::Meteroid.Equality.Hash(CreditUnit));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(SubscriptionId));
        hash.Add(global::Meteroid.Equality.Hash(Thresholds));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
