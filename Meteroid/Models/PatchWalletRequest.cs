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
/// Partial update of a wallet's configuration: omit a field to leave it unchanged.
/// </summary>
public sealed partial record PatchWalletRequest
{
    /// <summary>The <c>auto_top_up</c> property.</summary>
    [JsonPropertyName("auto_top_up")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<AutoTopUpWriteRequest?>))]
    public MaybeUnset<AutoTopUpWriteRequest?> AutoTopUp { get; init; }

    /// <summary>
    /// Ascending, distinct, at most 5, non-negative. Omit to leave unchanged; an empty list
    /// clears every threshold.
    /// </summary>
    [JsonPropertyName("low_balance_thresholds")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<IReadOnlyList<long>?>))]
    public MaybeUnset<IReadOnlyList<long>?> LowBalanceThresholds { get; init; }

    /// <summary>
    /// Credit unit wallets: the price this customer agreed for one credit, in major units of the
    /// customer's currency, as a decimal string (positive, at most 12 decimal places). Purchases
    /// and automatic top-ups default to it instead of the list price. Omit to leave it unchanged;
    /// <c>null</c> returns the customer to the list price. A change applies to purchases quoted after
    /// it. An automatic top-up keeps running at the new price when it is at or below the price
    /// its terms were authorized at, and stops until they are confirmed again when it is above.
    /// </summary>
    [JsonPropertyName("unit_price")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<string?>))]
    public MaybeUnset<string?> UnitPrice { get; init; }

    /// <summary>The <c>usage_at_zero</c> property.</summary>
    [JsonPropertyName("usage_at_zero")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<UsageAtZero?>))]
    public MaybeUnset<UsageAtZero?> UsageAtZero { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(PatchWalletRequest? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(AutoTopUp, other.AutoTopUp)
        && global::Meteroid.Equality.Equal(LowBalanceThresholds, other.LowBalanceThresholds)
        && global::Meteroid.Equality.Equal(UnitPrice, other.UnitPrice)
        && global::Meteroid.Equality.Equal(UsageAtZero, other.UsageAtZero)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(AutoTopUp));
        hash.Add(global::Meteroid.Equality.Hash(LowBalanceThresholds));
        hash.Add(global::Meteroid.Equality.Hash(UnitPrice));
        hash.Add(global::Meteroid.Equality.Hash(UsageAtZero));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
