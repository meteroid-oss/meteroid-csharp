// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using Meteroid.Models;

namespace Meteroid;

/// <summary>Query and header parameters of <see cref="ChecksApi.CheckEntitlementAsync"/>.</summary>
public sealed record ChecksCheckEntitlementOptions
{
    /// <summary>
    /// Units the customer is about to consume. Defaults to 1.
    /// </summary>
    public decimal? Requested { get; init; }

    /// <summary>
    /// The subscription (<c>sub_…</c>) the usage belongs to: only its own budgets and the customer-wide
    /// ones apply. Without it, a budget on one subscription refuses only once every subscription
    /// charging the feature's metric is refused by its own budget.
    /// </summary>
    public string? SubscriptionId { get; init; }

    /// <summary>
    /// The group to check, as <c>group[&lt;property&gt;]=&lt;value&gt;</c>: required when the entitlement is grouped
    /// </summary>
    public Dictionary<string, string>? Group { get; init; }
}
