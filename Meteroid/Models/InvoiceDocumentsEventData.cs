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
/// Emitted once the accounting PDF is stored. This is also the moment the e-invoicing
/// outcome is known: the structured document is produced with the PDF, not at finalization.
/// </summary>
public sealed partial record InvoiceDocumentsEventData
{
    /// <summary>The <c>customer_id</c> property.</summary>
    [JsonPropertyName("customer_id")]
    public required string CustomerId { get; init; }

    /// <summary>
    /// Set when generation failed for a reason that is not a business rule.
    /// </summary>
    [JsonPropertyName("einvoicing_error")]
    public string? EinvoicingError { get; init; }

    /// <summary>
    /// Empty unless the status is <c>failed</c>.
    /// </summary>
    [JsonPropertyName("einvoicing_findings")]
    public required IReadOnlyList<EInvoicingFinding> EinvoicingFindings { get; init; }

    /// <summary>
    /// The profile the document was checked against, e.g. "EN 16931".
    /// </summary>
    [JsonPropertyName("einvoicing_profile")]
    public string? EinvoicingProfile { get; init; }

    /// <summary>The <c>einvoicing_status</c> property.</summary>
    [JsonPropertyName("einvoicing_status")]
    public EInvoicingStatus? EinvoicingStatus { get; init; }

    /// <summary>The <c>invoice_id</c> property.</summary>
    [JsonPropertyName("invoice_id")]
    public required string InvoiceId { get; init; }

    /// <summary>The <c>pdf_document_id</c> property.</summary>
    [JsonPropertyName("pdf_document_id")]
    public required string PdfDocumentId { get; init; }

    /// <summary>
    /// The structured e-invoice stored beside the PDF, when one was produced.
    /// </summary>
    [JsonPropertyName("xml_document_id")]
    public string? XmlDocumentId { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(InvoiceDocumentsEventData? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(CustomerId, other.CustomerId)
        && global::Meteroid.Equality.Equal(EinvoicingError, other.EinvoicingError)
        && global::Meteroid.Equality.Equal(EinvoicingFindings, other.EinvoicingFindings)
        && global::Meteroid.Equality.Equal(EinvoicingProfile, other.EinvoicingProfile)
        && global::Meteroid.Equality.Equal(EinvoicingStatus, other.EinvoicingStatus)
        && global::Meteroid.Equality.Equal(InvoiceId, other.InvoiceId)
        && global::Meteroid.Equality.Equal(PdfDocumentId, other.PdfDocumentId)
        && global::Meteroid.Equality.Equal(XmlDocumentId, other.XmlDocumentId)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(CustomerId));
        hash.Add(global::Meteroid.Equality.Hash(EinvoicingError));
        hash.Add(global::Meteroid.Equality.Hash(EinvoicingFindings));
        hash.Add(global::Meteroid.Equality.Hash(EinvoicingProfile));
        hash.Add(global::Meteroid.Equality.Hash(EinvoicingStatus));
        hash.Add(global::Meteroid.Equality.Hash(InvoiceId));
        hash.Add(global::Meteroid.Equality.Hash(PdfDocumentId));
        hash.Add(global::Meteroid.Equality.Hash(XmlDocumentId));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
