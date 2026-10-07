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

/// <summary>The <c>products</c> operations, as <see cref="IMeteroidClient.Products"/> exposes them; mock it in tests.</summary>
public interface IProductsApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IProductsApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// List products
    /// </summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <returns>Awaited, the first <see cref="ProductsListPage"/>; enumerated with <c>await foreach</c>,
    /// every item of every page, each page fetched as the enumeration reaches it.</returns>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    AsyncPager<ProductsListPage, Product> ListAsync(
        ProductsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a product
    /// </summary>
    /// <param name="createProductRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Product> CreateAsync(
        CreateProductRequest createProductRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get product details
    /// </summary>
    /// <param name="productId">The <c>product_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Product> RetrieveAsync(
        string productId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a product
    /// </summary>
    /// <remarks>
    /// Partially update product fields. The fee_type is immutable and cannot be changed.
    /// </remarks>
    /// <param name="productId">The <c>product_id</c> path parameter.</param>
    /// <param name="updateProductRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Product> UpdateAsync(
        string productId,
        UpdateProductRequest updateProductRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Archive a product
    /// </summary>
    /// <param name="productId">The <c>product_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task ArchiveAsync(
        string productId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List product entitlements
    /// </summary>
    /// <param name="productId">The <c>product_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<ResolvedEntitlementListResponse> ListEntitlementsAsync(
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
    Task<EntitlementListResponse> CreateEntitlementAsync(
        string productId,
        CreateEntitlementsRequest createEntitlementsRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Unarchive a product
    /// </summary>
    /// <param name="productId">The <c>product_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task UnarchiveAsync(
        string productId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>products</c> operations, returning the status and headers of the response with its body.</summary>
public interface IProductsApiWithRawResponse
{
    /// <summary>The single request of a page of <see cref="IProductsApi.ListAsync"/>, with the status and headers of the response.</summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<ProductListResponse>> ListAsync(
        ProductsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IProductsApi.CreateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="createProductRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Product>> CreateAsync(
        CreateProductRequest createProductRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IProductsApi.RetrieveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="productId">The <c>product_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Product>> RetrieveAsync(
        string productId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IProductsApi.UpdateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="productId">The <c>product_id</c> path parameter.</param>
    /// <param name="updateProductRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Product>> UpdateAsync(
        string productId,
        UpdateProductRequest updateProductRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IProductsApi.ArchiveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="productId">The <c>product_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse> ArchiveAsync(
        string productId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IProductsApi.ListEntitlementsAsync"/>, with the status and headers of the response.</summary>
    /// <param name="productId">The <c>product_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<ResolvedEntitlementListResponse>> ListEntitlementsAsync(
        string productId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IProductsApi.CreateEntitlementAsync"/>, with the status and headers of the response.</summary>
    /// <param name="productId">The <c>product_id</c> path parameter.</param>
    /// <param name="createEntitlementsRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<EntitlementListResponse>> CreateEntitlementAsync(
        string productId,
        CreateEntitlementsRequest createEntitlementsRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IProductsApi.UnarchiveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="productId">The <c>product_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse> UnarchiveAsync(
        string productId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>products</c> operations. Get it from <see cref="MeteroidClient.Products"/>.</summary>
public sealed partial class ProductsApi : IProductsApi
{
    internal ProductsApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="IProductsApi.WithRawResponse"/>
    public ProductsApiWithRawResponse WithRawResponse { get; }

    IProductsApiWithRawResponse IProductsApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public AsyncPager<ProductsListPage, Product> ListAsync(
        ProductsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        return Paging.Numbered<ProductsListPage, ProductListResponse, Product>(
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
    public async Task<Product> CreateAsync(
        CreateProductRequest createProductRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CreateAsync(createProductRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<Product> RetrieveAsync(
        string productId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RetrieveAsync(productId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<Product> UpdateAsync(
        string productId,
        UpdateProductRequest updateProductRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .UpdateAsync(productId, updateProductRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public Task ArchiveAsync(
        string productId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    ) => WithRawResponse.ArchiveAsync(productId, requestOptions, cancellationToken);

    /// <inheritdoc/>
    public async Task<ResolvedEntitlementListResponse> ListEntitlementsAsync(
        string productId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .ListEntitlementsAsync(productId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<EntitlementListResponse> CreateEntitlementAsync(
        string productId,
        CreateEntitlementsRequest createEntitlementsRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CreateEntitlementAsync(productId, createEntitlementsRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public Task UnarchiveAsync(
        string productId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    ) => WithRawResponse.UnarchiveAsync(productId, requestOptions, cancellationToken);
}

/// <summary>The <c>products</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class ProductsApiWithRawResponse : IProductsApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal ProductsApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<ProductListResponse>> ListAsync(
        ProductsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new ApiRequest(HttpMethod.Get, "/api/v1/products", "products.list");
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
            MeteroidJsonContext.Default.ProductListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Product>> CreateAsync(
        CreateProductRequest createProductRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(createProductRequest);

        var request = new ApiRequest(HttpMethod.Post, "/api/v1/products", "products.create");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(createProductRequest, MeteroidJsonContext.Default.CreateProductRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.Product,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Product>> RetrieveAsync(
        string productId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(productId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/products/{Uri.EscapeDataString(productId)}",
            "products.retrieve"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.Product,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Product>> UpdateAsync(
        string productId,
        UpdateProductRequest updateProductRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(productId);
        ArgumentNullException.ThrowIfNull(updateProductRequest);

        var request = new ApiRequest(
            HttpMethod.Patch,
            $"/api/v1/products/{Uri.EscapeDataString(productId)}",
            "products.update"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(updateProductRequest, MeteroidJsonContext.Default.UpdateProductRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.Product,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse> ArchiveAsync(
        string productId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(productId);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/products/{Uri.EscapeDataString(productId)}/archive",
            "products.archive"
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
        string productId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(productId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/products/{Uri.EscapeDataString(productId)}/entitlements",
            "products.list_entitlements"
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
            "products.create_entitlement"
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
        string productId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(productId);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/products/{Uri.EscapeDataString(productId)}/unarchive",
            "products.unarchive"
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

/// <summary>A page of <see cref="ProductsApi.ListAsync"/>: its <see cref="ProductListResponse"/> body,
/// whose properties it repeats, and the paging members.</summary>
public sealed class ProductsListPage : Page<ProductsListPage, ProductListResponse, Product>
{
    /// <summary>A page of <paramref name="items"/> from <paramref name="body"/>, for fakes of the operation in tests.</summary>
    /// <param name="body">The decoded response body.</param>
    /// <param name="items">The items of the page.</param>
    /// <param name="next">Fetches the next page; <c>null</c> on the last page.</param>
    public ProductsListPage(
        ProductListResponse body,
        IReadOnlyList<Product> items,
        Func<CancellationToken, Task<ProductsListPage>>? next = null
    )
        : base(body, items, next) { }

    /// <inheritdoc cref="ProductListResponse.Data"/>
    public IReadOnlyList<Product> Data => Body.Data;

    /// <inheritdoc cref="ProductListResponse.PaginationMeta"/>
    public PaginationResponse PaginationMeta => Body.PaginationMeta;
}
