// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>PaymentMethodInfo</c> object.</summary>
public sealed partial record PaymentMethodInfo
{
    /// <summary>The <c>account_number_hint</c> property.</summary>
    [JsonPropertyName("account_number_hint")]
    public string? AccountNumberHint { get; init; }

    /// <summary>The <c>card_brand</c> property.</summary>
    [JsonPropertyName("card_brand")]
    public string? CardBrand { get; init; }

    /// <summary>The <c>card_last4</c> property.</summary>
    [JsonPropertyName("card_last4")]
    public string? CardLast4 { get; init; }

    /// <summary>The <c>payment_method_type</c> property.</summary>
    [JsonPropertyName("payment_method_type")]
    public required PaymentMethodTypeEnum PaymentMethodType { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(PaymentMethodInfo? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(AccountNumberHint, other.AccountNumberHint)
        && global::Meteroid.Equality.Equal(CardBrand, other.CardBrand)
        && global::Meteroid.Equality.Equal(CardLast4, other.CardLast4)
        && global::Meteroid.Equality.Equal(PaymentMethodType, other.PaymentMethodType)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(AccountNumberHint));
        hash.Add(global::Meteroid.Equality.Hash(CardBrand));
        hash.Add(global::Meteroid.Equality.Hash(CardLast4));
        hash.Add(global::Meteroid.Equality.Hash(PaymentMethodType));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
