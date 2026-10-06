// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using Meteroid.Models;

namespace Meteroid;

/// <summary>Query and header parameters of <see cref="MetricsApi.ListAsync"/>.</summary>
public sealed record MetricsListOptions
{
    /// <summary>The <c>product_family_id</c> query parameter.</summary>
    public string? ProductFamilyId { get; init; }

    /// <summary>
    /// Search by metric name or code
    /// </summary>
    public string? Search { get; init; }

    /// <summary>
    /// Sort order. Format: <c>column.direction</c>. Allowed columns: <c>name</c>, <c>code</c>, <c>created_at</c>. Direction: <c>asc</c> or <c>desc</c>. Default: <c>name.asc</c>.
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
