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

/// <summary>The <c>add_ons</c> operations, as <see cref="IMeteroidClient.AddOns"/> exposes them; mock it in tests.</summary>
public interface IAddOnsApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IAddOnsApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// List add-ons
    /// </summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <returns>Awaited, the first <see cref="AddOnsListPage"/>; enumerated with <c>await foreach</c>,
    /// every item of every page, each page fetched as the enumeration reaches it.</returns>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    AsyncPager<AddOnsListPage, AddOn> ListAsync(
        AddOnsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create an add-on
    /// </summary>
    /// <param name="createAddOnRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<AddOn> CreateAsync(
        CreateAddOnRequest createAddOnRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get add-on details
    /// </summary>
    /// <param name="addonId">The <c>addon_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<AddOn> RetrieveAsync(
        string addonId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update an add-on
    /// </summary>
    /// <param name="addonId">The <c>addon_id</c> path parameter.</param>
    /// <param name="updateAddOnRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<AddOn> UpdateAsync(
        string addonId,
        UpdateAddOnRequest updateAddOnRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Archive an add-on
    /// </summary>
    /// <param name="addonId">The <c>addon_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task ArchiveAsync(
        string addonId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List add-on entitlements
    /// </summary>
    /// <param name="addonId">The <c>addon_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<ResolvedEntitlementListResponse> ListEntitlementsAsync(
        string addonId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create add-on entitlements
    /// </summary>
    /// <remarks>
    /// Entitlements already present on this add-on are skipped.
    /// </remarks>
    /// <param name="addonId">The <c>addon_id</c> path parameter.</param>
    /// <param name="createEntitlementsRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<EntitlementListResponse> CreateEntitlementAsync(
        string addonId,
        CreateEntitlementsRequest createEntitlementsRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Unarchive an add-on
    /// </summary>
    /// <param name="addonId">The <c>addon_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task UnarchiveAsync(
        string addonId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>add_ons</c> operations, returning the status and headers of the response with its body.</summary>
public interface IAddOnsApiWithRawResponse
{
    /// <summary>The single request of a page of <see cref="IAddOnsApi.ListAsync"/>, with the status and headers of the response.</summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<AddOnListResponse>> ListAsync(
        AddOnsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IAddOnsApi.CreateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="createAddOnRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<AddOn>> CreateAsync(
        CreateAddOnRequest createAddOnRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IAddOnsApi.RetrieveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="addonId">The <c>addon_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<AddOn>> RetrieveAsync(
        string addonId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IAddOnsApi.UpdateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="addonId">The <c>addon_id</c> path parameter.</param>
    /// <param name="updateAddOnRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<AddOn>> UpdateAsync(
        string addonId,
        UpdateAddOnRequest updateAddOnRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IAddOnsApi.ArchiveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="addonId">The <c>addon_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse> ArchiveAsync(
        string addonId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IAddOnsApi.ListEntitlementsAsync"/>, with the status and headers of the response.</summary>
    /// <param name="addonId">The <c>addon_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<ResolvedEntitlementListResponse>> ListEntitlementsAsync(
        string addonId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IAddOnsApi.CreateEntitlementAsync"/>, with the status and headers of the response.</summary>
    /// <param name="addonId">The <c>addon_id</c> path parameter.</param>
    /// <param name="createEntitlementsRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<EntitlementListResponse>> CreateEntitlementAsync(
        string addonId,
        CreateEntitlementsRequest createEntitlementsRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IAddOnsApi.UnarchiveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="addonId">The <c>addon_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse> UnarchiveAsync(
        string addonId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>add_ons</c> operations. Get it from <see cref="MeteroidClient.AddOns"/>.</summary>
public sealed partial class AddOnsApi : IAddOnsApi
{
    internal AddOnsApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="IAddOnsApi.WithRawResponse"/>
    public AddOnsApiWithRawResponse WithRawResponse { get; }

    IAddOnsApiWithRawResponse IAddOnsApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public AsyncPager<AddOnsListPage, AddOn> ListAsync(
        AddOnsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        return Paging.Numbered<AddOnsListPage, AddOnListResponse, AddOn>(
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
    public async Task<AddOn> CreateAsync(
        CreateAddOnRequest createAddOnRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CreateAsync(createAddOnRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<AddOn> RetrieveAsync(
        string addonId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RetrieveAsync(addonId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<AddOn> UpdateAsync(
        string addonId,
        UpdateAddOnRequest updateAddOnRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .UpdateAsync(addonId, updateAddOnRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public Task ArchiveAsync(
        string addonId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    ) => WithRawResponse.ArchiveAsync(addonId, requestOptions, cancellationToken);

    /// <inheritdoc/>
    public async Task<ResolvedEntitlementListResponse> ListEntitlementsAsync(
        string addonId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .ListEntitlementsAsync(addonId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<EntitlementListResponse> CreateEntitlementAsync(
        string addonId,
        CreateEntitlementsRequest createEntitlementsRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CreateEntitlementAsync(addonId, createEntitlementsRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public Task UnarchiveAsync(
        string addonId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    ) => WithRawResponse.UnarchiveAsync(addonId, requestOptions, cancellationToken);
}

/// <summary>The <c>add_ons</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class AddOnsApiWithRawResponse : IAddOnsApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal AddOnsApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<AddOnListResponse>> ListAsync(
        AddOnsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new ApiRequest(HttpMethod.Get, "/api/v1/addons", "add_ons.list");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("search", options?.Search);
        request.AddQuery("currency", options?.Currency);
        request.AddQuery("include_archived", options?.IncludeArchived);
        request.AddQuery("order_by", options?.OrderBy);
        request.AddQuery("page", options?.Page);
        request.AddQuery("per_page", options?.PerPage);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.AddOnListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<AddOn>> CreateAsync(
        CreateAddOnRequest createAddOnRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(createAddOnRequest);

        var request = new ApiRequest(HttpMethod.Post, "/api/v1/addons", "add_ons.create");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(createAddOnRequest, MeteroidJsonContext.Default.CreateAddOnRequest);
        return _transport.SendJsonAsync(request, MeteroidJsonContext.Default.AddOn, requestOptions, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<ApiResponse<AddOn>> RetrieveAsync(
        string addonId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(addonId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/addons/{Uri.EscapeDataString(addonId)}",
            "add_ons.retrieve"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(request, MeteroidJsonContext.Default.AddOn, requestOptions, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<ApiResponse<AddOn>> UpdateAsync(
        string addonId,
        UpdateAddOnRequest updateAddOnRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(addonId);
        ArgumentNullException.ThrowIfNull(updateAddOnRequest);

        var request = new ApiRequest(
            HttpMethod.Patch,
            $"/api/v1/addons/{Uri.EscapeDataString(addonId)}",
            "add_ons.update"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(updateAddOnRequest, MeteroidJsonContext.Default.UpdateAddOnRequest);
        return _transport.SendJsonAsync(request, MeteroidJsonContext.Default.AddOn, requestOptions, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<ApiResponse> ArchiveAsync(
        string addonId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(addonId);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/addons/{Uri.EscapeDataString(addonId)}/archive",
            "add_ons.archive"
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
    public Task<ApiResponse<ResolvedEntitlementListResponse>> ListEntitlementsAsync(
        string addonId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(addonId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/addons/{Uri.EscapeDataString(addonId)}/entitlements",
            "add_ons.list_entitlements"
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
    public Task<ApiResponse<EntitlementListResponse>> CreateEntitlementAsync(
        string addonId,
        CreateEntitlementsRequest createEntitlementsRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(addonId);
        ArgumentNullException.ThrowIfNull(createEntitlementsRequest);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/addons/{Uri.EscapeDataString(addonId)}/entitlements",
            "add_ons.create_entitlement"
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
    public Task<ApiResponse> UnarchiveAsync(
        string addonId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(addonId);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/addons/{Uri.EscapeDataString(addonId)}/unarchive",
            "add_ons.unarchive"
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

/// <summary>A page of <see cref="AddOnsApi.ListAsync"/>: its <see cref="AddOnListResponse"/> body,
/// whose properties it repeats, and the paging members.</summary>
public sealed class AddOnsListPage : Page<AddOnsListPage, AddOnListResponse, AddOn>
{
    /// <summary>A page of <paramref name="items"/> from <paramref name="body"/>, for fakes of the operation in tests.</summary>
    /// <param name="body">The decoded response body.</param>
    /// <param name="items">The items of the page.</param>
    /// <param name="next">Fetches the next page; <c>null</c> on the last page.</param>
    public AddOnsListPage(
        AddOnListResponse body,
        IReadOnlyList<AddOn> items,
        Func<CancellationToken, Task<AddOnsListPage>>? next = null
    )
        : base(body, items, next) { }

    /// <inheritdoc cref="AddOnListResponse.Data"/>
    public IReadOnlyList<AddOn> Data => Body.Data;

    /// <inheritdoc cref="AddOnListResponse.PaginationMeta"/>
    public PaginationResponse PaginationMeta => Body.PaginationMeta;
}
