// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>BatchJobItemFailureResponse</c> object.</summary>
public sealed partial record BatchJobItemFailureResponse
{
    /// <summary>The <c>chunk_id</c> property.</summary>
    [JsonPropertyName("chunk_id")]
    public required string ChunkId { get; init; }

    /// <summary>The <c>id</c> property.</summary>
    [JsonPropertyName("id")]
    public required Guid Id { get; init; }

    /// <summary>The <c>item_identifier</c> property.</summary>
    [JsonPropertyName("item_identifier")]
    public string? ItemIdentifier { get; init; }

    /// <summary>The <c>item_index</c> property.</summary>
    [JsonPropertyName("item_index")]
    public required int ItemIndex { get; init; }

    /// <summary>The <c>reason</c> property.</summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(BatchJobItemFailureResponse? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(ChunkId, other.ChunkId)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(ItemIdentifier, other.ItemIdentifier)
        && global::Meteroid.Equality.Equal(ItemIndex, other.ItemIndex)
        && global::Meteroid.Equality.Equal(Reason, other.Reason)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(ChunkId));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(ItemIdentifier));
        hash.Add(global::Meteroid.Equality.Hash(ItemIndex));
        hash.Add(global::Meteroid.Equality.Hash(Reason));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
