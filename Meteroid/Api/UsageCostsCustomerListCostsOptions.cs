// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using Meteroid.Models;

namespace Meteroid;

/// <summary>Query and header parameters of <see cref="UsageCostsCustomerApi.ListCostsAsync"/>; the <c>required</c> ones must be set.</summary>
public sealed record UsageCostsCustomerListCostsOptions
{
    /// <summary>
    /// Billable metric, by ID or code.
    /// </summary>
    public required string Metric { get; init; }

    /// <summary>
    /// Event property to split the usage by.
    /// </summary>
    public string? GroupBy { get; init; }

    /// <summary>The <c>granularity</c> query parameter.</summary>
    public required ListCustomerUsageCostsGranularity Granularity { get; init; }

    /// <summary>
    /// Start of the range, inclusive.
    /// </summary>
    public required DateTimeOffset From { get; init; }

    /// <summary>
    /// End of the range, exclusive. At most 93 days after <c>from</c>.
    /// </summary>
    public required DateTimeOffset To { get; init; }
}
