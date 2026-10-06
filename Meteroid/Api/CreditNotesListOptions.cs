// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using Meteroid.Models;

namespace Meteroid;

/// <summary>Query and header parameters of <see cref="CreditNotesApi.ListAsync"/>.</summary>
public sealed record CreditNotesListOptions
{
    /// <summary>
    /// Filter by customer ID
    /// </summary>
    public string? CustomerId { get; init; }

    /// <summary>
    /// Filter by invoice ID
    /// </summary>
    public string? InvoiceId { get; init; }

    /// <summary>The <c>status</c> query parameter.</summary>
    public CreditNoteStatus? Status { get; init; }

    /// <summary>
    /// Free-text search over credit note number.
    /// </summary>
    public string? Search { get; init; }

    /// <summary>
    /// Sort order. Format: <c>column.direction</c>. Allowed columns: <c>created_at</c>, <c>credit_note_number</c>, <c>total</c>, <c>status</c>. Direction: <c>asc</c> or <c>desc</c>. Default: <c>created_at.desc</c>.
    /// </summary>
    public string? OrderBy { get; init; }

    /// <summary>
    /// Page number (0-indexed)
    /// </summary>
    public int? Page { get; init; }

    /// <summary>
    /// Number of items per page
    /// </summary>
    public int? PerPage { get; init; }
}
