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
/// Automatic top-up of the credit that applies to ALL charges: it charges the customer's payment
/// method when the balance falls below <c>threshold</c>.
/// </summary>
public sealed partial record AutoTopUp
{
    /// <summary>
    /// FIXED only: credit bought each time, in minor units of the wallet.
    /// </summary>
    [JsonPropertyName("amount")]
    public long? Amount { get; init; }

    /// <summary>
    /// When an operator attested that the customer agreed to automatic charges on exactly these
    /// terms. Absent when the customer confirmed them in their portal, or the terms changed since.
    /// </summary>
    [JsonPropertyName("customer_consent_attested_at")]
    public DateTimeOffset? CustomerConsentAttestedAt { get; init; }

    /// <summary>
    /// Most charged in a rolling day, tax included. For a credit unit wallet caps are money, in
    /// minor units of the customer's currency.
    /// </summary>
    [JsonPropertyName("daily_cap")]
    public long? DailyCap { get; init; }

    /// <summary>
    /// Why the last charge failed; may carry payment provider detail.
    /// </summary>
    [JsonPropertyName("last_error")]
    public string? LastError { get; init; }

    /// <summary>
    /// The last charge that succeeded.
    /// </summary>
    [JsonPropertyName("last_succeeded_at")]
    public DateTimeOffset? LastSucceededAt { get; init; }

    /// <summary>
    /// Largest single charge, in the same money as <c>minimum</c>.
    /// </summary>
    [JsonPropertyName("maximum")]
    public long? Maximum { get; init; }

    /// <summary>
    /// FIXED buys <c>amount</c> each time; TO_TARGET buys back up to <c>target</c>.
    /// </summary>
    [JsonPropertyName("method")]
    public required AutoTopUpMethod Method { get; init; }

    /// <summary>
    /// Smallest single charge. For a credit unit wallet it is money (the price before tax, in
    /// minor units of the customer's currency), like the caps; the threshold, amount and target
    /// are credits.
    /// </summary>
    [JsonPropertyName("minimum")]
    public long? Minimum { get; init; }

    /// <summary>
    /// Most charged in a calendar month (UTC), tax included.
    /// </summary>
    [JsonPropertyName("monthly_cap")]
    public long? MonthlyCap { get; init; }

    /// <summary>
    /// Absent charges the customer's default payment method.
    /// </summary>
    [JsonPropertyName("payment_method_id")]
    public string? PaymentMethodId { get; init; }

    /// <summary>
    /// ACTIVE, DISABLED (terms kept) or SUSPENDED after repeated failed charges.
    /// </summary>
    [JsonPropertyName("status")]
    public required AutoTopUpStatus Status { get; init; }

    /// <summary>
    /// Set while SUSPENDED: since when.
    /// </summary>
    [JsonPropertyName("suspended_at")]
    public DateTimeOffset? SuspendedAt { get; init; }

    /// <summary>
    /// TO_TARGET only: the balance a top-up brings the wallet back to, in minor units.
    /// </summary>
    [JsonPropertyName("target")]
    public long? Target { get; init; }

    /// <summary>
    /// Tops up once the balance is at or below this, in minor units of the wallet.
    /// </summary>
    [JsonPropertyName("threshold")]
    public required long Threshold { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(AutoTopUp? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Amount, other.Amount)
        && global::Meteroid.Equality.Equal(CustomerConsentAttestedAt, other.CustomerConsentAttestedAt)
        && global::Meteroid.Equality.Equal(DailyCap, other.DailyCap)
        && global::Meteroid.Equality.Equal(LastError, other.LastError)
        && global::Meteroid.Equality.Equal(LastSucceededAt, other.LastSucceededAt)
        && global::Meteroid.Equality.Equal(Maximum, other.Maximum)
        && global::Meteroid.Equality.Equal(Method, other.Method)
        && global::Meteroid.Equality.Equal(Minimum, other.Minimum)
        && global::Meteroid.Equality.Equal(MonthlyCap, other.MonthlyCap)
        && global::Meteroid.Equality.Equal(PaymentMethodId, other.PaymentMethodId)
        && global::Meteroid.Equality.Equal(Status, other.Status)
        && global::Meteroid.Equality.Equal(SuspendedAt, other.SuspendedAt)
        && global::Meteroid.Equality.Equal(Target, other.Target)
        && global::Meteroid.Equality.Equal(Threshold, other.Threshold)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Amount));
        hash.Add(global::Meteroid.Equality.Hash(CustomerConsentAttestedAt));
        hash.Add(global::Meteroid.Equality.Hash(DailyCap));
        hash.Add(global::Meteroid.Equality.Hash(LastError));
        hash.Add(global::Meteroid.Equality.Hash(LastSucceededAt));
        hash.Add(global::Meteroid.Equality.Hash(Maximum));
        hash.Add(global::Meteroid.Equality.Hash(Method));
        hash.Add(global::Meteroid.Equality.Hash(Minimum));
        hash.Add(global::Meteroid.Equality.Hash(MonthlyCap));
        hash.Add(global::Meteroid.Equality.Hash(PaymentMethodId));
        hash.Add(global::Meteroid.Equality.Hash(Status));
        hash.Add(global::Meteroid.Equality.Hash(SuspendedAt));
        hash.Add(global::Meteroid.Equality.Hash(Target));
        hash.Add(global::Meteroid.Equality.Hash(Threshold));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
