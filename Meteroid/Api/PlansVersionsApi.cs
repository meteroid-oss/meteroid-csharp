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

/// <summary>The <c>plans.versions</c> operations, as <see cref="IPlansApi.Versions"/> exposes them; mock it in tests.</summary>
public interface IPlansVersionsApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IPlansVersionsApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// Set or replace the plan-level minimum commitment for a draft plan version.
    /// </summary>
    /// <param name="planVersionId">The <c>plan_version_id</c> path parameter.</param>
    /// <param name="minimumCommitment">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<MinimumCommitment> UpdateMinimumAsync(
        string planVersionId,
        MinimumCommitment minimumCommitment,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Remove the plan-level minimum commitment for a draft plan version.
    /// </summary>
    /// <param name="planVersionId">The <c>plan_version_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task DeleteMinimumAsync(
        string planVersionId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List plan versions
    /// </summary>
    /// <param name="planId">The <c>plan_id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <returns>Awaited, the first <see cref="PlansVersionsListPage"/>; enumerated with <c>await foreach</c>,
    /// every item of every page, each page fetched as the enumeration reaches it.</returns>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    AsyncPager<PlansVersionsListPage, PlanVersionSummary> ListAsync(
        string planId,
        PlansVersionsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>plans.versions</c> operations, returning the status and headers of the response with its body.</summary>
public interface IPlansVersionsApiWithRawResponse
{
    /// <summary><see cref="IPlansVersionsApi.UpdateMinimumAsync"/>, with the status and headers of the response.</summary>
    /// <param name="planVersionId">The <c>plan_version_id</c> path parameter.</param>
    /// <param name="minimumCommitment">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<MinimumCommitment>> UpdateMinimumAsync(
        string planVersionId,
        MinimumCommitment minimumCommitment,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IPlansVersionsApi.DeleteMinimumAsync"/>, with the status and headers of the response.</summary>
    /// <param name="planVersionId">The <c>plan_version_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse> DeleteMinimumAsync(
        string planVersionId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>The single request of a page of <see cref="IPlansVersionsApi.ListAsync"/>, with the status and headers of the response.</summary>
    /// <param name="planId">The <c>plan_id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<PlanVersionListResponse>> ListAsync(
        string planId,
        PlansVersionsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>plans.versions</c> operations. Get it from <see cref="PlansApi.Versions"/>.</summary>
public sealed partial class PlansVersionsApi : IPlansVersionsApi
{
    internal PlansVersionsApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="IPlansVersionsApi.WithRawResponse"/>
    public PlansVersionsApiWithRawResponse WithRawResponse { get; }

    IPlansVersionsApiWithRawResponse IPlansVersionsApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<MinimumCommitment> UpdateMinimumAsync(
        string planVersionId,
        MinimumCommitment minimumCommitment,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .UpdateMinimumAsync(planVersionId, minimumCommitment, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public Task DeleteMinimumAsync(
        string planVersionId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    ) => WithRawResponse.DeleteMinimumAsync(planVersionId, requestOptions, cancellationToken);

    /// <inheritdoc/>
    public AsyncPager<PlansVersionsListPage, PlanVersionSummary> ListAsync(
        string planId,
        PlansVersionsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(planId);
        return Paging.Numbered<PlansVersionsListPage, PlanVersionListResponse, PlanVersionSummary>(
            options?.Page ?? 0,
            0,
            pages: true,
            (param, ct) =>
                WithRawResponse.ListAsync(planId, (options ?? new()) with { Page = (int)param }, requestOptions, ct),
            (body, items, next) => new(body, items, next),
            body => body.Data,
            null,
            body => (long?)body.PaginationMeta?.TotalPages,
            cancellationToken
        );
    }
}

/// <summary>The <c>plans.versions</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class PlansVersionsApiWithRawResponse : IPlansVersionsApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal PlansVersionsApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<MinimumCommitment>> UpdateMinimumAsync(
        string planVersionId,
        MinimumCommitment minimumCommitment,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(planVersionId);
        ArgumentNullException.ThrowIfNull(minimumCommitment);

        var request = new ApiRequest(
            HttpMethod.Put,
            $"/api/v1/plans/versions/{Uri.EscapeDataString(planVersionId)}/minimum",
            "plans_versions.update_minimum"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(minimumCommitment, MeteroidJsonContext.Default.MinimumCommitment);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.MinimumCommitment,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse> DeleteMinimumAsync(
        string planVersionId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(planVersionId);

        var request = new ApiRequest(
            HttpMethod.Delete,
            $"/api/v1/plans/versions/{Uri.EscapeDataString(planVersionId)}/minimum",
            "plans_versions.delete_minimum"
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
    public Task<ApiResponse<PlanVersionListResponse>> ListAsync(
        string planId,
        PlansVersionsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(planId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/plans/{Uri.EscapeDataString(planId)}/versions",
            "plans_versions.list"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("page", options?.Page);
        request.AddQuery("per_page", options?.PerPage);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.PlanVersionListResponse,
            requestOptions,
            cancellationToken
        );
    }
}

/// <summary>A page of <see cref="PlansVersionsApi.ListAsync"/>: its <see cref="PlanVersionListResponse"/> body,
/// whose properties it repeats, and the paging members.</summary>
public sealed class PlansVersionsListPage : Page<PlansVersionsListPage, PlanVersionListResponse, PlanVersionSummary>
{
    /// <summary>A page of <paramref name="items"/> from <paramref name="body"/>, for fakes of the operation in tests.</summary>
    /// <param name="body">The decoded response body.</param>
    /// <param name="items">The items of the page.</param>
    /// <param name="next">Fetches the next page; <c>null</c> on the last page.</param>
    public PlansVersionsListPage(
        PlanVersionListResponse body,
        IReadOnlyList<PlanVersionSummary> items,
        Func<CancellationToken, Task<PlansVersionsListPage>>? next = null
    )
        : base(body, items, next) { }

    /// <inheritdoc cref="PlanVersionListResponse.Data"/>
    public IReadOnlyList<PlanVersionSummary> Data => Body.Data;

    /// <inheritdoc cref="PlanVersionListResponse.PaginationMeta"/>
    public PaginationResponse PaginationMeta => Body.PaginationMeta;
}
