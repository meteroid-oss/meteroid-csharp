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

/// <summary>The <c>product_families</c> operations, as <see cref="IMeteroidClient.ProductFamilies"/> exposes them; mock it in tests.</summary>
public interface IProductFamiliesApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IProductFamiliesApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// List product families
    /// </summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<ProductFamilyListResponse> ListAsync(
        ProductFamiliesListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create product family
    /// </summary>
    /// <param name="productFamilyCreateRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<ProductFamily> CreateAsync(
        ProductFamilyCreateRequest productFamilyCreateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get product family
    /// </summary>
    /// <remarks>
    /// Retrieve a single product family by ID or alias.
    /// </remarks>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<ProductFamily> RetrieveAsync(
        string idOrAlias,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>product_families</c> operations, returning the status and headers of the response with its body.</summary>
public interface IProductFamiliesApiWithRawResponse
{
    /// <summary><see cref="IProductFamiliesApi.ListAsync"/>, with the status and headers of the response.</summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<ProductFamilyListResponse>> ListAsync(
        ProductFamiliesListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IProductFamiliesApi.CreateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="productFamilyCreateRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<ProductFamily>> CreateAsync(
        ProductFamilyCreateRequest productFamilyCreateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IProductFamiliesApi.RetrieveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="idOrAlias">The <c>id_or_alias</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<ProductFamily>> RetrieveAsync(
        string idOrAlias,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>product_families</c> operations. Get it from <see cref="MeteroidClient.ProductFamilies"/>.</summary>
public sealed partial class ProductFamiliesApi : IProductFamiliesApi
{
    internal ProductFamiliesApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="IProductFamiliesApi.WithRawResponse"/>
    public ProductFamiliesApiWithRawResponse WithRawResponse { get; }

    IProductFamiliesApiWithRawResponse IProductFamiliesApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<ProductFamilyListResponse> ListAsync(
        ProductFamiliesListOptions? options = null,
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
    public async Task<ProductFamily> CreateAsync(
        ProductFamilyCreateRequest productFamilyCreateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CreateAsync(productFamilyCreateRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<ProductFamily> RetrieveAsync(
        string idOrAlias,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RetrieveAsync(idOrAlias, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>product_families</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class ProductFamiliesApiWithRawResponse : IProductFamiliesApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal ProductFamiliesApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<ProductFamilyListResponse>> ListAsync(
        ProductFamiliesListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new ApiRequest(HttpMethod.Get, "/api/v1/product_families", "product_families.list");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("order_by", options?.OrderBy);
        request.AddQuery("page", options?.Page);
        request.AddQuery("per_page", options?.PerPage);
        request.AddQuery("search", options?.Search);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.ProductFamilyListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<ProductFamily>> CreateAsync(
        ProductFamilyCreateRequest productFamilyCreateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(productFamilyCreateRequest);

        var request = new ApiRequest(HttpMethod.Post, "/api/v1/product_families", "product_families.create");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(productFamilyCreateRequest, MeteroidJsonContext.Default.ProductFamilyCreateRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.ProductFamily,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<ProductFamily>> RetrieveAsync(
        string idOrAlias,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(idOrAlias);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/product_families/{Uri.EscapeDataString(idOrAlias)}",
            "product_families.retrieve"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.ProductFamily,
            requestOptions,
            cancellationToken
        );
    }
}
