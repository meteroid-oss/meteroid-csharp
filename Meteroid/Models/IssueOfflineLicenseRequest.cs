// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>IssueOfflineLicenseRequest</c> object.</summary>
public sealed partial record IssueOfflineLicenseRequest
{
    /// <summary>
    /// The installation's id as it reports it, up to 255 characters without spaces: the license
    /// names it (<c>aud</c>) and stays bound to it. Without one, the license is not tied to one.
    /// </summary>
    [JsonPropertyName("instance_id")]
    public string? InstanceId { get; init; }

    /// <summary>
    /// Lifetime of the offline license, 1 to 400 days.
    /// </summary>
    [JsonPropertyName("valid_days")]
    public required int ValidDays { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(IssueOfflineLicenseRequest? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(InstanceId, other.InstanceId)
        && global::Meteroid.Equality.Equal(ValidDays, other.ValidDays)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(InstanceId));
        hash.Add(global::Meteroid.Equality.Hash(ValidDays));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
