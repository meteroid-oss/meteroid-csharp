// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using Meteroid.Models;

namespace Meteroid;

/// <summary>Query and header parameters of <see cref="InvoicesApi.ListAsync"/>.</summary>
public sealed record InvoicesListOptions
{
    /// <summary>
    /// Filter by customer ID or alias
    /// </summary>
    public string? CustomerId { get; init; }

    /// <summary>The <c>subscription_id</c> query parameter.</summary>
    public string? SubscriptionId { get; init; }

    /// <summary>The <c>statuses</c> query parameter.</summary>
    public List<InvoiceStatus>? Statuses { get; init; }

    /// <summary>
    /// Only invoices whose e-invoice was generated, or failed. Invoices from entities that
    /// had not opted in carry no status and match neither.
    /// </summary>
    public EInvoicingStatus? EinvoicingStatus { get; init; }

    /// <summary>
    /// Sort order. Format: <c>column.direction</c>. Allowed columns: <c>invoice_number</c>, <c>customer_name</c>, <c>amount</c>, <c>invoice_date</c>, <c>status</c>, <c>payment_status</c>. Direction: <c>asc</c> or <c>desc</c>. Default: <c>invoice_date.desc</c>.
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
