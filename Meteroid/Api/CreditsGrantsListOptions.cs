// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using Meteroid.Models;

namespace Meteroid;

/// <summary>Query and header parameters of <see cref="CreditsGrantsApi.ListAsync"/>.</summary>
public sealed record CreditsGrantsListOptions
{
    /// <summary>
    /// Only grants in this currency.
    /// </summary>
    public Currency? Currency { get; init; }

    /// <summary>
    /// Only grants in this credit unit (its code); excludes <c>currency</c>.
    /// </summary>
    public string? CreditUnit { get; init; }

    /// <summary>The <c>status</c> query parameter.</summary>
    public CreditGrantStatus? Status { get; init; }

    /// <summary>
    /// Only the grants that belong to this subscription (<c>sub_…</c>); excludes
    /// <c>usable_by_subscription_id</c>.
    /// </summary>
    public string? SubscriptionId { get; init; }

    /// <summary>
    /// Only the credit this subscription (<c>sub_…</c>) can use: its own grants and the customer's
    /// grants that belong to no subscription. Excludes <c>subscription_id</c>.
    /// </summary>
    public string? UsableBySubscriptionId { get; init; }

    /// <summary>
    /// Page number (0-indexed)
    /// </summary>
    public int? Page { get; init; }

    /// <summary>
    /// Number of items per page
    /// </summary>
    public int? PerPage { get; init; }
}
