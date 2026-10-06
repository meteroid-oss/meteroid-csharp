// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using Meteroid.Models;

namespace Meteroid;

/// <summary>Query and header parameters of <see cref="FeaturesApi.ListAsync"/>.</summary>
public sealed record FeaturesListOptions
{
    /// <summary>
    /// Filter by feature status. Repeat the param to select multiple, omit to return all.
    /// </summary>
    public List<FeatureStatus>? Statuses { get; init; }

    /// <summary>
    /// Filter by product. Omit to return features across all products.
    /// </summary>
    public string? ProductId { get; init; }

    /// <summary>
    /// Search by feature name.
    /// </summary>
    public string? Search { get; init; }

    /// <summary>
    /// Page number (0-indexed)
    /// </summary>
    public int? Page { get; init; }

    /// <summary>
    /// Number of items per page
    /// </summary>
    public int? PerPage { get; init; }
}
