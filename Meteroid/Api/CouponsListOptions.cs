// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using Meteroid.Models;

namespace Meteroid;

/// <summary>Query and header parameters of <see cref="CouponsApi.ListAsync"/>.</summary>
public sealed record CouponsListOptions
{
    /// <summary>The <c>search</c> query parameter.</summary>
    public string? Search { get; init; }

    /// <summary>The <c>filter</c> query parameter.</summary>
    public CouponFilter? Filter { get; init; }

    /// <summary>
    /// Sort order. Format: <c>column.direction</c>. Allowed columns: <c>code</c>, <c>created_at</c>, <c>expires_at</c>. Direction: <c>asc</c> or <c>desc</c>. Default: <c>created_at.desc</c>.
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
