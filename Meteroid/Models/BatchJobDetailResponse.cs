// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>BatchJobDetailResponse</c> object.</summary>
public sealed partial record BatchJobDetailResponse
{
    /// <summary>The <c>completed_at</c> property.</summary>
    [JsonPropertyName("completed_at")]
    public DateTimeOffset? CompletedAt { get; init; }

    /// <summary>The <c>created_at</c> property.</summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>The <c>created_by</c> property.</summary>
    [JsonPropertyName("created_by")]
    public required Guid CreatedBy { get; init; }

    /// <summary>The <c>error_csv_url</c> property.</summary>
    [JsonPropertyName("error_csv_url")]
    public string? ErrorCsvUrl { get; init; }

    /// <summary>The <c>failed_items</c> property.</summary>
    [JsonPropertyName("failed_items")]
    public required int FailedItems { get; init; }

    /// <summary>The <c>failure_count</c> property.</summary>
    [JsonPropertyName("failure_count")]
    public required long FailureCount { get; init; }

    /// <summary>The <c>has_error_csv</c> property.</summary>
    [JsonPropertyName("has_error_csv")]
    public required bool HasErrorCsv { get; init; }

    /// <summary>The <c>has_output</c> property.</summary>
    [JsonPropertyName("has_output")]
    public required bool HasOutput { get; init; }

    /// <summary>The <c>id</c> property.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>The <c>input_file_name</c> property.</summary>
    [JsonPropertyName("input_file_name")]
    public string? InputFileName { get; init; }

    /// <summary>The <c>input_file_url</c> property.</summary>
    [JsonPropertyName("input_file_url")]
    public string? InputFileUrl { get; init; }

    /// <summary>The <c>job_type</c> property.</summary>
    [JsonPropertyName("job_type")]
    public required BatchJobType JobType { get; init; }

    /// <summary>The <c>output_url</c> property.</summary>
    [JsonPropertyName("output_url")]
    public string? OutputUrl { get; init; }

    /// <summary>The <c>processed_items</c> property.</summary>
    [JsonPropertyName("processed_items")]
    public required int ProcessedItems { get; init; }

    /// <summary>The <c>status</c> property.</summary>
    [JsonPropertyName("status")]
    public required BatchJobStatus Status { get; init; }

    /// <summary>The <c>total_items</c> property.</summary>
    [JsonPropertyName("total_items")]
    public int? TotalItems { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(BatchJobDetailResponse? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(CompletedAt, other.CompletedAt)
        && global::Meteroid.Equality.Equal(CreatedAt, other.CreatedAt)
        && global::Meteroid.Equality.Equal(CreatedBy, other.CreatedBy)
        && global::Meteroid.Equality.Equal(ErrorCsvUrl, other.ErrorCsvUrl)
        && global::Meteroid.Equality.Equal(FailedItems, other.FailedItems)
        && global::Meteroid.Equality.Equal(FailureCount, other.FailureCount)
        && global::Meteroid.Equality.Equal(HasErrorCsv, other.HasErrorCsv)
        && global::Meteroid.Equality.Equal(HasOutput, other.HasOutput)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(InputFileName, other.InputFileName)
        && global::Meteroid.Equality.Equal(InputFileUrl, other.InputFileUrl)
        && global::Meteroid.Equality.Equal(JobType, other.JobType)
        && global::Meteroid.Equality.Equal(OutputUrl, other.OutputUrl)
        && global::Meteroid.Equality.Equal(ProcessedItems, other.ProcessedItems)
        && global::Meteroid.Equality.Equal(Status, other.Status)
        && global::Meteroid.Equality.Equal(TotalItems, other.TotalItems)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(CompletedAt));
        hash.Add(global::Meteroid.Equality.Hash(CreatedAt));
        hash.Add(global::Meteroid.Equality.Hash(CreatedBy));
        hash.Add(global::Meteroid.Equality.Hash(ErrorCsvUrl));
        hash.Add(global::Meteroid.Equality.Hash(FailedItems));
        hash.Add(global::Meteroid.Equality.Hash(FailureCount));
        hash.Add(global::Meteroid.Equality.Hash(HasErrorCsv));
        hash.Add(global::Meteroid.Equality.Hash(HasOutput));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(InputFileName));
        hash.Add(global::Meteroid.Equality.Hash(InputFileUrl));
        hash.Add(global::Meteroid.Equality.Hash(JobType));
        hash.Add(global::Meteroid.Equality.Hash(OutputUrl));
        hash.Add(global::Meteroid.Equality.Hash(ProcessedItems));
        hash.Add(global::Meteroid.Equality.Hash(Status));
        hash.Add(global::Meteroid.Equality.Hash(TotalItems));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
