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

/// <summary>The <c>metrics</c> operations, as <see cref="IMeteroidClient.Metrics"/> exposes them; mock it in tests.</summary>
public interface IMetricsApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IMetricsApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// List billable metrics
    /// </summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<MetricListResponse> ListAsync(
        MetricsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a billable metric
    /// </summary>
    /// <param name="createMetricRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Metric> CreateAsync(
        CreateMetricRequest createMetricRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get metric details
    /// </summary>
    /// <param name="metricId">The <c>metric_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Metric> RetrieveAsync(
        string metricId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a billable metric
    /// </summary>
    /// <remarks>
    /// Partially update metric fields. Code and aggregation_type are immutable.
    /// </remarks>
    /// <param name="metricId">The <c>metric_id</c> path parameter.</param>
    /// <param name="updateMetricRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Metric> UpdateAsync(
        string metricId,
        UpdateMetricRequest updateMetricRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Archive a billable metric
    /// </summary>
    /// <param name="metricId">The <c>metric_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task ArchiveAsync(
        string metricId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Unarchive a billable metric
    /// </summary>
    /// <param name="metricId">The <c>metric_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task UnarchiveAsync(
        string metricId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>metrics</c> operations, returning the status and headers of the response with its body.</summary>
public interface IMetricsApiWithRawResponse
{
    /// <summary><see cref="IMetricsApi.ListAsync"/>, with the status and headers of the response.</summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<MetricListResponse>> ListAsync(
        MetricsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IMetricsApi.CreateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="createMetricRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Metric>> CreateAsync(
        CreateMetricRequest createMetricRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IMetricsApi.RetrieveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="metricId">The <c>metric_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Metric>> RetrieveAsync(
        string metricId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IMetricsApi.UpdateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="metricId">The <c>metric_id</c> path parameter.</param>
    /// <param name="updateMetricRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Metric>> UpdateAsync(
        string metricId,
        UpdateMetricRequest updateMetricRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IMetricsApi.ArchiveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="metricId">The <c>metric_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse> ArchiveAsync(
        string metricId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IMetricsApi.UnarchiveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="metricId">The <c>metric_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse> UnarchiveAsync(
        string metricId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>metrics</c> operations. Get it from <see cref="MeteroidClient.Metrics"/>.</summary>
public sealed partial class MetricsApi : IMetricsApi
{
    internal MetricsApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="IMetricsApi.WithRawResponse"/>
    public MetricsApiWithRawResponse WithRawResponse { get; }

    IMetricsApiWithRawResponse IMetricsApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<MetricListResponse> ListAsync(
        MetricsListOptions? options = null,
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
    public async Task<Metric> CreateAsync(
        CreateMetricRequest createMetricRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CreateAsync(createMetricRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<Metric> RetrieveAsync(
        string metricId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RetrieveAsync(metricId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<Metric> UpdateAsync(
        string metricId,
        UpdateMetricRequest updateMetricRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .UpdateAsync(metricId, updateMetricRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public Task ArchiveAsync(
        string metricId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    ) => WithRawResponse.ArchiveAsync(metricId, requestOptions, cancellationToken);

    /// <inheritdoc/>
    public Task UnarchiveAsync(
        string metricId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    ) => WithRawResponse.UnarchiveAsync(metricId, requestOptions, cancellationToken);
}

/// <summary>The <c>metrics</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class MetricsApiWithRawResponse : IMetricsApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal MetricsApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<MetricListResponse>> ListAsync(
        MetricsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new ApiRequest(HttpMethod.Get, "/api/v1/metrics", "metrics.list");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("product_family_id", options?.ProductFamilyId);
        request.AddQuery("search", options?.Search);
        request.AddQuery("order_by", options?.OrderBy);
        request.AddQuery("page", options?.Page);
        request.AddQuery("per_page", options?.PerPage);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.MetricListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Metric>> CreateAsync(
        CreateMetricRequest createMetricRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(createMetricRequest);

        var request = new ApiRequest(HttpMethod.Post, "/api/v1/metrics", "metrics.create");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(createMetricRequest, MeteroidJsonContext.Default.CreateMetricRequest);
        return _transport.SendJsonAsync(request, MeteroidJsonContext.Default.Metric, requestOptions, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Metric>> RetrieveAsync(
        string metricId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(metricId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/metrics/{Uri.EscapeDataString(metricId)}",
            "metrics.retrieve"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(request, MeteroidJsonContext.Default.Metric, requestOptions, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Metric>> UpdateAsync(
        string metricId,
        UpdateMetricRequest updateMetricRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(metricId);
        ArgumentNullException.ThrowIfNull(updateMetricRequest);

        var request = new ApiRequest(
            HttpMethod.Patch,
            $"/api/v1/metrics/{Uri.EscapeDataString(metricId)}",
            "metrics.update"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(updateMetricRequest, MeteroidJsonContext.Default.UpdateMetricRequest);
        return _transport.SendJsonAsync(request, MeteroidJsonContext.Default.Metric, requestOptions, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<ApiResponse> ArchiveAsync(
        string metricId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(metricId);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/metrics/{Uri.EscapeDataString(metricId)}/archive",
            "metrics.archive"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendAsync(request, requestOptions, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<ApiResponse> UnarchiveAsync(
        string metricId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(metricId);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/metrics/{Uri.EscapeDataString(metricId)}/unarchive",
            "metrics.unarchive"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendAsync(request, requestOptions, cancellationToken);
    }
}
