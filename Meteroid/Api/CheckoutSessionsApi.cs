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

/// <summary>The <c>checkout_sessions</c> operations, as <see cref="IMeteroidClient.CheckoutSessions"/> exposes them; mock it in tests.</summary>
public interface ICheckoutSessionsApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    ICheckoutSessionsApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// List checkout sessions
    /// </summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<ListCheckoutSessionsResponse> ListAsync(
        CheckoutSessionsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a checkout session
    /// </summary>
    /// <param name="createCheckoutSessionRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<CreateCheckoutSessionResponse> CreateAsync(
        CreateCheckoutSessionRequest createCheckoutSessionRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get a checkout session by ID
    /// </summary>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<GetCheckoutSessionResponse> RetrieveAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Cancel a checkout session
    /// </summary>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<CancelCheckoutSessionResponse> CancelAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>checkout_sessions</c> operations, returning the status and headers of the response with its body.</summary>
public interface ICheckoutSessionsApiWithRawResponse
{
    /// <summary><see cref="ICheckoutSessionsApi.ListAsync"/>, with the status and headers of the response.</summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<ListCheckoutSessionsResponse>> ListAsync(
        CheckoutSessionsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICheckoutSessionsApi.CreateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="createCheckoutSessionRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<CreateCheckoutSessionResponse>> CreateAsync(
        CreateCheckoutSessionRequest createCheckoutSessionRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICheckoutSessionsApi.RetrieveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<GetCheckoutSessionResponse>> RetrieveAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ICheckoutSessionsApi.CancelAsync"/>, with the status and headers of the response.</summary>
    /// <param name="id">The <c>id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<CancelCheckoutSessionResponse>> CancelAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>checkout_sessions</c> operations. Get it from <see cref="MeteroidClient.CheckoutSessions"/>.</summary>
public sealed partial class CheckoutSessionsApi : ICheckoutSessionsApi
{
    internal CheckoutSessionsApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="ICheckoutSessionsApi.WithRawResponse"/>
    public CheckoutSessionsApiWithRawResponse WithRawResponse { get; }

    ICheckoutSessionsApiWithRawResponse ICheckoutSessionsApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<ListCheckoutSessionsResponse> ListAsync(
        CheckoutSessionsListOptions? options = null,
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
    public async Task<CreateCheckoutSessionResponse> CreateAsync(
        CreateCheckoutSessionRequest createCheckoutSessionRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CreateAsync(createCheckoutSessionRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<GetCheckoutSessionResponse> RetrieveAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse.RetrieveAsync(id, requestOptions, cancellationToken).ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<CancelCheckoutSessionResponse> CancelAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse.CancelAsync(id, requestOptions, cancellationToken).ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>checkout_sessions</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class CheckoutSessionsApiWithRawResponse : ICheckoutSessionsApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal CheckoutSessionsApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<ListCheckoutSessionsResponse>> ListAsync(
        CheckoutSessionsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new ApiRequest(HttpMethod.Get, "/api/v1/checkout-sessions", "checkout_sessions.list");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("customer_id", options?.CustomerId);
        request.AddQuery("status", options?.Status);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.ListCheckoutSessionsResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<CreateCheckoutSessionResponse>> CreateAsync(
        CreateCheckoutSessionRequest createCheckoutSessionRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(createCheckoutSessionRequest);

        var request = new ApiRequest(HttpMethod.Post, "/api/v1/checkout-sessions", "checkout_sessions.create");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(createCheckoutSessionRequest, MeteroidJsonContext.Default.CreateCheckoutSessionRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.CreateCheckoutSessionResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<GetCheckoutSessionResponse>> RetrieveAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(id);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/checkout-sessions/{Uri.EscapeDataString(id)}",
            "checkout_sessions.retrieve"
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
            MeteroidJsonContext.Default.GetCheckoutSessionResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<CancelCheckoutSessionResponse>> CancelAsync(
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(id);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/checkout-sessions/{Uri.EscapeDataString(id)}/cancel",
            "checkout_sessions.cancel"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.CancelCheckoutSessionResponse,
            requestOptions,
            cancellationToken
        );
    }
}
