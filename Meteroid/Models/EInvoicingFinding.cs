// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One rule the document did not satisfy, in the standard's own vocabulary.
/// </summary>
public sealed partial record EInvoicingFinding
{
    /// <summary>The <c>hint</c> property.</summary>
    [JsonPropertyName("hint")]
    public string? Hint { get; init; }

    /// <summary>The <c>message</c> property.</summary>
    [JsonPropertyName("message")]
    public required string Message { get; init; }

    /// <summary>
    /// The rule identifier — "BR-11", "PEPPOL-EN16931-R003".
    /// </summary>
    [JsonPropertyName("rule")]
    public required string Rule { get; init; }

    /// <summary>
    /// The business term path it is about — "BG-8/BT-55".
    /// </summary>
    [JsonPropertyName("term")]
    public required string Term { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(EInvoicingFinding? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Hint, other.Hint)
        && global::Meteroid.Equality.Equal(Message, other.Message)
        && global::Meteroid.Equality.Equal(Rule, other.Rule)
        && global::Meteroid.Equality.Equal(Term, other.Term)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Hint));
        hash.Add(global::Meteroid.Equality.Hash(Message));
        hash.Add(global::Meteroid.Equality.Hash(Rule));
        hash.Add(global::Meteroid.Equality.Hash(Term));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
