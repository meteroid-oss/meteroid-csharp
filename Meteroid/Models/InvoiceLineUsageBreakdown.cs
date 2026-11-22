// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>InvoiceLineUsageBreakdown</c> object.</summary>
public sealed partial record InvoiceLineUsageBreakdown
{
    /// <summary>
    /// Largest amount first. Past 99 values, the rest are summed in one last item flagged <c>others</c>.
    /// </summary>
    [JsonPropertyName("items")]
    public required IReadOnlyList<InvoiceLineUsageBreakdownItem> Items { get; init; }

    /// <summary>
    /// The event property the usage is broken down by, e.g. <c>project_id</c>.
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(InvoiceLineUsageBreakdown? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Items, other.Items)
        && global::Meteroid.Equality.Equal(Key, other.Key)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Items));
        hash.Add(global::Meteroid.Equality.Hash(Key));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
