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

/// <summary>The <c>webhook_endpoints.endpoints</c> operations, as <see cref="IWebhookEndpointsApi.Endpoints"/> exposes them; mock it in tests.</summary>
public interface IWebhookEndpointsEndpointsApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IWebhookEndpointsEndpointsApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// List webhook endpoints
    /// </summary>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<WebhookEndpointListResponse> ListAsync(
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a webhook endpoint
    /// </summary>
    /// <remarks>
    /// The signing secret is returned once, in this response only.
    /// </remarks>
    /// <param name="createWebhookEndpointRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ConflictException">409: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<CreatedWebhookEndpoint> CreateAsync(
        CreateWebhookEndpointRequest createWebhookEndpointRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a webhook endpoint
    /// </summary>
    /// <param name="endpointId">The <c>endpoint_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<WebhookEndpoint> RetrieveAsync(
        string endpointId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Delete a webhook endpoint
    /// </summary>
    /// <remarks>
    /// The endpoint is archived and its pending deliveries are cancelled.
    /// </remarks>
    /// <param name="endpointId">The <c>endpoint_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task DeleteAsync(
        string endpointId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update a webhook endpoint
    /// </summary>
    /// <remarks>
    /// Omitted fields are left untouched. Re-enabling a disabled endpoint resets its
    /// consecutive failure count.
    /// </remarks>
    /// <param name="endpointId">The <c>endpoint_id</c> path parameter.</param>
    /// <param name="updateWebhookEndpointRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<WebhookEndpoint> UpdateAsync(
        string endpointId,
        UpdateWebhookEndpointRequest updateWebhookEndpointRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List deliveries for a webhook endpoint
    /// </summary>
    /// <param name="endpointId">The <c>endpoint_id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <returns>Awaited, the first <see cref="WebhookEndpointsEndpointsListDeliveriesPage"/>; enumerated with <c>await foreach</c>,
    /// every item of every page, each page fetched as the enumeration reaches it.</returns>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    AsyncPager<WebhookEndpointsEndpointsListDeliveriesPage, WebhookDelivery> ListDeliveriesAsync(
        string endpointId,
        WebhookEndpointsEndpointsListDeliveriesOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Rotate a webhook endpoint secret
    /// </summary>
    /// <remarks>
    /// The previous secret keeps signing alongside the new one for 24 hours, so consumers
    /// can roll over without dropping events.
    /// </remarks>
    /// <param name="endpointId">The <c>endpoint_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<WebhookEndpointSecret> RotateSecretAsync(
        string endpointId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Reveal a webhook endpoint secret
    /// </summary>
    /// <param name="endpointId">The <c>endpoint_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<WebhookEndpointSecret> RetrieveSecretAsync(
        string endpointId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>webhook_endpoints.endpoints</c> operations, returning the status and headers of the response with its body.</summary>
public interface IWebhookEndpointsEndpointsApiWithRawResponse
{
    /// <summary><see cref="IWebhookEndpointsEndpointsApi.ListAsync"/>, with the status and headers of the response.</summary>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<WebhookEndpointListResponse>> ListAsync(
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IWebhookEndpointsEndpointsApi.CreateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="createWebhookEndpointRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<CreatedWebhookEndpoint>> CreateAsync(
        CreateWebhookEndpointRequest createWebhookEndpointRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IWebhookEndpointsEndpointsApi.RetrieveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="endpointId">The <c>endpoint_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<WebhookEndpoint>> RetrieveAsync(
        string endpointId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IWebhookEndpointsEndpointsApi.DeleteAsync"/>, with the status and headers of the response.</summary>
    /// <param name="endpointId">The <c>endpoint_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse> DeleteAsync(
        string endpointId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IWebhookEndpointsEndpointsApi.UpdateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="endpointId">The <c>endpoint_id</c> path parameter.</param>
    /// <param name="updateWebhookEndpointRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<WebhookEndpoint>> UpdateAsync(
        string endpointId,
        UpdateWebhookEndpointRequest updateWebhookEndpointRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>The single request of a page of <see cref="IWebhookEndpointsEndpointsApi.ListDeliveriesAsync"/>, with the status and headers of the response.</summary>
    /// <param name="endpointId">The <c>endpoint_id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<WebhookDeliveryListResponse>> ListDeliveriesAsync(
        string endpointId,
        WebhookEndpointsEndpointsListDeliveriesOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IWebhookEndpointsEndpointsApi.RotateSecretAsync"/>, with the status and headers of the response.</summary>
    /// <param name="endpointId">The <c>endpoint_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<WebhookEndpointSecret>> RotateSecretAsync(
        string endpointId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IWebhookEndpointsEndpointsApi.RetrieveSecretAsync"/>, with the status and headers of the response.</summary>
    /// <param name="endpointId">The <c>endpoint_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<WebhookEndpointSecret>> RetrieveSecretAsync(
        string endpointId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>webhook_endpoints.endpoints</c> operations. Get it from <see cref="WebhookEndpointsApi.Endpoints"/>.</summary>
public sealed partial class WebhookEndpointsEndpointsApi : IWebhookEndpointsEndpointsApi
{
    internal WebhookEndpointsEndpointsApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="IWebhookEndpointsEndpointsApi.WithRawResponse"/>
    public WebhookEndpointsEndpointsApiWithRawResponse WithRawResponse { get; }

    IWebhookEndpointsEndpointsApiWithRawResponse IWebhookEndpointsEndpointsApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<WebhookEndpointListResponse> ListAsync(
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse.ListAsync(requestOptions, cancellationToken).ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<CreatedWebhookEndpoint> CreateAsync(
        CreateWebhookEndpointRequest createWebhookEndpointRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CreateAsync(createWebhookEndpointRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<WebhookEndpoint> RetrieveAsync(
        string endpointId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RetrieveAsync(endpointId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public Task DeleteAsync(
        string endpointId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    ) => WithRawResponse.DeleteAsync(endpointId, requestOptions, cancellationToken);

    /// <inheritdoc/>
    public async Task<WebhookEndpoint> UpdateAsync(
        string endpointId,
        UpdateWebhookEndpointRequest updateWebhookEndpointRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .UpdateAsync(endpointId, updateWebhookEndpointRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public AsyncPager<WebhookEndpointsEndpointsListDeliveriesPage, WebhookDelivery> ListDeliveriesAsync(
        string endpointId,
        WebhookEndpointsEndpointsListDeliveriesOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(endpointId);
        return Paging.Numbered<
            WebhookEndpointsEndpointsListDeliveriesPage,
            WebhookDeliveryListResponse,
            WebhookDelivery
        >(
            options?.Page ?? 0,
            0,
            pages: true,
            (param, ct) =>
                WithRawResponse.ListDeliveriesAsync(
                    endpointId,
                    (options ?? new()) with
                    {
                        Page = (int)param,
                    },
                    requestOptions,
                    ct
                ),
            (body, items, next) => new(body, items, next),
            body => body.Data,
            null,
            body => (long?)body.PaginationMeta?.TotalPages,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public async Task<WebhookEndpointSecret> RotateSecretAsync(
        string endpointId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RotateSecretAsync(endpointId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<WebhookEndpointSecret> RetrieveSecretAsync(
        string endpointId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RetrieveSecretAsync(endpointId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>webhook_endpoints.endpoints</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class WebhookEndpointsEndpointsApiWithRawResponse : IWebhookEndpointsEndpointsApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal WebhookEndpointsEndpointsApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<WebhookEndpointListResponse>> ListAsync(
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new ApiRequest(HttpMethod.Get, "/api/v1/webhooks/endpoints", "webhook_endpoints_endpoints.list");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.WebhookEndpointListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<CreatedWebhookEndpoint>> CreateAsync(
        CreateWebhookEndpointRequest createWebhookEndpointRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(createWebhookEndpointRequest);

        var request = new ApiRequest(
            HttpMethod.Post,
            "/api/v1/webhooks/endpoints",
            "webhook_endpoints_endpoints.create"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("409", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(createWebhookEndpointRequest, MeteroidJsonContext.Default.CreateWebhookEndpointRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.CreatedWebhookEndpoint,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<WebhookEndpoint>> RetrieveAsync(
        string endpointId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(endpointId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/webhooks/endpoints/{Uri.EscapeDataString(endpointId)}",
            "webhook_endpoints_endpoints.retrieve"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.WebhookEndpoint,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse> DeleteAsync(
        string endpointId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(endpointId);

        var request = new ApiRequest(
            HttpMethod.Delete,
            $"/api/v1/webhooks/endpoints/{Uri.EscapeDataString(endpointId)}",
            "webhook_endpoints_endpoints.delete"
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
    public Task<ApiResponse<WebhookEndpoint>> UpdateAsync(
        string endpointId,
        UpdateWebhookEndpointRequest updateWebhookEndpointRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(endpointId);
        ArgumentNullException.ThrowIfNull(updateWebhookEndpointRequest);

        var request = new ApiRequest(
            HttpMethod.Patch,
            $"/api/v1/webhooks/endpoints/{Uri.EscapeDataString(endpointId)}",
            "webhook_endpoints_endpoints.update"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(updateWebhookEndpointRequest, MeteroidJsonContext.Default.UpdateWebhookEndpointRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.WebhookEndpoint,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<WebhookDeliveryListResponse>> ListDeliveriesAsync(
        string endpointId,
        WebhookEndpointsEndpointsListDeliveriesOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(endpointId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/webhooks/endpoints/{Uri.EscapeDataString(endpointId)}/deliveries",
            "webhook_endpoints_endpoints.list_deliveries"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("status", options?.Status);
        request.AddQuery("page", options?.Page);
        request.AddQuery("per_page", options?.PerPage);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.WebhookDeliveryListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<WebhookEndpointSecret>> RotateSecretAsync(
        string endpointId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(endpointId);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/webhooks/endpoints/{Uri.EscapeDataString(endpointId)}/rotate-secret",
            "webhook_endpoints_endpoints.rotate_secret"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.WebhookEndpointSecret,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<WebhookEndpointSecret>> RetrieveSecretAsync(
        string endpointId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(endpointId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/webhooks/endpoints/{Uri.EscapeDataString(endpointId)}/secret",
            "webhook_endpoints_endpoints.retrieve_secret"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.WebhookEndpointSecret,
            requestOptions,
            cancellationToken
        );
    }
}

/// <summary>A page of <see cref="WebhookEndpointsEndpointsApi.ListDeliveriesAsync"/>: its <see cref="WebhookDeliveryListResponse"/> body,
/// whose properties it repeats, and the paging members.</summary>
public sealed class WebhookEndpointsEndpointsListDeliveriesPage
    : Page<WebhookEndpointsEndpointsListDeliveriesPage, WebhookDeliveryListResponse, WebhookDelivery>
{
    /// <summary>A page of <paramref name="items"/> from <paramref name="body"/>, for fakes of the operation in tests.</summary>
    /// <param name="body">The decoded response body.</param>
    /// <param name="items">The items of the page.</param>
    /// <param name="next">Fetches the next page; <c>null</c> on the last page.</param>
    public WebhookEndpointsEndpointsListDeliveriesPage(
        WebhookDeliveryListResponse body,
        IReadOnlyList<WebhookDelivery> items,
        Func<CancellationToken, Task<WebhookEndpointsEndpointsListDeliveriesPage>>? next = null
    )
        : base(body, items, next) { }

    /// <inheritdoc cref="WebhookDeliveryListResponse.Data"/>
    public IReadOnlyList<WebhookDelivery> Data => Body.Data;

    /// <inheritdoc cref="WebhookDeliveryListResponse.PaginationMeta"/>
    public PaginationResponse PaginationMeta => Body.PaginationMeta;
}
