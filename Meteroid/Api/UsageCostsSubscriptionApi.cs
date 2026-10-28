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

/// <summary>The <c>usage_costs.subscription</c> operations, as <see cref="IUsageCostsApi.Subscription"/> exposes them; mock it in tests.</summary>
public interface IUsageCostsSubscriptionApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IUsageCostsSubscriptionApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// List a subscription's usage costs over time
    /// </summary>
    /// <remarks>
    /// <para>
    /// The subscription's usage of one billable metric and what it costs, as for a customer but
    /// counting only the events the subscription bills (see its usage filter) and only its own billing
    /// periods. The range is at most 93 days.
    /// </para>
    /// <para>
    /// Beta: the request and response shapes of this endpoint may change before general availability.
    /// </para>
    /// </remarks>
    /// <param name="subscriptionId">The <c>subscription_id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<UsageCostListResponse> ListCostsAsync(
        string subscriptionId,
        UsageCostsSubscriptionListCostsOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List a subscription's usage events with their cost
    /// </summary>
    /// <remarks>
    /// <para>
    /// The events of one billable metric that the subscription bills, oldest first: with a usage
    /// filter, only the customer's events matching it; without, those no other subscription's filter
    /// claims. Costs are as for the customer's events. The range is at most 93 days.
    /// </para>
    /// <para>
    /// Beta: the request and response shapes of this endpoint may change before general availability.
    /// </para>
    /// </remarks>
    /// <param name="subscriptionId">The <c>subscription_id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<UsageEventListResponse> ListEventsAsync(
        string subscriptionId,
        UsageCostsSubscriptionListEventsOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>usage_costs.subscription</c> operations, returning the status and headers of the response with its body.</summary>
public interface IUsageCostsSubscriptionApiWithRawResponse
{
    /// <summary><see cref="IUsageCostsSubscriptionApi.ListCostsAsync"/>, with the status and headers of the response.</summary>
    /// <param name="subscriptionId">The <c>subscription_id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<UsageCostListResponse>> ListCostsAsync(
        string subscriptionId,
        UsageCostsSubscriptionListCostsOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IUsageCostsSubscriptionApi.ListEventsAsync"/>, with the status and headers of the response.</summary>
    /// <param name="subscriptionId">The <c>subscription_id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<UsageEventListResponse>> ListEventsAsync(
        string subscriptionId,
        UsageCostsSubscriptionListEventsOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>usage_costs.subscription</c> operations. Get it from <see cref="UsageCostsApi.Subscription"/>.</summary>
public sealed partial class UsageCostsSubscriptionApi : IUsageCostsSubscriptionApi
{
    internal UsageCostsSubscriptionApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="IUsageCostsSubscriptionApi.WithRawResponse"/>
    public UsageCostsSubscriptionApiWithRawResponse WithRawResponse { get; }

    IUsageCostsSubscriptionApiWithRawResponse IUsageCostsSubscriptionApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<UsageCostListResponse> ListCostsAsync(
        string subscriptionId,
        UsageCostsSubscriptionListCostsOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .ListCostsAsync(subscriptionId, options, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<UsageEventListResponse> ListEventsAsync(
        string subscriptionId,
        UsageCostsSubscriptionListEventsOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .ListEventsAsync(subscriptionId, options, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>usage_costs.subscription</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class UsageCostsSubscriptionApiWithRawResponse : IUsageCostsSubscriptionApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal UsageCostsSubscriptionApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<UsageCostListResponse>> ListCostsAsync(
        string subscriptionId,
        UsageCostsSubscriptionListCostsOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(subscriptionId);
        ArgumentNullException.ThrowIfNull(options);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/usage/subscription/{Uri.EscapeDataString(subscriptionId)}/costs",
            "usage_costs_subscription.list_costs"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("metric", options.Metric);
        request.AddQuery("group_by", options.GroupBy);
        request.AddQuery("granularity", options.Granularity);
        request.AddQuery("from", options.From);
        request.AddQuery("to", options.To);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.UsageCostListResponse,
            requestOptions,
            cancellationToken
        );
    }

    /// <inheritdoc/>
    public Task<ApiResponse<UsageEventListResponse>> ListEventsAsync(
        string subscriptionId,
        UsageCostsSubscriptionListEventsOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(subscriptionId);
        ArgumentNullException.ThrowIfNull(options);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/usage/subscription/{Uri.EscapeDataString(subscriptionId)}/events",
            "usage_costs_subscription.list_events"
        );
        request.ErrorTypes = new KeyValuePair<string, JsonTypeInfo>[]
        {
            new("400", MeteroidJsonContext.Default.RestErrorResponse),
            new("401", MeteroidJsonContext.Default.RestErrorResponse),
            new("404", MeteroidJsonContext.Default.RestErrorResponse),
            new("429", MeteroidJsonContext.Default.RestErrorResponse),
            new("500", MeteroidJsonContext.Default.RestErrorResponse),
        };
        request.AddQuery("metric", options.Metric);
        request.AddQuery("from", options.From);
        request.AddQuery("to", options.To);
        request.AddQuery("cursor", options.Cursor);
        request.AddQuery("limit", options.Limit);
        return _transport.SendJsonAsync(
            request,
            MeteroidJsonContext.Default.UsageEventListResponse,
            requestOptions,
            cancellationToken
        );
    }
}
