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
/// Where a top-up stands. Its credit is granted once it is paid; <c>wallet.funded</c> reports it.
/// </summary>
public sealed partial record TopUpResponse
{
    /// <summary>
    /// Credit bought, in minor units of <c>currency</c>, or of <c>credit_unit</c> when set.
    /// </summary>
    [JsonPropertyName("amount")]
    public required long Amount { get; init; }

    /// <summary>
    /// Charged to the payment method, tax included, in minor units of <c>currency</c>; absent until a
    /// charge is made.
    /// </summary>
    [JsonPropertyName("charged_amount")]
    public long? ChargedAmount { get; init; }

    /// <summary>
    /// Hosted page where the customer completes the payment; present while it awaits them.
    /// </summary>
    [JsonPropertyName("checkout_url")]
    public string? CheckoutUrl { get; init; }

    /// <summary>
    /// Set when credits of this credit unit were bought: <c>amount</c> is in its minor units.
    /// </summary>
    [JsonPropertyName("credit_unit")]
    public string? CreditUnit { get; init; }

    /// <summary>
    /// The money the top-up is charged in.
    /// </summary>
    [JsonPropertyName("currency")]
    public required Currency Currency { get; init; }

    /// <summary>
    /// The invoice documenting the purchase.
    /// </summary>
    [JsonPropertyName("invoice_id")]
    public string? InvoiceId { get; init; }

    /// <summary>
    /// The charge made on the payment method; absent until a charge is made.
    /// </summary>
    [JsonPropertyName("payment_transaction_id")]
    public string? PaymentTransactionId { get; init; }

    /// <summary>
    /// SUCCEEDED once paid; otherwise what the payment is waiting for.
    /// </summary>
    [JsonPropertyName("status")]
    public required TopUpStatus Status { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(TopUpResponse? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Amount, other.Amount)
        && global::Meteroid.Equality.Equal(ChargedAmount, other.ChargedAmount)
        && global::Meteroid.Equality.Equal(CheckoutUrl, other.CheckoutUrl)
        && global::Meteroid.Equality.Equal(CreditUnit, other.CreditUnit)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(InvoiceId, other.InvoiceId)
        && global::Meteroid.Equality.Equal(PaymentTransactionId, other.PaymentTransactionId)
        && global::Meteroid.Equality.Equal(Status, other.Status)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Amount));
        hash.Add(global::Meteroid.Equality.Hash(ChargedAmount));
        hash.Add(global::Meteroid.Equality.Hash(CheckoutUrl));
        hash.Add(global::Meteroid.Equality.Hash(CreditUnit));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(InvoiceId));
        hash.Add(global::Meteroid.Equality.Hash(PaymentTransactionId));
        hash.Add(global::Meteroid.Equality.Hash(Status));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
