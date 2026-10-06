// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>SubscriptionUpdateRequest</c> object.</summary>
public sealed partial record SubscriptionUpdateRequest
{
    /// <summary>
    /// If false, invoices will stay in Draft until manually reviewed and finalized.
    /// </summary>
    [JsonPropertyName("auto_advance_invoices")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<bool?>))]
    public MaybeUnset<bool?> AutoAdvanceInvoices { get; init; }

    /// <summary>
    /// Automatically try to charge the customer's configured payment method on finalize.
    /// </summary>
    [JsonPropertyName("charge_automatically")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<bool?>))]
    public MaybeUnset<bool?> ChargeAutomatically { get; init; }

    /// <summary>
    /// Partial update of custom property values (merge; send a key with <c>null</c> to remove it).
    /// Validated against the tenant's <c>SUBSCRIPTION</c> property definitions. Omit to leave unchanged.
    /// </summary>
    [JsonPropertyName("custom_properties")]
    public JsonNode? CustomProperties { get; init; }

    /// <summary>
    /// Default memo for invoices
    /// </summary>
    [JsonPropertyName("invoice_memo")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<string?>))]
    public MaybeUnset<string?> InvoiceMemo { get; init; }

    /// <summary>
    /// Payment terms in days (0 = due on issue)
    /// </summary>
    [JsonPropertyName("net_terms")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<int?>))]
    public MaybeUnset<int?> NetTerms { get; init; }

    /// <summary>The <c>payment_methods_config</c> property.</summary>
    [JsonPropertyName("payment_methods_config")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<PaymentMethodsConfig?>))]
    public MaybeUnset<PaymentMethodsConfig?> PaymentMethodsConfig { get; init; }

    /// <summary>
    /// Purchase order number
    /// </summary>
    [JsonPropertyName("purchase_order")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<string?>))]
    public MaybeUnset<string?> PurchaseOrder { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(SubscriptionUpdateRequest? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(AutoAdvanceInvoices, other.AutoAdvanceInvoices)
        && global::Meteroid.Equality.Equal(ChargeAutomatically, other.ChargeAutomatically)
        && global::Meteroid.Equality.Equal(CustomProperties, other.CustomProperties)
        && global::Meteroid.Equality.Equal(InvoiceMemo, other.InvoiceMemo)
        && global::Meteroid.Equality.Equal(NetTerms, other.NetTerms)
        && global::Meteroid.Equality.Equal(PaymentMethodsConfig, other.PaymentMethodsConfig)
        && global::Meteroid.Equality.Equal(PurchaseOrder, other.PurchaseOrder)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(AutoAdvanceInvoices));
        hash.Add(global::Meteroid.Equality.Hash(ChargeAutomatically));
        hash.Add(global::Meteroid.Equality.Hash(CustomProperties));
        hash.Add(global::Meteroid.Equality.Hash(InvoiceMemo));
        hash.Add(global::Meteroid.Equality.Hash(NetTerms));
        hash.Add(global::Meteroid.Equality.Hash(PaymentMethodsConfig));
        hash.Add(global::Meteroid.Equality.Hash(PurchaseOrder));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
