// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>PendingScheduledEvent</c> object.</summary>
public sealed partial record PendingScheduledEvent
{
    /// <summary>The <c>cancel_reason</c> property.</summary>
    [JsonPropertyName("cancel_reason")]
    public string? CancelReason { get; init; }

    /// <summary>The <c>customer_initiated</c> property.</summary>
    [JsonPropertyName("customer_initiated")]
    public required bool CustomerInitiated { get; init; }

    /// <summary>The <c>event_type</c> property.</summary>
    [JsonPropertyName("event_type")]
    public required ScheduledEventType EventType { get; init; }

    /// <summary>The <c>id</c> property.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>The <c>new_plan_name</c> property.</summary>
    [JsonPropertyName("new_plan_name")]
    public string? NewPlanName { get; init; }

    /// <summary>The <c>new_plan_version_id</c> property.</summary>
    [JsonPropertyName("new_plan_version_id")]
    public string? NewPlanVersionId { get; init; }

    /// <summary>
    /// Date the event takes effect at the start of
    /// </summary>
    [JsonPropertyName("scheduled_date")]
    public required DateOnly ScheduledDate { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(PendingScheduledEvent? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(CancelReason, other.CancelReason)
        && global::Meteroid.Equality.Equal(CustomerInitiated, other.CustomerInitiated)
        && global::Meteroid.Equality.Equal(EventType, other.EventType)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(NewPlanName, other.NewPlanName)
        && global::Meteroid.Equality.Equal(NewPlanVersionId, other.NewPlanVersionId)
        && global::Meteroid.Equality.Equal(ScheduledDate, other.ScheduledDate)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(CancelReason));
        hash.Add(global::Meteroid.Equality.Hash(CustomerInitiated));
        hash.Add(global::Meteroid.Equality.Hash(EventType));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(NewPlanName));
        hash.Add(global::Meteroid.Equality.Hash(NewPlanVersionId));
        hash.Add(global::Meteroid.Equality.Hash(ScheduledDate));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
