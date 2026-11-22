// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>ReverseInvoicePaymentRequest</c> object.</summary>
public sealed partial record ReverseInvoicePaymentRequest
{
    /// <summary>
    /// <c>CHARGEBACK</c>, <c>DEBTOR_RECALL</c> and <c>DISPUTE</c> leave the invoice paid and mark the payment
    /// disputed. Any other kind makes the amount due again.
    /// </summary>
    [JsonPropertyName("kind")]
    public required ReversalKind Kind { get; init; }

    /// <summary>
    /// Additional details about the reversal.
    /// </summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    /// <summary>
    /// When the reversal occurred, at most a day ahead. Defaults to the current time.
    /// </summary>
    [JsonPropertyName("reversed_at")]
    public DateTimeOffset? ReversedAt { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(ReverseInvoicePaymentRequest? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Kind, other.Kind)
        && global::Meteroid.Equality.Equal(Reason, other.Reason)
        && global::Meteroid.Equality.Equal(ReversedAt, other.ReversedAt)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Kind));
        hash.Add(global::Meteroid.Equality.Hash(Reason));
        hash.Add(global::Meteroid.Equality.Hash(ReversedAt));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
