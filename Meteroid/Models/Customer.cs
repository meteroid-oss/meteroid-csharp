// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>Customer</c> object.</summary>
public sealed partial record Customer
{
    /// <summary>The <c>alias</c> property.</summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; init; }

    /// <summary>The <c>billing_address</c> property.</summary>
    [JsonPropertyName("billing_address")]
    public Address? BillingAddress { get; init; }

    /// <summary>The <c>billing_email</c> property.</summary>
    [JsonPropertyName("billing_email")]
    public string? BillingEmail { get; init; }

    /// <summary>
    /// BT-10 — the reference the buyer routes invoices by (a Leitweg-ID for German
    /// public bodies). Required by XRechnung.
    /// </summary>
    [JsonPropertyName("buyer_reference")]
    public string? BuyerReference { get; init; }

    /// <summary>The <c>connected_account_id</c> property.</summary>
    [JsonPropertyName("connected_account_id")]
    public string? ConnectedAccountId { get; init; }

    /// <summary>The <c>currency</c> property.</summary>
    [JsonPropertyName("currency")]
    public required Currency Currency { get; init; }

    /// <summary>
    /// User-defined custom property values, keyed by definition <c>key</c>.
    /// </summary>
    [JsonPropertyName("custom_properties")]
    public required JsonNode CustomProperties { get; init; }

    /// <summary>The <c>custom_taxes</c> property.</summary>
    [JsonPropertyName("custom_taxes")]
    public required IReadOnlyList<CustomTaxRate> CustomTaxes { get; init; }

    /// <summary>The <c>customer_type</c> property.</summary>
    [JsonPropertyName("customer_type")]
    public CustomerType? CustomerType { get; init; }

    /// <summary>The <c>first_name</c> property.</summary>
    [JsonPropertyName("first_name")]
    public string? FirstName { get; init; }

    /// <summary>The <c>id</c> property.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>The <c>invoicing_emails</c> property.</summary>
    [JsonPropertyName("invoicing_emails")]
    public required IReadOnlyList<string> InvoicingEmails { get; init; }

    /// <summary>The <c>invoicing_entity_id</c> property.</summary>
    [JsonPropertyName("invoicing_entity_id")]
    public required string InvoicingEntityId { get; init; }

    /// <summary>
    /// Deprecated: the first entry of <c>preferred_locales</c>.
    /// </summary>
    [JsonPropertyName("invoicing_language")]
    [Obsolete("Deprecated by the API.")]
    public string? InvoicingLanguage { get; init; }

    /// <summary>The <c>last_name</c> property.</summary>
    [JsonPropertyName("last_name")]
    public string? LastName { get; init; }

    /// <summary>
    /// BT-47 — the buyer's national register identifier (SIREN/SIRET, HRB).
    /// </summary>
    [JsonPropertyName("legal_number")]
    public string? LegalNumber { get; init; }

    /// <summary>The <c>name</c> property.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>The <c>phone</c> property.</summary>
    [JsonPropertyName("phone")]
    public string? Phone { get; init; }

    /// <summary>
    /// Preferred document languages, most-preferred first (BCP-47 tags, e.g.
    /// <c>["fr-FR", "en"]</c>); overrides the invoicing entity default.
    /// </summary>
    [JsonPropertyName("preferred_locales")]
    public required IReadOnlyList<string> PreferredLocales { get; init; }

    /// <summary>The <c>shipping_address</c> property.</summary>
    [JsonPropertyName("shipping_address")]
    public ShippingAddress? ShippingAddress { get; init; }

    /// <summary>The <c>vat_number</c> property.</summary>
    [JsonPropertyName("vat_number")]
    public string? VatNumber { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(Customer? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Alias, other.Alias)
        && global::Meteroid.Equality.Equal(BillingAddress, other.BillingAddress)
        && global::Meteroid.Equality.Equal(BillingEmail, other.BillingEmail)
        && global::Meteroid.Equality.Equal(BuyerReference, other.BuyerReference)
        && global::Meteroid.Equality.Equal(ConnectedAccountId, other.ConnectedAccountId)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(CustomProperties, other.CustomProperties)
        && global::Meteroid.Equality.Equal(CustomTaxes, other.CustomTaxes)
        && global::Meteroid.Equality.Equal(CustomerType, other.CustomerType)
        && global::Meteroid.Equality.Equal(FirstName, other.FirstName)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(InvoicingEmails, other.InvoicingEmails)
        && global::Meteroid.Equality.Equal(InvoicingEntityId, other.InvoicingEntityId)
        && global::Meteroid.Equality.Equal(InvoicingLanguage, other.InvoicingLanguage)
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
        hash.Add(global::Meteroid.Equality.Hash(ConnectedAccountId));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(CustomProperties));
        hash.Add(global::Meteroid.Equality.Hash(CustomTaxes));
        hash.Add(global::Meteroid.Equality.Hash(CustomerType));
        hash.Add(global::Meteroid.Equality.Hash(FirstName));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(InvoicingEmails));
        hash.Add(global::Meteroid.Equality.Hash(InvoicingEntityId));
        hash.Add(global::Meteroid.Equality.Hash(InvoicingLanguage));
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
