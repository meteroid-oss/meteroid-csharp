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

/// <summary>The <c>coupons</c> operations, as <see cref="IMeteroidClient.Coupons"/> exposes them; mock it in tests.</summary>
public interface ICouponsApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    ICouponsApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// List coupons
    /// </summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <returns>Awaited, the first <see cref="CouponsListPage"/>; enumerated with <c>await foreach</c>,
    /// every item of every page, each page fetched as the enumeration reaches it.</returns>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    AsyncPager<CouponsListPage, Coupon> ListAsync(
        CouponsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a coupon
    /// </summary>
    /// <param name="createCouponRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Coupon> CreateAsync(
        CreateCouponRequest createCouponRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get coupon details
    /// </summary>
    /// <param name="couponId">The <c>coupon_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Coupon> RetrieveAsync(
        string couponId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a coupon
    /// </summary>
    /// <param name="couponId">The <c>coupon_id</c> path parameter.</param>
    /// <param name="updateCouponRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Coupon> UpdateAsync(
        string couponId,
        UpdateCouponRequest updateCouponRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Archive a coupon
    /// </summary>
    /// <param name="couponId">The <c>coupon_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task ArchiveAsync(
        string couponId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Disable a coupon
    /// </summary>
    /// <param name="couponId">The <c>coupon_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task DisableAsync(
        string couponId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Enable a coupon
    /// </summary>
    /// <param name="couponId">The <c>coupon_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task EnableAsync(
        string couponId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Unarchive a coupon
    /// </summary>
    /// <param name="couponId">The <c>coupon_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task UnarchiveAsync(
        string couponId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>coupons</c> operations, returning the status and headers of the response with its body.</summary>
public interface ICouponsApiWithRawResponse
{
    /// <summary>The single request of a page of <see cref="ICouponsApi.ListAsync"/>, with the status and headers of the response.</summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<CouponListResponse>> ListAsync(
        CouponsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICouponsApi.CreateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="createCouponRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Coupon>> CreateAsync(
        CreateCouponRequest createCouponRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICouponsApi.RetrieveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="couponId">The <c>coupon_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Coupon>> RetrieveAsync(
        string couponId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICouponsApi.UpdateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="couponId">The <c>coupon_id</c> path parameter.</param>
    /// <param name="updateCouponRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Coupon>> UpdateAsync(
        string couponId,
        UpdateCouponRequest updateCouponRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICouponsApi.ArchiveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="couponId">The <c>coupon_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse> ArchiveAsync(
        string couponId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICouponsApi.DisableAsync"/>, with the status and headers of the response.</summary>
    /// <param name="couponId">The <c>coupon_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse> DisableAsync(
        string couponId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICouponsApi.EnableAsync"/>, with the status and headers of the response.</summary>
    /// <param name="couponId">The <c>coupon_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse> EnableAsync(
        string couponId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICouponsApi.UnarchiveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="couponId">The <c>coupon_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse> UnarchiveAsync(
        string couponId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>coupons</c> operations. Get it from <see cref="MeteroidClient.Coupons"/>.</summary>
public sealed partial class CouponsApi : ICouponsApi
{
    internal CouponsApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="ICouponsApi.WithRawResponse"/>
    public CouponsApiWithRawResponse WithRawResponse { get; }

    ICouponsApiWithRawResponse ICouponsApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public AsyncPager<CouponsListPage, Coupon> ListAsync(
        CouponsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        return Paging.Numbered<CouponsListPage, CouponListResponse, Coupon>(
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
    public async Task<Coupon> CreateAsync(
        CreateCouponRequest createCouponRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CreateAsync(createCouponRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<Coupon> RetrieveAsync(
        string couponId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RetrieveAsync(couponId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<Coupon> UpdateAsync(
        string couponId,
        UpdateCouponRequest updateCouponRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .UpdateAsync(couponId, updateCouponRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public Task ArchiveAsync(
        string couponId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    ) => WithRawResponse.ArchiveAsync(couponId, requestOptions, cancellationToken);

    /// <inheritdoc/>
    public Task DisableAsync(
        string couponId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    ) => WithRawResponse.DisableAsync(couponId, requestOptions, cancellationToken);

    /// <inheritdoc/>
    public Task EnableAsync(
        string couponId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    ) => WithRawResponse.EnableAsync(couponId, requestOptions, cancellationToken);

    /// <inheritdoc/>
    public Task UnarchiveAsync(
        string couponId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    ) => WithRawResponse.UnarchiveAsync(couponId, requestOptions, cancellationToken);
}

/// <summary>The <c>coupons</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class CouponsApiWithRawResponse : ICouponsApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal CouponsApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<CouponListResponse>> ListAsync(
        CouponsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new ApiRequest(HttpMethod.Get, "/api/v1/coupons", "coupons.list");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("search", options?.Search);
        request.AddQuery("filter", options?.Filter);
        request.AddQuery("order_by", options?.OrderBy);
        request.AddQuery("page", options?.Page);
        request.AddQuery("per_page", options?.PerPage);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.CouponListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Coupon>> CreateAsync(
        CreateCouponRequest createCouponRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(createCouponRequest);

        var request = new ApiRequest(HttpMethod.Post, "/api/v1/coupons", "coupons.create");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(createCouponRequest, MeteroidJsonContext.Default.CreateCouponRequest);
        return _transport.SendJsonAsync(request, MeteroidJsonContext.Default.Coupon, requestOptions, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Coupon>> RetrieveAsync(
        string couponId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(couponId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/coupons/{Uri.EscapeDataString(couponId)}",
            "coupons.retrieve"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(request, MeteroidJsonContext.Default.Coupon, requestOptions, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Coupon>> UpdateAsync(
        string couponId,
        UpdateCouponRequest updateCouponRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(couponId);
        ArgumentNullException.ThrowIfNull(updateCouponRequest);

        var request = new ApiRequest(
            HttpMethod.Patch,
            $"/api/v1/coupons/{Uri.EscapeDataString(couponId)}",
            "coupons.update"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(updateCouponRequest, MeteroidJsonContext.Default.UpdateCouponRequest);
        return _transport.SendJsonAsync(request, MeteroidJsonContext.Default.Coupon, requestOptions, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<ApiResponse> ArchiveAsync(
        string couponId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(couponId);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/coupons/{Uri.EscapeDataString(couponId)}/archive",
            "coupons.archive"
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
    public Task<ApiResponse> DisableAsync(
        string couponId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(couponId);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/coupons/{Uri.EscapeDataString(couponId)}/disable",
            "coupons.disable"
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
    public Task<ApiResponse> EnableAsync(
        string couponId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(couponId);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/coupons/{Uri.EscapeDataString(couponId)}/enable",
            "coupons.enable"
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
        string couponId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(couponId);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/coupons/{Uri.EscapeDataString(couponId)}/unarchive",
            "coupons.unarchive"
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

/// <summary>A page of <see cref="CouponsApi.ListAsync"/>: its <see cref="CouponListResponse"/> body,
/// whose properties it repeats, and the paging members.</summary>
public sealed class CouponsListPage : Page<CouponsListPage, CouponListResponse, Coupon>
{
    /// <summary>A page of <paramref name="items"/> from <paramref name="body"/>, for fakes of the operation in tests.</summary>
    /// <param name="body">The decoded response body.</param>
    /// <param name="items">The items of the page.</param>
    /// <param name="next">Fetches the next page; <c>null</c> on the last page.</param>
    public CouponsListPage(
        CouponListResponse body,
        IReadOnlyList<Coupon> items,
        Func<CancellationToken, Task<CouponsListPage>>? next = null
    )
        : base(body, items, next) { }

    /// <inheritdoc cref="CouponListResponse.Data"/>
    public IReadOnlyList<Coupon> Data => Body.Data;

    /// <inheritdoc cref="CouponListResponse.PaginationMeta"/>
    public PaginationResponse PaginationMeta => Body.PaginationMeta;
}
