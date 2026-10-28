// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using Meteroid.Models;

namespace Meteroid;

/// <summary>Query and header parameters of <see cref="UsageCostsCustomerApi.ListEventsAsync"/>; the <c>required</c> ones must be set.</summary>
public sealed record UsageCostsCustomerListEventsOptions
{
    /// <summary>
    /// Billable metric, by ID or code.
    /// </summary>
    public required string Metric { get; init; }

    /// <summary>
    /// Start of the range, inclusive.
    /// </summary>
    public required DateTimeOffset From { get; init; }

    /// <summary>
    /// End of the range, exclusive. At most 93 days after <c>from</c>.
    /// </summary>
    public required DateTimeOffset To { get; init; }

    /// <summary>
    /// The <c>next_cursor</c> of the previous page.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// Page size, 100 by default and 500 at most.
    /// </summary>
    public int? Limit { get; init; }
}
