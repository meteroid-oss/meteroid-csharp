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

/// <summary>The <c>subscriptions</c> operations, as <see cref="IMeteroidClient.Subscriptions"/> exposes them; mock it in tests.</summary>
public interface ISubscriptionsApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    ISubscriptionsApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// List subscriptions with optional filtering by customer or plan.
    /// </summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<SubscriptionListResponse> ListAsync(
        SubscriptionsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create subscription
    /// </summary>
    /// <remarks>
    /// Create a new subscription for a customer with a specific plan.
    /// </remarks>
    /// <param name="subscriptionCreateRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<SubscriptionDetails> CreateAsync(
        SubscriptionCreateRequest subscriptionCreateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get subscription details
    /// </summary>
    /// <remarks>
    /// Retrieve detailed information about a subscription including price components and schedules.
    /// </remarks>
    /// <param name="subscriptionId">The <c>subscription_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<SubscriptionDetails> RetrieveAsync(
        string subscriptionId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update subscription settings like payment configuration, billing options, etc.
    /// </summary>
    /// <param name="subscriptionId">The <c>subscription_id</c> path parameter.</param>
    /// <param name="subscriptionUpdateRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<SubscriptionUpdateResponse> UpdateAsync(
        string subscriptionId,
        SubscriptionUpdateRequest subscriptionUpdateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Cancel subscription
    /// </summary>
    /// <remarks>
    /// Cancel a subscription either immediately or at the end of the billing period.
    /// </remarks>
    /// <param name="subscriptionId">The <c>subscription_id</c> path parameter.</param>
    /// <param name="cancelSubscriptionRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<CancelSubscriptionResponse> CancelAsync(
        string subscriptionId,
        CancelSubscriptionRequest cancelSubscriptionRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List subscription entitlements
    /// </summary>
    /// <param name="subscriptionId">The <c>subscription_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<EffectiveEntitlementListResponse> ListEntitlementsAsync(
        string subscriptionId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get subscription summary
    /// </summary>
    /// <remarks>
    /// Retrieve a subscription without its components, add-ons, coupons and entitlements: the same
    /// shape as list items, for callers that only need status and billing dates.
    /// </remarks>
    /// <param name="subscriptionId">The <c>subscription_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<Subscription> RetrieveSummaryAsync(
        string subscriptionId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>subscriptions</c> operations, returning the status and headers of the response with its body.</summary>
public interface ISubscriptionsApiWithRawResponse
{
    /// <summary><see cref="ISubscriptionsApi.ListAsync"/>, with the status and headers of the response.</summary>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<SubscriptionListResponse>> ListAsync(
        SubscriptionsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ISubscriptionsApi.CreateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="subscriptionCreateRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<SubscriptionDetails>> CreateAsync(
        SubscriptionCreateRequest subscriptionCreateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ISubscriptionsApi.RetrieveAsync"/>, with the status and headers of the response.</summary>
    /// <param name="subscriptionId">The <c>subscription_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<SubscriptionDetails>> RetrieveAsync(
        string subscriptionId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ISubscriptionsApi.UpdateAsync"/>, with the status and headers of the response.</summary>
    /// <param name="subscriptionId">The <c>subscription_id</c> path parameter.</param>
    /// <param name="subscriptionUpdateRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<SubscriptionUpdateResponse>> UpdateAsync(
        string subscriptionId,
        SubscriptionUpdateRequest subscriptionUpdateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ISubscriptionsApi.CancelAsync"/>, with the status and headers of the response.</summary>
    /// <param name="subscriptionId">The <c>subscription_id</c> path parameter.</param>
    /// <param name="cancelSubscriptionRequest">The request body.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<CancelSubscriptionResponse>> CancelAsync(
        string subscriptionId,
        CancelSubscriptionRequest cancelSubscriptionRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ISubscriptionsApi.ListEntitlementsAsync"/>, with the status and headers of the response.</summary>
    /// <param name="subscriptionId">The <c>subscription_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<EffectiveEntitlementListResponse>> ListEntitlementsAsync(
        string subscriptionId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="ISubscriptionsApi.RetrieveSummaryAsync"/>, with the status and headers of the response.</summary>
    /// <param name="subscriptionId">The <c>subscription_id</c> path parameter.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<Subscription>> RetrieveSummaryAsync(
        string subscriptionId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>subscriptions</c> operations. Get it from <see cref="MeteroidClient.Subscriptions"/>.</summary>
public sealed partial class SubscriptionsApi : ISubscriptionsApi
{
    internal SubscriptionsApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="ISubscriptionsApi.WithRawResponse"/>
    public SubscriptionsApiWithRawResponse WithRawResponse { get; }

    ISubscriptionsApiWithRawResponse ISubscriptionsApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<SubscriptionListResponse> ListAsync(
        SubscriptionsListOptions? options = null,
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
    public async Task<SubscriptionDetails> CreateAsync(
        SubscriptionCreateRequest subscriptionCreateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CreateAsync(subscriptionCreateRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<SubscriptionDetails> RetrieveAsync(
        string subscriptionId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RetrieveAsync(subscriptionId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<SubscriptionUpdateResponse> UpdateAsync(
        string subscriptionId,
        SubscriptionUpdateRequest subscriptionUpdateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .UpdateAsync(subscriptionId, subscriptionUpdateRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<CancelSubscriptionResponse> CancelAsync(
        string subscriptionId,
        CancelSubscriptionRequest cancelSubscriptionRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .CancelAsync(subscriptionId, cancelSubscriptionRequest, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<EffectiveEntitlementListResponse> ListEntitlementsAsync(
        string subscriptionId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .ListEntitlementsAsync(subscriptionId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<Subscription> RetrieveSummaryAsync(
        string subscriptionId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .RetrieveSummaryAsync(subscriptionId, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>subscriptions</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class SubscriptionsApiWithRawResponse : ISubscriptionsApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal SubscriptionsApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<SubscriptionListResponse>> ListAsync(
        SubscriptionsListOptions? options = null,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new ApiRequest(HttpMethod.Get, "/api/v1/subscriptions", "subscriptions.list");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("customer_id", options?.CustomerId);
        request.AddQuery("plan_id", options?.PlanId);
        request.AddQuery("statuses", options?.Statuses);
        request.AddQuery("order_by", options?.OrderBy);
        request.AddQuery("page", options?.Page);
        request.AddQuery("per_page", options?.PerPage);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.SubscriptionListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<SubscriptionDetails>> CreateAsync(
        SubscriptionCreateRequest subscriptionCreateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(subscriptionCreateRequest);

        var request = new ApiRequest(HttpMethod.Post, "/api/v1/subscriptions", "subscriptions.create");
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(subscriptionCreateRequest, MeteroidJsonContext.Default.SubscriptionCreateRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.SubscriptionDetails,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<SubscriptionDetails>> RetrieveAsync(
        string subscriptionId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(subscriptionId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/subscriptions/{Uri.EscapeDataString(subscriptionId)}",
            "subscriptions.retrieve"
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
            MeteroidJsonContext.Default.SubscriptionDetails,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<SubscriptionUpdateResponse>> UpdateAsync(
        string subscriptionId,
        SubscriptionUpdateRequest subscriptionUpdateRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(subscriptionId);
        ArgumentNullException.ThrowIfNull(subscriptionUpdateRequest);

        var request = new ApiRequest(
            HttpMethod.Patch,
            $"/api/v1/subscriptions/{Uri.EscapeDataString(subscriptionId)}",
            "subscriptions.update"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(subscriptionUpdateRequest, MeteroidJsonContext.Default.SubscriptionUpdateRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.SubscriptionUpdateResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<CancelSubscriptionResponse>> CancelAsync(
        string subscriptionId,
        CancelSubscriptionRequest cancelSubscriptionRequest,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(subscriptionId);
        ArgumentNullException.ThrowIfNull(cancelSubscriptionRequest);

        var request = new ApiRequest(
            HttpMethod.Post,
            $"/api/v1/subscriptions/{Uri.EscapeDataString(subscriptionId)}/cancel",
            "subscriptions.cancel"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.SetJsonBody(cancelSubscriptionRequest, MeteroidJsonContext.Default.CancelSubscriptionRequest);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.CancelSubscriptionResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<EffectiveEntitlementListResponse>> ListEntitlementsAsync(
        string subscriptionId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(subscriptionId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/subscriptions/{Uri.EscapeDataString(subscriptionId)}/entitlements",
            "subscriptions.list_entitlements"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
        };
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.EffectiveEntitlementListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<Subscription>> RetrieveSummaryAsync(
        string subscriptionId,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(subscriptionId);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/subscriptions/{Uri.EscapeDataString(subscriptionId)}/summary",
            "subscriptions.retrieve_summary"
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
            MeteroidJsonContext.Default.Subscription,
            requestOptions,
            cancellationToken
        );
    }
}
