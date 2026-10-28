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
/// A spending limit for one currency, set by you or by the customer, with alerts at percentages
/// of it. It counts the customer's whole spend, or one subscription's. A HARD budget also refuses
/// access once reached. A budget never charges the customer.
/// </summary>
public sealed partial record Budget
{
    /// <summary>
    /// In minor units of the currency or credit unit.
    /// </summary>
    [JsonPropertyName("amount")]
    public required long Amount { get; init; }

    /// <summary>The <c>archived_at</c> property.</summary>
    [JsonPropertyName("archived_at")]
    public DateTimeOffset? ArchivedAt { get; init; }

    /// <summary>
    /// When <c>estimated_spend</c> was last measured.
    /// </summary>
    [JsonPropertyName("as_of")]
    public DateTimeOffset? AsOf { get; init; }

    /// <summary>The <c>behavior</c> property.</summary>
    [JsonPropertyName("behavior")]
    public required BudgetBehavior Behavior { get; init; }

    /// <summary>The <c>created_at</c> property.</summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>The <c>created_by</c> property.</summary>
    [JsonPropertyName("created_by")]
    public required BudgetAuthor CreatedBy { get; init; }

    /// <summary>
    /// The credit unit (its code) whose usage the budget counts; absent for a currency.
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
    /// Spend in the current billing period, including usage not invoiced yet, in minor units.
    /// Absent until first measured.
    /// </summary>
    [JsonPropertyName("estimated_spend")]
    public long? EstimatedSpend { get; init; }

    /// <summary>
    /// Always false: the estimate prices usage that is not yet invoiced.
    /// </summary>
    [JsonPropertyName("exact")]
    public required bool Exact { get; init; }

    /// <summary>The <c>id</c> property.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>The <c>period</c> property.</summary>
    [JsonPropertyName("period")]
    public BudgetPeriod? Period { get; init; }

    /// <summary>
    /// The subscription whose spend the budget counts; null when it counts the whole customer's.
    /// </summary>
    [JsonPropertyName("subscription_id")]
    public string? SubscriptionId { get; init; }

    /// <summary>
    /// Percentages of the amount at which an alert is sent.
    /// </summary>
    [JsonPropertyName("thresholds")]
    public required IReadOnlyList<int> Thresholds { get; init; }

    /// <summary>The <c>updated_at</c> property.</summary>
    [JsonPropertyName("updated_at")]
    public required DateTimeOffset UpdatedAt { get; init; }

    /// <summary>
    /// Send it back as <c>expected_version</c> when patching.
    /// </summary>
    [JsonPropertyName("version")]
    public required int Version { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(Budget? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Amount, other.Amount)
        && global::Meteroid.Equality.Equal(ArchivedAt, other.ArchivedAt)
        && global::Meteroid.Equality.Equal(AsOf, other.AsOf)
        && global::Meteroid.Equality.Equal(Behavior, other.Behavior)
        && global::Meteroid.Equality.Equal(CreatedAt, other.CreatedAt)
        && global::Meteroid.Equality.Equal(CreatedBy, other.CreatedBy)
        && global::Meteroid.Equality.Equal(CreditUnit, other.CreditUnit)
        && global::Meteroid.Equality.Equal(CreditUnitPrecision, other.CreditUnitPrecision)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(EstimatedSpend, other.EstimatedSpend)
        && global::Meteroid.Equality.Equal(Exact, other.Exact)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(Period, other.Period)
        && global::Meteroid.Equality.Equal(SubscriptionId, other.SubscriptionId)
        && global::Meteroid.Equality.Equal(Thresholds, other.Thresholds)
        && global::Meteroid.Equality.Equal(UpdatedAt, other.UpdatedAt)
        && global::Meteroid.Equality.Equal(Version, other.Version)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Amount));
        hash.Add(global::Meteroid.Equality.Hash(ArchivedAt));
        hash.Add(global::Meteroid.Equality.Hash(AsOf));
        hash.Add(global::Meteroid.Equality.Hash(Behavior));
        hash.Add(global::Meteroid.Equality.Hash(CreatedAt));
        hash.Add(global::Meteroid.Equality.Hash(CreatedBy));
        hash.Add(global::Meteroid.Equality.Hash(CreditUnit));
        hash.Add(global::Meteroid.Equality.Hash(CreditUnitPrecision));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(EstimatedSpend));
        hash.Add(global::Meteroid.Equality.Hash(Exact));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(Period));
        hash.Add(global::Meteroid.Equality.Hash(SubscriptionId));
        hash.Add(global::Meteroid.Equality.Hash(Thresholds));
        hash.Add(global::Meteroid.Equality.Hash(UpdatedAt));
        hash.Add(global::Meteroid.Equality.Hash(Version));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
