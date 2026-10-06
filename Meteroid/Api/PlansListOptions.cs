// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using Meteroid.Models;

namespace Meteroid;

/// <summary>Query and header parameters of <see cref="PlansApi.ListAsync"/>.</summary>
public sealed record PlansListOptions
{
    /// <summary>The <c>product_family_id</c> query parameter.</summary>
    public string? ProductFamilyId { get; init; }

    /// <summary>
    /// Search by plan name
    /// </summary>
    public string? Search { get; init; }

    /// <summary>
    /// Filter by plan status (can be repeated)
    /// </summary>
    public List<PlanStatusEnum>? Status { get; init; }

    /// <summary>
    /// Filter by plan type (can be repeated)
    /// </summary>
    public List<PlanTypeEnum>? PlanType { get; init; }

    /// <summary>
    /// Sort order. Format: <c>column.direction</c>. Allowed columns: <c>name</c>, <c>status</c>, <c>plan_type</c>, <c>created_at</c>. Direction: <c>asc</c> or <c>desc</c>. Default: <c>created_at.desc</c>.
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
