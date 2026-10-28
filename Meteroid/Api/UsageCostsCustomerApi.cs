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

/// <summary>The <c>usage_costs.customer</c> operations, as <see cref="IUsageCostsApi.Customer"/> exposes them; mock it in tests.</summary>
public interface IUsageCostsCustomerApi
{
    /// <summary>The same operations, returning the status and headers of the response with its body.</summary>
    IUsageCostsCustomerApiWithRawResponse WithRawResponse { get; }

    /// <summary>
    /// List a customer's usage costs over time
    /// </summary>
    /// <remarks>
    /// <para>
    /// A customer's usage of one billable metric and what it costs, per hour, day or month, optionally
    /// split by an event property, summed across the subscriptions that bill it. Buckets are cut at UTC
    /// boundaries and only cover the customer's billing periods. Per-unit and matrix pricing give exact
    /// costs. For pricing that depends on the whole period's usage (tiered, volume, package, capacity),
    /// a bucket's cost is what it adds to the period's price so far and <c>exact</c> is false. The range is
    /// at most 93 days.
    /// </para>
    /// <para>
    /// Beta: the request and response shapes of this endpoint may change before general availability.
    /// </para>
    /// </remarks>
    /// <param name="customerId">The <c>customer_id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<UsageCostListResponse> ListCostsAsync(
        string customerId,
        UsageCostsCustomerListCostsOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List a customer's usage events with their cost
    /// </summary>
    /// <remarks>
    /// <para>
    /// A customer's events for one billable metric, oldest first, each with the units it adds and what
    /// they cost at the price in force. The cost is exact for per-unit and matrix pricing and absent
    /// for pricing that depends on the whole period's usage (tiered, volume, package, capacity) and for
    /// aggregations that cannot be split per event. The range is at most 93 days.
    /// </para>
    /// <para>
    /// Beta: the request and response shapes of this endpoint may change before general availability.
    /// </para>
    /// </remarks>
    /// <param name="customerId">The <c>customer_id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    /// <exception cref="BadRequestException">400: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="UnauthorizedException">401: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="NotFoundException">404: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="RateLimitException">429: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    /// <exception cref="ServerErrorException">500: <c>Error</c> is the <see cref="Models.RestErrorResponse"/> body.</exception>
    Task<UsageEventListResponse> ListEventsAsync(
        string customerId,
        UsageCostsCustomerListEventsOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>usage_costs.customer</c> operations, returning the status and headers of the response with its body.</summary>
public interface IUsageCostsCustomerApiWithRawResponse
{
    /// <summary><see cref="IUsageCostsCustomerApi.ListCostsAsync"/>, with the status and headers of the response.</summary>
    /// <param name="customerId">The <c>customer_id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<UsageCostListResponse>> ListCostsAsync(
        string customerId,
        UsageCostsCustomerListCostsOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );

    /// <summary><see cref="IUsageCostsCustomerApi.ListEventsAsync"/>, with the status and headers of the response.</summary>
    /// <param name="customerId">The <c>customer_id</c> path parameter.</param>
    /// <param name="options">The query and header parameters.</param>
    /// <param name="requestOptions">Headers, timeout, retries or idempotency key of this call.</param>
    /// <param name="cancellationToken">Cancels the call.</param>
    Task<ApiResponse<UsageEventListResponse>> ListEventsAsync(
        string customerId,
        UsageCostsCustomerListEventsOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    );
}

/// <summary>The <c>usage_costs.customer</c> operations. Get it from <see cref="UsageCostsApi.Customer"/>.</summary>
public sealed partial class UsageCostsCustomerApi : IUsageCostsCustomerApi
{
    internal UsageCostsCustomerApi(ApiTransport transport)
    {
        WithRawResponse = new(transport);
    }

    /// <inheritdoc cref="IUsageCostsCustomerApi.WithRawResponse"/>
    public UsageCostsCustomerApiWithRawResponse WithRawResponse { get; }

    IUsageCostsCustomerApiWithRawResponse IUsageCostsCustomerApi.WithRawResponse => WithRawResponse;

    /// <inheritdoc/>
    public async Task<UsageCostListResponse> ListCostsAsync(
        string customerId,
        UsageCostsCustomerListCostsOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .ListCostsAsync(customerId, options, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }

    /// <inheritdoc/>
    public async Task<UsageEventListResponse> ListEventsAsync(
        string customerId,
        UsageCostsCustomerListEventsOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await WithRawResponse
            .ListEventsAsync(customerId, options, requestOptions, cancellationToken)
            .ConfigureAwait(false);
        return response.Value;
    }
}

/// <summary>The <c>usage_costs.customer</c> operations, returning the status and headers of the response with its body.</summary>
public sealed class UsageCostsCustomerApiWithRawResponse : IUsageCostsCustomerApiWithRawResponse
{
    private readonly ApiTransport _transport;

    internal UsageCostsCustomerApiWithRawResponse(ApiTransport transport)
    {
        _transport = transport;
    }

    /// <inheritdoc/>
    public Task<ApiResponse<UsageCostListResponse>> ListCostsAsync(
        string customerId,
        UsageCostsCustomerListCostsOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(customerId);
        ArgumentNullException.ThrowIfNull(options);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/usage/customer/{Uri.EscapeDataString(customerId)}/costs",
            "usage_costs_customer.list_costs"
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
        string customerId,
        UsageCostsCustomerListEventsOptions options,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentException.ThrowIfNullOrEmpty(customerId);
        ArgumentNullException.ThrowIfNull(options);

        var request = new ApiRequest(
            HttpMethod.Get,
            $"/api/v1/usage/customer/{Uri.EscapeDataString(customerId)}/events",
            "usage_costs_customer.list_events"
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
