// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using Meteroid.Models;

namespace Meteroid;

/// <summary>Query and header parameters of <see cref="CustomPropertiesApi.ListCustomPropertyDefinitionsAsync"/>.</summary>
public sealed record CustomPropertiesListCustomPropertyDefinitionsOptions
{
    /// <summary>
    /// Filter to a single entity type.
    /// </summary>
    public CustomPropertyEntityType? EntityType { get; init; }

    /// <summary>
    /// Include archived (soft-deleted) definitions. Defaults to false.
    /// </summary>
    public bool? IncludeArchived { get; init; }

    /// <summary>
    /// Page number (0-indexed)
    /// </summary>
    public int? Page { get; init; }

    /// <summary>
    /// Number of items per page
    /// </summary>
    public int? PerPage { get; init; }
}
