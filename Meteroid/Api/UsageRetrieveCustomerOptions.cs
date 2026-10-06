// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using Meteroid.Models;

namespace Meteroid;

/// <summary>Query and header parameters of <see cref="UsageApi.RetrieveCustomerAsync"/>; the <c>required</c> ones must be set.</summary>
public sealed record UsageRetrieveCustomerOptions
{
    /// <summary>The <c>start_date</c> query parameter.</summary>
    public required DateOnly StartDate { get; init; }

    /// <summary>The <c>end_date</c> query parameter.</summary>
    public required DateOnly EndDate { get; init; }

    /// <summary>The <c>metric_id</c> query parameter.</summary>
    public string? MetricId { get; init; }
}
