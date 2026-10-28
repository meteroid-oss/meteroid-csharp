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
/// The currency or credit unit, and the subscription, are fixed at creation.
/// </summary>
public sealed partial record PatchBudgetRequest
{
    /// <summary>The <c>amount</c> property.</summary>
    [JsonPropertyName("amount")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<long?>))]
    public MaybeUnset<long?> Amount { get; init; }

    /// <summary>The <c>behavior</c> property.</summary>
    [JsonPropertyName("behavior")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<BudgetBehavior?>))]
    public MaybeUnset<BudgetBehavior?> Behavior { get; init; }

    /// <summary>
    /// The <c>version</c> you read; a newer stored version is refused with 409.
    /// </summary>
    [JsonPropertyName("expected_version")]
    public required int ExpectedVersion { get; init; }

    /// <summary>The <c>thresholds</c> property.</summary>
    [JsonPropertyName("thresholds")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<IReadOnlyList<int>?>))]
    public MaybeUnset<IReadOnlyList<int>?> Thresholds { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(PatchBudgetRequest? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Amount, other.Amount)
        && global::Meteroid.Equality.Equal(Behavior, other.Behavior)
        && global::Meteroid.Equality.Equal(ExpectedVersion, other.ExpectedVersion)
        && global::Meteroid.Equality.Equal(Thresholds, other.Thresholds)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Amount));
        hash.Add(global::Meteroid.Equality.Hash(Behavior));
        hash.Add(global::Meteroid.Equality.Hash(ExpectedVersion));
        hash.Add(global::Meteroid.Equality.Hash(Thresholds));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
