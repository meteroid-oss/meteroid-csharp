// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>CustomerPatchRequest</c> object.</summary>
public sealed partial record CustomerPatchRequest
{
    /// <summary>The <c>alias</c> property.</summary>
    [JsonPropertyName("alias")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<string?>))]
    public MaybeUnset<string?> Alias { get; init; }

    /// <summary>The <c>billing_address</c> property.</summary>
    [JsonPropertyName("billing_address")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<Address?>))]
    public MaybeUnset<Address?> BillingAddress { get; init; }

    /// <summary>The <c>billing_email</c> property.</summary>
    [JsonPropertyName("billing_email")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<string?>))]
    public MaybeUnset<string?> BillingEmail { get; init; }

    /// <summary>
    /// BT-10 — the reference the buyer routes invoices by (a Leitweg-ID for German
    /// public bodies). Required by XRechnung.
    /// </summary>
    [JsonPropertyName("buyer_reference")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<string?>))]
    public MaybeUnset<string?> BuyerReference { get; init; }

    /// <summary>The <c>currency</c> property.</summary>
    [JsonPropertyName("currency")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<Currency?>))]
    public MaybeUnset<Currency?> Currency { get; init; }

    /// <summary>
    /// Partial update of custom property values (merge; send a key with <c>null</c> to remove it).
    /// Omit to leave unchanged.
    /// </summary>
    [JsonPropertyName("custom_properties")]
    public JsonNode? CustomProperties { get; init; }

    /// <summary>The <c>custom_taxes</c> property.</summary>
    [JsonPropertyName("custom_taxes")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<IReadOnlyList<CustomTaxRate>?>))]
    public MaybeUnset<IReadOnlyList<CustomTaxRate>?> CustomTaxes { get; init; }

    /// <summary>The <c>customer_type</c> property.</summary>
    [JsonPropertyName("customer_type")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<CustomerType?>))]
    public MaybeUnset<CustomerType?> CustomerType { get; init; }

    /// <summary>
    /// Free-text legal exemption mention surfaced on exempt invoices.
    /// </summary>
    [JsonPropertyName("exemption_reason")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<string?>))]
    public MaybeUnset<string?> ExemptionReason { get; init; }

    /// <summary>The <c>first_name</c> property.</summary>
    [JsonPropertyName("first_name")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<string?>))]
    public MaybeUnset<string?> FirstName { get; init; }

    /// <summary>The <c>invoicing_emails</c> property.</summary>
    [JsonPropertyName("invoicing_emails")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<IReadOnlyList<string>?>))]
    public MaybeUnset<IReadOnlyList<string>?> InvoicingEmails { get; init; }

    /// <summary>The <c>invoicing_entity_id</c> property.</summary>
    [JsonPropertyName("invoicing_entity_id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<string?>))]
    public MaybeUnset<string?> InvoicingEntityId { get; init; }

    /// <summary>
    /// Deprecated: use <c>preferred_locales</c>. Applied only when <c>preferred_locales</c> is absent.
    /// </summary>
    [JsonPropertyName("invoicing_language")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<string?>))]
    [Obsolete("Deprecated by the API.")]
    public MaybeUnset<string?> InvoicingLanguage { get; init; }

    /// <summary>The <c>is_tax_exempt</c> property.</summary>
    [JsonPropertyName("is_tax_exempt")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<bool?>))]
    public MaybeUnset<bool?> IsTaxExempt { get; init; }

    /// <summary>The <c>last_name</c> property.</summary>
    [JsonPropertyName("last_name")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<string?>))]
    public MaybeUnset<string?> LastName { get; init; }

    /// <summary>
    /// BT-47 — the buyer's national register identifier (SIREN/SIRET, HRB).
    /// </summary>
    [JsonPropertyName("legal_number")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<string?>))]
    public MaybeUnset<string?> LegalNumber { get; init; }

    /// <summary>The <c>name</c> property.</summary>
    [JsonPropertyName("name")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<string?>))]
    public MaybeUnset<string?> Name { get; init; }

    /// <summary>The <c>phone</c> property.</summary>
    [JsonPropertyName("phone")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<string?>))]
    public MaybeUnset<string?> Phone { get; init; }

    /// <summary>
    /// Preferred document languages, most-preferred first (BCP-47 tags, e.g.
    /// <c>["fr-FR", "en"]</c>); overrides the invoicing entity default. Omit to leave
    /// unchanged, send <c>[]</c> to reset to that default.
    /// </summary>
    [JsonPropertyName("preferred_locales")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<IReadOnlyList<string>?>))]
    public MaybeUnset<IReadOnlyList<string>?> PreferredLocales { get; init; }

    /// <summary>The <c>shipping_address</c> property.</summary>
    [JsonPropertyName("shipping_address")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<ShippingAddress?>))]
    public MaybeUnset<ShippingAddress?> ShippingAddress { get; init; }

    /// <summary>The <c>vat_number</c> property.</summary>
    [JsonPropertyName("vat_number")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(MaybeUnsetConverter<string?>))]
    public MaybeUnset<string?> VatNumber { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(CustomerPatchRequest? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Alias, other.Alias)
        && global::Meteroid.Equality.Equal(BillingAddress, other.BillingAddress)
        && global::Meteroid.Equality.Equal(BillingEmail, other.BillingEmail)
        && global::Meteroid.Equality.Equal(BuyerReference, other.BuyerReference)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(CustomProperties, other.CustomProperties)
        && global::Meteroid.Equality.Equal(CustomTaxes, other.CustomTaxes)
        && global::Meteroid.Equality.Equal(CustomerType, other.CustomerType)
        && global::Meteroid.Equality.Equal(ExemptionReason, other.ExemptionReason)
        && global::Meteroid.Equality.Equal(FirstName, other.FirstName)
        && global::Meteroid.Equality.Equal(InvoicingEmails, other.InvoicingEmails)
        && global::Meteroid.Equality.Equal(InvoicingEntityId, other.InvoicingEntityId)
        && global::Meteroid.Equality.Equal(InvoicingLanguage, other.InvoicingLanguage)
        && global::Meteroid.Equality.Equal(IsTaxExempt, other.IsTaxExempt)
        && global::Meteroid.Equality.Equal(LastName, other.LastName)
        && global::Meteroid.Equality.Equal(LegalNumber, other.LegalNumber)
        && global::Meteroid.Equality.Equal(Name, other.Name)
        && global::Meteroid.Equality.Equal(Phone, other.Phone)
        && global::Meteroid.Equality.Equal(PreferredLocales, other.PreferredLocales)
        && global::Meteroid.Equality.Equal(ShippingAddress, other.ShippingAddress)
        && global::Meteroid.Equality.Equal(VatNumber, other.VatNumber)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Alias));
        hash.Add(global::Meteroid.Equality.Hash(BillingAddress));
        hash.Add(global::Meteroid.Equality.Hash(BillingEmail));
        hash.Add(global::Meteroid.Equality.Hash(BuyerReference));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(CustomProperties));
        hash.Add(global::Meteroid.Equality.Hash(CustomTaxes));
        hash.Add(global::Meteroid.Equality.Hash(CustomerType));
        hash.Add(global::Meteroid.Equality.Hash(ExemptionReason));
        hash.Add(global::Meteroid.Equality.Hash(FirstName));
        hash.Add(global::Meteroid.Equality.Hash(InvoicingEmails));
        hash.Add(global::Meteroid.Equality.Hash(InvoicingEntityId));
        hash.Add(global::Meteroid.Equality.Hash(InvoicingLanguage));
        hash.Add(global::Meteroid.Equality.Hash(IsTaxExempt));
        hash.Add(global::Meteroid.Equality.Hash(LastName));
        hash.Add(global::Meteroid.Equality.Hash(LegalNumber));
        hash.Add(global::Meteroid.Equality.Hash(Name));
        hash.Add(global::Meteroid.Equality.Hash(Phone));
        hash.Add(global::Meteroid.Equality.Hash(PreferredLocales));
        hash.Add(global::Meteroid.Equality.Hash(ShippingAddress));
        hash.Add(global::Meteroid.Equality.Hash(VatNumber));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
