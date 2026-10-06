// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using Meteroid.Models;

namespace Meteroid;

/// <summary>Query and header parameters of <see cref="SubscriptionsApi.ListAsync"/>.</summary>
public sealed record SubscriptionsListOptions
{
    /// <summary>
    /// Filter by customer ID or alias
    /// </summary>
    public string? CustomerId { get; init; }

    /// <summary>The <c>plan_id</c> query parameter.</summary>
    public string? PlanId { get; init; }

    /// <summary>The <c>statuses</c> query parameter.</summary>
    public List<SubscriptionStatusEnum>? Statuses { get; init; }

    /// <summary>
    /// Sort order. Format: <c>column.direction</c>. Allowed columns: <c>customer_name</c>, <c>plan_name</c>, <c>mrr_cents</c>, <c>billing_start_date</c>, <c>end_date</c>, <c>status</c>, <c>created_at</c>. Direction: <c>asc</c> or <c>desc</c>. Default: <c>created_at.desc</c>.
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
