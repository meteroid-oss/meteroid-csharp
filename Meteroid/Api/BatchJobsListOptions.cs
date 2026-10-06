// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using Meteroid.Models;

namespace Meteroid;

/// <summary>Query and header parameters of <see cref="BatchJobsApi.ListAsync"/>.</summary>
public sealed record BatchJobsListOptions
{
    /// <summary>The <c>job_type</c> query parameter.</summary>
    public BatchJobType? JobType { get; init; }

    /// <summary>The <c>status</c> query parameter.</summary>
    public List<BatchJobStatus>? Status { get; init; }

    /// <summary>
    /// Page number (0-indexed)
    /// </summary>
    public int? Page { get; init; }

    /// <summary>
    /// Number of items per page
    /// </summary>
    public int? PerPage { get; init; }
}
