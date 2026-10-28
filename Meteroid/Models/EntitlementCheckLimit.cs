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
/// Deprecated: customer usage limits were replaced by entitlement overrides; never returned.
/// </summary>
public sealed partial record EntitlementCheckLimit
{
    /// <summary>The <c>behavior</c> property.</summary>
    [JsonPropertyName("behavior")]
    public required EntitlementCheckLimitBehavior Behavior { get; init; }

    /// <summary>
    /// The group the limit was evaluated for, when the limit is grouped.
    /// </summary>
    [JsonPropertyName("group")]
    public IReadOnlyDictionary<string, string>? Group { get; init; }

    /// <summary>The <c>has_access</c> property.</summary>
    [JsonPropertyName("has_access")]
    public required bool HasAccess { get; init; }

    /// <summary>The <c>limit</c> property.</summary>
    [JsonPropertyName("limit")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public required decimal Limit { get; init; }

    /// <summary>The <c>remaining</c> property.</summary>
    [JsonPropertyName("remaining")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public required decimal Remaining { get; init; }

    /// <summary>The <c>usage_limit_id</c> property.</summary>
    [JsonPropertyName("usage_limit_id")]
    public required string UsageLimitId { get; init; }

    /// <summary>The <c>used</c> property.</summary>
    [JsonPropertyName("used")]
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)]
    public required decimal Used { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(EntitlementCheckLimit? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Behavior, other.Behavior)
        && global::Meteroid.Equality.Equal(Group, other.Group)
        && global::Meteroid.Equality.Equal(HasAccess, other.HasAccess)
        && global::Meteroid.Equality.Equal(Limit, other.Limit)
        && global::Meteroid.Equality.Equal(Remaining, other.Remaining)
        && global::Meteroid.Equality.Equal(UsageLimitId, other.UsageLimitId)
        && global::Meteroid.Equality.Equal(Used, other.Used)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Behavior));
        hash.Add(global::Meteroid.Equality.Hash(Group));
        hash.Add(global::Meteroid.Equality.Hash(HasAccess));
        hash.Add(global::Meteroid.Equality.Hash(Limit));
        hash.Add(global::Meteroid.Equality.Hash(Remaining));
        hash.Add(global::Meteroid.Equality.Hash(UsageLimitId));
        hash.Add(global::Meteroid.Equality.Hash(Used));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
