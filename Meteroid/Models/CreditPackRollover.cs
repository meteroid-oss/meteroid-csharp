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
/// Unspent included credit carried once into a new grant when it expires, spent before the next
/// period's credit.
/// </summary>
public sealed partial record CreditPackRollover
{
    /// <summary>
    /// Term of the rolled credit from the original expiry: DAY or MONTH.
    /// </summary>
    [JsonPropertyName("expiry")]
    public required CreditPackExpiry Expiry { get; init; }

    /// <summary>
    /// Cap per pack, in the pack's credit; absent carries all that is left.
    /// </summary>
    [JsonPropertyName("max_amount")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public decimal? MaxAmount { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(CreditPackRollover? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Expiry, other.Expiry)
        && global::Meteroid.Equality.Equal(MaxAmount, other.MaxAmount)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Expiry));
        hash.Add(global::Meteroid.Equality.Hash(MaxAmount));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
