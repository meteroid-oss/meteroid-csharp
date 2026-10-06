// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization.Metadata;
using System.Threading;
using System.Threading.Tasks;
using Meteroid.Models;

namespace Meteroid;

/// <summary>The <c>batch_jobs</c> operations, as <see cref="IMeteroidClient.BatchJobs"/> exposes them; mock it in tests.</summary>
public interface IBatchJobsApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IBatchJobsApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// List batch jobs with optional filtering by type and status.
    /// </summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<BatchJobListResponse> ListAsync(
        BatchJobsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get batch job detail
    /// </summary>
    /// <remarks>
    /// Retrieve a single batch job with its chunks and failures.
    /// </remarks>
    /// <param name="batchJobId">The <c>batch_job_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<BatchJobDetailResponse> RetrieveAsync(
        string batchJobId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List batch job failures
    /// </summary>
    /// <remarks>
    /// Retrieve paginated failures for a batch job.
    /// </remarks>
    /// <param name="batchJobId">The <c>batch_job_id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<BatchJobFailuresResponse> ListFailuresAsync(
        string batchJobId,
        BatchJobsListFailuresOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>batch_jobs</c> operations, returning the status and headers of the response with its body.</summary>
public interface IBatchJobsApiWithRawResponse
{
    /// <summary><see cref="IBatchJobsApi.ListAsync"/>, with the status and headers of the response.</summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<BatchJobListResponse>> ListAsync(
        BatchJobsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IBatchJobsApi.RetrieveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="batchJobId">The <c>batch_job_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<BatchJobDetailResponse>> RetrieveAsync(
        string batchJobId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IBatchJobsApi.ListFailuresAsync"/>, with the status and headers of the response.</summary>
    /// <param name="batchJobId">The <c>batch_job_id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<BatchJobFailuresResponse>> ListFailuresAsync(
        string batchJobId,
        BatchJobsListFailuresOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>batch_jobs</c> operations. Get it from <see cref="MeteroidClient.BatchJobs"/>.</summary>
public sealed partial class BatchJobsApi : IBatchJobsApi
{
    internal BatchJobsApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="IBatchJobsApi.WithRawResponse"/>
    public BatchJobsApiWithRawResponse WithRawResponse { get; }

    IBatchJobsApiWithRawResponse IBatchJobsApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<BatchJobListResponse> ListAsync(
        BatchJobsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .ListAsync(options, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<BatchJobDetailResponse> RetrieveAsync(
        string batchJobId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RetrieveAsync(batchJobId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<BatchJobFailuresResponse> ListFailuresAsync(
        string batchJobId,
        BatchJobsListFailuresOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .ListFailuresAsync(batchJobId, options, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>batch_jobs</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class BatchJobsApiWithRawResponse : IBatchJobsApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal BatchJobsApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<BatchJobListResponse>> ListAsync(
        BatchJobsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new ApiRequest(HttpMethod.Get, "/api/v1/batch-jobs", "batch_jobs.list");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("job_type", options?.JobType);
        request.AddQuery("status", options?.Status);
        request.AddQuery("page", options?.Page);
        request.AddQuery("per_page", options?.PerPage);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.BatchJobListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<BatchJobDetailResponse>> RetrieveAsync(
        string batchJobId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(batchJobId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/batch-jobs/{Uri.EscapeDataString(batchJobId)}",
            "batch_jobs.retrieve"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.BatchJobDetailResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<BatchJobFailuresResponse>> ListFailuresAsync(
        string batchJobId,
        BatchJobsListFailuresOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(batchJobId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/batch-jobs/{Uri.EscapeDataString(batchJobId)}/failures",
            "batch_jobs.list_failures"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("chunk_id", options?.ChunkId);
        request.AddQuery("limit", options?.Limit);
        request.AddQuery("offset", options?.Offset);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.BatchJobFailuresResponse,
            requestOptions,
            cancellationToken
        );
    }
}
