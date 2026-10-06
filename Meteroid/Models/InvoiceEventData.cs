// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>InvoiceEventData</c> object.</summary>
public sealed partial record InvoiceEventData
{
    /// <summary>The <c>consolidated_into_invoice_id</c> property.</summary>
    [JsonPropertyName("consolidated_into_invoice_id")]
    public string? ConsolidatedIntoInvoiceId { get; init; }

    /// <summary>The <c>created_at</c> property.</summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>The <c>currency</c> property.</summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>
    /// User-defined custom property values, keyed by definition key.
    /// </summary>
    [JsonPropertyName("custom_properties")]
    public required JsonNode CustomProperties { get; init; }

    /// <summary>The <c>customer_id</c> property.</summary>
    [JsonPropertyName("customer_id")]
    public required string CustomerId { get; init; }

    /// <summary>The <c>invoice_id</c> property.</summary>
    [JsonPropertyName("invoice_id")]
    public required string InvoiceId { get; init; }

    /// <summary>
    /// Absent while the invoice is a draft — the number is assigned at finalization.
    /// </summary>
    [JsonPropertyName("invoice_number")]
    public string? InvoiceNumber { get; init; }

    /// <summary>The <c>parent_invoice_id</c> property.</summary>
    [JsonPropertyName("parent_invoice_id")]
    public string? ParentInvoiceId { get; init; }

    /// <summary>The <c>status</c> property.</summary>
    [JsonPropertyName("status")]
    public required InvoiceStatus Status { get; init; }

    /// <summary>The <c>tax_amount</c> property.</summary>
    [JsonPropertyName("tax_amount")]
    public required long TaxAmount { get; init; }

    /// <summary>The <c>total</c> property.</summary>
    [JsonPropertyName("total")]
    public required long Total { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(InvoiceEventData? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(ConsolidatedIntoInvoiceId, other.ConsolidatedIntoInvoiceId)
        && global::Meteroid.Equality.Equal(CreatedAt, other.CreatedAt)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(CustomProperties, other.CustomProperties)
        && global::Meteroid.Equality.Equal(CustomerId, other.CustomerId)
        && global::Meteroid.Equality.Equal(InvoiceId, other.InvoiceId)
        && global::Meteroid.Equality.Equal(InvoiceNumber, other.InvoiceNumber)
        && global::Meteroid.Equality.Equal(ParentInvoiceId, other.ParentInvoiceId)
        && global::Meteroid.Equality.Equal(Status, other.Status)
        && global::Meteroid.Equality.Equal(TaxAmount, other.TaxAmount)
        && global::Meteroid.Equality.Equal(Total, other.Total)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(ConsolidatedIntoInvoiceId));
        hash.Add(global::Meteroid.Equality.Hash(CreatedAt));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(CustomProperties));
        hash.Add(global::Meteroid.Equality.Hash(CustomerId));
        hash.Add(global::Meteroid.Equality.Hash(InvoiceId));
        hash.Add(global::Meteroid.Equality.Hash(InvoiceNumber));
        hash.Add(global::Meteroid.Equality.Hash(ParentInvoiceId));
        hash.Add(global::Meteroid.Equality.Hash(Status));
        hash.Add(global::Meteroid.Equality.Hash(TaxAmount));
        hash.Add(global::Meteroid.Equality.Hash(Total));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
