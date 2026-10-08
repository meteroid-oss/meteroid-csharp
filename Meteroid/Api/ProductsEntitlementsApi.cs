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

/// <summary>The <c>products.entitlements</c> operations, as <see cref="IProductsApi.Entitlements"/> exposes them; mock it in tests.</summary>
public interface IProductsEntitlementsApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IProductsEntitlementsApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// List product entitlements
    /// </summary>
    /// <param name="productId">The <c>product_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<ResolvedEntitlementListResponse> ListAsync(
        string productId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create product entitlements
    /// </summary>
    /// <remarks>
    /// <para>
    /// A product has no entitlement rows of its own: its entitlements are the feature-level
    /// defaults of the features scoped to it, which is what <c>GET</c> on this path resolves. Every
    /// spec must therefore target a feature belonging to <c>product_id</c>. Features that already
    /// carry a default entitlement are skipped.
    /// </para>
    /// <para>
    /// Specs are validated up front, but the writes are not atomic: each feature is written on
    /// its own, so a failure part-way can leave earlier specs committed. Retrying is safe.
    /// </para>
    /// </remarks>
    /// <param name="productId">The <c>product_id</c> path parameter.</param>
    /// <param name="createEntitlementsRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<EntitlementListResponse> CreateAsync(
        string productId,
        CreateEntitlementsRequest createEntitlementsRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>products.entitlements</c> operations, returning the status and headers of the response with its body.</summary>
public interface IProductsEntitlementsApiWithRawResponse
{
    /// <summary><see cref="IProductsEntitlementsApi.ListAsync"/>, with the status and headers of the response.</summary>
    /// <param name="productId">The <c>product_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<ResolvedEntitlementListResponse>> ListAsync(
        string productId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IProductsEntitlementsApi.CreateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="productId">The <c>product_id</c> path parameter.</param>
    /// <param name="createEntitlementsRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<EntitlementListResponse>> CreateAsync(
        string productId,
        CreateEntitlementsRequest createEntitlementsRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>products.entitlements</c> operations. Get it from <see cref="ProductsApi.Entitlements"/>.</summary>
public sealed partial class ProductsEntitlementsApi : IProductsEntitlementsApi
{
    internal ProductsEntitlementsApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="IProductsEntitlementsApi.WithRawResponse"/>
    public ProductsEntitlementsApiWithRawResponse WithRawResponse { get; }

    IProductsEntitlementsApiWithRawResponse IProductsEntitlementsApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<ResolvedEntitlementListResponse> ListAsync(
        string productId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .ListAsync(productId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<EntitlementListResponse> CreateAsync(
        string productId,
        CreateEntitlementsRequest createEntitlementsRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CreateAsync(productId, createEntitlementsRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>products.entitlements</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class ProductsEntitlementsApiWithRawResponse : IProductsEntitlementsApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal ProductsEntitlementsApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<ResolvedEntitlementListResponse>> ListAsync(
        string productId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(productId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/products/{Uri.EscapeDataString(productId)}/entitlements",
            "products_entitlements.list"
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
    public Task<ApiResponse<EntitlementListResponse>> CreateAsync(
        string productId,
        CreateEntitlementsRequest createEntitlementsRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(productId);
        ArgumentNullException.ThrowIfNull(createEntitlementsRequest);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/products/{Uri.EscapeDataString(productId)}/entitlements",
            "products_entitlements.create"
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
}
