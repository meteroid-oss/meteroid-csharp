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
/// The credit unit a credit pack grants.
/// </summary>
public sealed partial record CreditPackUnit
{
    /// <summary>
    /// The credit unit's code, e.g. <c>CREDITS</c>.
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; init; }

    /// <summary>
    /// The credit unit's id (<c>cun_…</c>).
    /// </summary>
    [JsonPropertyName("credit_unit_id")]
    public required string CreditUnitId { get; init; }

    /// <summary>
    /// Decimal places of the unit: credit balances and ledger amounts in it are integers of
    /// 10^-precision credit.
    /// </summary>
    [JsonPropertyName("precision")]
    public required int Precision { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(CreditPackUnit? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Code, other.Code)
        && global::Meteroid.Equality.Equal(CreditUnitId, other.CreditUnitId)
        && global::Meteroid.Equality.Equal(Precision, other.Precision)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Code));
        hash.Add(global::Meteroid.Equality.Hash(CreditUnitId));
        hash.Add(global::Meteroid.Equality.Hash(Precision));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
