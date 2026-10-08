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

/// <summary>The <c>plans</c> operations, as <see cref="IMeteroidClient.Plans"/> exposes them; mock it in tests.</summary>
public interface IPlansApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IPlansApiWithRawResponse WithRawResponse { get; }

    /// <summary>The <c>versions</c> operations.</summary>
    IPlansVersionsApi Versions { get; }

    /// <summary>
    /// List plan version entitlements
    /// </summary>
    /// <param name="planVersionId">The <c>plan_version_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<ResolvedEntitlementListResponse> ListPlanVersionEntitlementsAsync(
        string planVersionId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create plan version entitlements
    /// </summary>
    /// <remarks>
    /// Entitlements already present on this plan version are skipped.
    /// </remarks>
    /// <param name="planVersionId">The <c>plan_version_id</c> path parameter.</param>
    /// <param name="createEntitlementsRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<EntitlementListResponse> CreatePlanVersionEntitlementAsync(
        string planVersionId,
        CreateEntitlementsRequest createEntitlementsRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List plans
    /// </summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <returns>Awaited, the first <see cref="PlansListPage"/>; enumerated with <c>await foreach</c>,
    /// every item of every page, each page fetched as the enumeration reaches it.</returns>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    AsyncPager<PlansListPage, Plan> ListAsync(
        PlansListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a plan
    /// </summary>
    /// <remarks>
    /// Create a new plan with components and pricing. Set <c>status</c> to <c>ACTIVE</c> to
    /// publish immediately, or <c>DRAFT</c> to stage for review.
    /// </remarks>
    /// <param name="createPlanRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ConflictException">409: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Plan> CreateAsync(
        CreatePlanRequest createPlanRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get plan details
    /// </summary>
    /// <remarks>
    /// Retrieve a specific plan. Use <c>?version=draft</c> for the draft version,
    /// <c>?version=2</c> for a specific version number, or omit for the active version.
    /// </remarks>
    /// <param name="planId">The <c>plan_id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Plan> RetrieveAsync(
        string planId,
        PlansRetrieveOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Replace a plan
    /// </summary>
    /// <remarks>
    /// Full replacement of a plan's version. On a draft plan, updates in-place.
    /// On a published plan, creates a new version. Set <c>status</c> to <c>DRAFT</c> to
    /// stage as a new draft without publishing.
    /// </remarks>
    /// <param name="planId">The <c>plan_id</c> path parameter.</param>
    /// <param name="replacePlanRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Plan> ReplaceAsync(
        string planId,
        ReplacePlanRequest replacePlanRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update plan metadata
    /// </summary>
    /// <remarks>
    /// Partially update plan-level fields (name, description, self_service_rank).
    /// Does not modify version-level configuration or components.
    /// </remarks>
    /// <param name="planId">The <c>plan_id</c> path parameter.</param>
    /// <param name="patchPlanRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Plan> UpdateAsync(
        string planId,
        PatchPlanRequest patchPlanRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Archive a plan
    /// </summary>
    /// <param name="planId">The <c>plan_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task ArchiveAsync(
        string planId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Publish a draft plan version
    /// </summary>
    /// <remarks>
    /// Publishes the current draft version, making it the active version.
    /// </remarks>
    /// <param name="planId">The <c>plan_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ConflictException">409: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Plan> PublishAsync(
        string planId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Unarchive a plan
    /// </summary>
    /// <param name="planId">The <c>plan_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task UnarchiveAsync(
        string planId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>plans</c> operations, returning the status and headers of the response with its body.</summary>
public interface IPlansApiWithRawResponse
{
    /// <summary>The <c>versions</c> operations, returning the status and headers of the response with its body.</summary>
    IPlansVersionsApiWithRawResponse Versions { get; }

    /// <summary><see cref="IPlansApi.ListPlanVersionEntitlementsAsync"/>, with the status and headers of the response.</summary>
    /// <param name="planVersionId">The <c>plan_version_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<ResolvedEntitlementListResponse>> ListPlanVersionEntitlementsAsync(
        string planVersionId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IPlansApi.CreatePlanVersionEntitlementAsync"/>, with the status and headers of the response.</summary>
    /// <param name="planVersionId">The <c>plan_version_id</c> path parameter.</param>
    /// <param name="createEntitlementsRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<EntitlementListResponse>> CreatePlanVersionEntitlementAsync(
        string planVersionId,
        CreateEntitlementsRequest createEntitlementsRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>The single request of a page of <see cref="IPlansApi.ListAsync"/>, with the status and headers of the response.</summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<PlanListResponse>> ListAsync(
        PlansListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IPlansApi.CreateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="createPlanRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Plan>> CreateAsync(
        CreatePlanRequest createPlanRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IPlansApi.RetrieveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="planId">The <c>plan_id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Plan>> RetrieveAsync(
        string planId,
        PlansRetrieveOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IPlansApi.ReplaceAsync"/>, with the status and headers of the response.</summary>
    /// <param name="planId">The <c>plan_id</c> path parameter.</param>
    /// <param name="replacePlanRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Plan>> ReplaceAsync(
        string planId,
        ReplacePlanRequest replacePlanRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IPlansApi.UpdateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="planId">The <c>plan_id</c> path parameter.</param>
    /// <param name="patchPlanRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Plan>> UpdateAsync(
        string planId,
        PatchPlanRequest patchPlanRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IPlansApi.ArchiveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="planId">The <c>plan_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse> ArchiveAsync(
        string planId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IPlansApi.PublishAsync"/>, with the status and headers of the response.</summary>
    /// <param name="planId">The <c>plan_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Plan>> PublishAsync(
        string planId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IPlansApi.UnarchiveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="planId">The <c>plan_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse> UnarchiveAsync(
        string planId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>plans</c> operations. Get it from <see cref="MeteroidClient.Plans"/>.</summary>
public sealed partial class PlansApi : IPlansApi
{
    internal PlansApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
        Versions = new(transport);
    }

    /// <inheritdoc cref="IPlansApi.WithRawResponse"/>
    public PlansApiWithRawResponse WithRawResponse { get; }

    IPlansApiWithRawResponse IPlansApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc cref="IPlansApi.Versions"/>
    public PlansVersionsApi Versions { get; }

    IPlansVersionsApi IPlansApi.Versions => Versions;

    /// <inheritdoc/>
    public async Task<ResolvedEntitlementListResponse> ListPlanVersionEntitlementsAsync(
        string planVersionId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .ListPlanVersionEntitlementsAsync(planVersionId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<EntitlementListResponse> CreatePlanVersionEntitlementAsync(
        string planVersionId,
        CreateEntitlementsRequest createEntitlementsRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CreatePlanVersionEntitlementAsync(
                planVersionId,
                createEntitlementsRequest,
                requestOptions,
                cancellationToken
            )
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public AsyncPager<PlansListPage, Plan> ListAsync(
        PlansListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        return Paging.Numbered<PlansListPage, PlanListResponse, Plan>(
            options?.Page ?? 0,
            0,
            pages: true,
            (param, ct) => WithRawResponse.ListAsync((options ?? new()) with { Page = (int)param }, requestOptions, ct),
            (body, items, next) => new(body, items, next),
            body => body.Data,
            null,
            body => (long?)body.PaginationMeta?.TotalPages,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public async Task<Plan> CreateAsync(
        CreatePlanRequest createPlanRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CreateAsync(createPlanRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<Plan> RetrieveAsync(
        string planId,
        PlansRetrieveOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RetrieveAsync(planId, options, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<Plan> ReplaceAsync(
        string planId,
        ReplacePlanRequest replacePlanRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .ReplaceAsync(planId, replacePlanRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<Plan> UpdateAsync(
        string planId,
        PatchPlanRequest patchPlanRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .UpdateAsync(planId, patchPlanRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public Task ArchiveAsync(
        string planId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    ) => WithRawResponse.ArchiveAsync(planId, requestOptions, cancellationToken);

    /// <inheritdoc/>
    public async Task<Plan> PublishAsync(
        string planId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .PublishAsync(planId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public Task UnarchiveAsync(
        string planId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    ) => WithRawResponse.UnarchiveAsync(planId, requestOptions, cancellationToken);
}

/// <summary>The <c>plans</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class PlansApiWithRawResponse : IPlansApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal PlansApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
        Versions = new(transport);
    }

    /// <inheritdoc cref="IPlansApiWithRawResponse.Versions"/>
    public PlansVersionsApiWithRawResponse Versions { get; }

    IPlansVersionsApiWithRawResponse IPlansApiWithRawResponse.Versions => Versions;

    /// <inheritdoc/>
    public Task<ApiResponse<ResolvedEntitlementListResponse>> ListPlanVersionEntitlementsAsync(
        string planVersionId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(planVersionId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/plan-versions/{Uri.EscapeDataString(planVersionId)}/entitlements",
            "plans.list_plan_version_entitlements"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.ResolvedEntitlementListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<EntitlementListResponse>> CreatePlanVersionEntitlementAsync(
        string planVersionId,
        CreateEntitlementsRequest createEntitlementsRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(planVersionId);
        ArgumentNullException.ThrowIfNull(createEntitlementsRequest);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/plan-versions/{Uri.EscapeDataString(planVersionId)}/entitlements",
            "plans.create_plan_version_entitlement"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(createEntitlementsRequest, MeteroidJsonContext.Default.CreateEntitlementsRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.EntitlementListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<PlanListResponse>> ListAsync(
        PlansListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new ApiRequest(HttpMethod.Get, "/api/v1/plans", "plans.list");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("product_family_id", options?.ProductFamilyId);
        request.AddQuery("search", options?.Search);
        request.AddQuery("status", options?.Status);
        request.AddQuery("plan_type", options?.PlanType);
        request.AddQuery("order_by", options?.OrderBy);
        request.AddQuery("page", options?.Page);
        request.AddQuery("per_page", options?.PerPage);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.PlanListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Plan>> CreateAsync(
        CreatePlanRequest createPlanRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(createPlanRequest);

        var request = new ApiRequest(HttpMethod.Post, "/api/v1/plans", "plans.create");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("409", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(createPlanRequest, MeteroidJsonContext.Default.CreatePlanRequest);
        return _transport.SendJsonAsync(request, MeteroidJsonContext.Default.Plan, requestOptions, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Plan>> RetrieveAsync(
        string planId,
        PlansRetrieveOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(planId);

        var request = new ApiRequest(HttpMethod.Get, $"/api/v1/plans/{Uri.EscapeDataString(planId)}", "plans.retrieve");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("version", options?.Version);
        return _transport.SendJsonAsync(request, MeteroidJsonContext.Default.Plan, requestOptions, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Plan>> ReplaceAsync(
        string planId,
        ReplacePlanRequest replacePlanRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(planId);
        ArgumentNullException.ThrowIfNull(replacePlanRequest);

        var request = new ApiRequest(HttpMethod.Put, $"/api/v1/plans/{Uri.EscapeDataString(planId)}", "plans.replace");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(replacePlanRequest, MeteroidJsonContext.Default.ReplacePlanRequest);
        return _transport.SendJsonAsync(request, MeteroidJsonContext.Default.Plan, requestOptions, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Plan>> UpdateAsync(
        string planId,
        PatchPlanRequest patchPlanRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(planId);
        ArgumentNullException.ThrowIfNull(patchPlanRequest);

        var request = new ApiRequest(HttpMethod.Patch, $"/api/v1/plans/{Uri.EscapeDataString(planId)}", "plans.update");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(patchPlanRequest, MeteroidJsonContext.Default.PatchPlanRequest);
        return _transport.SendJsonAsync(request, MeteroidJsonContext.Default.Plan, requestOptions, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<ApiResponse> ArchiveAsync(
        string planId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(planId);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/plans/{Uri.EscapeDataString(planId)}/archive",
            "plans.archive"
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
    public Task<ApiResponse<Plan>> PublishAsync(
        string planId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(planId);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/plans/{Uri.EscapeDataString(planId)}/publish",
            "plans.publish"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("409", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(request, MeteroidJsonContext.Default.Plan, requestOptions, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<ApiResponse> UnarchiveAsync(
        string planId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(planId);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/plans/{Uri.EscapeDataString(planId)}/unarchive",
            "plans.unarchive"
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

/// <summary>A page of <see cref="PlansApi.ListAsync"/>: its <see cref="PlanListResponse"/> body,
/// whose properties it repeats, and the paging members.</summary>
public sealed class PlansListPage : Page<PlansListPage, PlanListResponse, Plan>
{
    /// <summary>A page of <paramref name="items"/> from <paramref name="body"/>, for fakes of the operation in tests.</summary>
    /// <param name="body">The decoded response body.</param>
    /// <param name="items">The items of the page.</param>
    /// <param name="next">Fetches the next page; <c>null</c> on the last page.</param>
    public PlansListPage(
        PlanListResponse body,
        IReadOnlyList<Plan> items,
        Func<CancellationToken, Task<PlansListPage>>? next = null
    )
        : base(body, items, next) { }

    /// <inheritdoc cref="PlanListResponse.Data"/>
    public IReadOnlyList<Plan> Data => Body.Data;

    /// <inheritdoc cref="PlanListResponse.PaginationMeta"/>
    public PaginationResponse PaginationMeta => Body.PaginationMeta;
}
