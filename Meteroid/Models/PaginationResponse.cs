// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>PaginationResponse</c> object.</summary>
public sealed partial record PaginationResponse
{
    /// <summary>The <c>page</c> property.</summary>
    [JsonPropertyName("page")]
    public required int Page { get; init; }

    /// <summary>The <c>per_page</c> property.</summary>
    [JsonPropertyName("per_page")]
    public required int PerPage { get; init; }

    /// <summary>The <c>total_items</c> property.</summary>
    [JsonPropertyName("total_items")]
    public required long TotalItems { get; init; }

    /// <summary>The <c>total_pages</c> property.</summary>
    [JsonPropertyName("total_pages")]
    public required int TotalPages { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(PaginationResponse? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Page, other.Page)
        && global::Meteroid.Equality.Equal(PerPage, other.PerPage)
        && global::Meteroid.Equality.Equal(TotalItems, other.TotalItems)
        && global::Meteroid.Equality.Equal(TotalPages, other.TotalPages)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Page));
        hash.Add(global::Meteroid.Equality.Hash(PerPage));
        hash.Add(global::Meteroid.Equality.Hash(TotalItems));
        hash.Add(global::Meteroid.Equality.Hash(TotalPages));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
