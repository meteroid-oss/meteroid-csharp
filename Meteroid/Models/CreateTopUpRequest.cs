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
/// Credit sold to the customer, charged or invoiced.
/// </summary>
public sealed partial record CreateTopUpRequest
{
    /// <summary>
    /// Credit to buy, positive, applying to ALL charges. In minor units of <c>currency</c>, charged
    /// one for one without tax: the usage it pays is taxed on the invoice that bills it. With
    /// <c>credit_unit</c>, in minor units of that unit (e.g. 500000 is 5,000.00 credits of a unit with
    /// precision 2), charged at the unit's price per credit in the customer's currency, plus tax
    /// under the unit's product.
    /// </summary>
    [JsonPropertyName("amount")]
    public required long Amount { get; init; }

    /// <summary>
    /// CHARGE (default) charges a saved payment method now; SEND_INVOICE issues an invoice and
    /// grants the credit once it is paid.
    /// </summary>
    [JsonPropertyName("collection")]
    public TopUpCollection? Collection { get; init; }

    /// <summary>
    /// Buy credits of this credit unit (its code) instead of money; excludes <c>currency</c>. They are
    /// charged in the customer's currency at the customer's agreed price for the unit (the
    /// wallet's <c>unit_price</c>), else its list price, plus tax, under the unit's product.
    /// </summary>
    [JsonPropertyName("credit_unit")]
    public string? CreditUnit { get; init; }

    /// <summary>The <c>currency</c> property.</summary>
    [JsonPropertyName("currency")]
    public Currency? Currency { get; init; }

    /// <summary>
    /// Absolute expiry of the purchased credit; unset never expires.
    /// </summary>
    [JsonPropertyName("expires_at")]
    public DateTimeOffset? ExpiresAt { get; init; }

    /// <summary>
    /// CHARGE only; defaults to the customer's default payment method.
    /// </summary>
    [JsonPropertyName("payment_method_id")]
    public string? PaymentMethodId { get; init; }

    /// <summary>
    /// With <c>credit_unit</c>: the negotiated price of one credit for this purchase, in major units of
    /// the customer's currency, as a decimal string (e.g. "0.0008"). Defaults to the wallet's
    /// <c>unit_price</c> when set, else the list price; the unit must still have a list price in that
    /// currency.
    /// </summary>
    [JsonPropertyName("unit_price")]
    public string? UnitPrice { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(CreateTopUpRequest? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Amount, other.Amount)
        && global::Meteroid.Equality.Equal(Collection, other.Collection)
        && global::Meteroid.Equality.Equal(CreditUnit, other.CreditUnit)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(ExpiresAt, other.ExpiresAt)
        && global::Meteroid.Equality.Equal(PaymentMethodId, other.PaymentMethodId)
        && global::Meteroid.Equality.Equal(UnitPrice, other.UnitPrice)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Amount));
        hash.Add(global::Meteroid.Equality.Hash(Collection));
        hash.Add(global::Meteroid.Equality.Hash(CreditUnit));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(ExpiresAt));
        hash.Add(global::Meteroid.Equality.Hash(PaymentMethodId));
        hash.Add(global::Meteroid.Equality.Hash(UnitPrice));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
